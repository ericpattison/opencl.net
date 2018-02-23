using System;
using System.Collections.Generic;
using System.Linq;
using opencl.wrapper;
using opencl.wrapper.enums;

namespace opencl.Api {
    public class Device {
        public IntPtr Handle { get; private set; }

        public Device(IntPtr handle) {
            Handle = handle;
        }
    }

    public class Devices : List<Device> {
        public Devices(Platforms platforms) {
			var handles = new List<IntPtr>();
			foreach(var platform in platforms) {
				handles.AddRange(GetDeviceIds(platform));
			}

			this.AddRange(handles.Select(handle => new Device(handle)));
        }

        private List<IntPtr> GetDeviceIds(Platform platform, DeviceType type = DeviceType.All) {
            uint numDevices = 0;
            var error = OpenCL.clGetDeviceIDs(platform.Handle, type, 0, null, out numDevices);

            IntPtr[] deviceIds = new IntPtr[numDevices];
            error = OpenCL.clGetDeviceIDs(platform.Handle, type, numDevices, deviceIds, out numDevices);
            return deviceIds.ToList();
        }
    }
}