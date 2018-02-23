using opencl.wrapper;
using opencl.wrapper.enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace opencl.Api
{
    public class Context {
		public IntPtr Handle { get; private set; }

		public Context(IntPtr handle) {
			Handle = handle;
		}
    }

	public class Contexts : List<Context> {
		public Contexts(Devices devices) {
			var deviceIds = devices.Select(device => device.Handle).ToArray();
			ErrorCode result;
			this.Add(new Context(OpenCL.clCreateContext(null, (uint)deviceIds.Length, deviceIds, null, default(IntPtr), out result)));
		}
	}
}
