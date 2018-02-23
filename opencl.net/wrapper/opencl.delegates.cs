using System;
using System.Collections.Generic;
using System.Text;

namespace opencl.wrapper {
	internal static partial class OpenCL {
		internal delegate void ContextNotify(string errorInfo, byte[] data, IntPtr cb, IntPtr userData);
    }
}
