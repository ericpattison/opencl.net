using opencl.wrapper.enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace opencl.wrapper {
    internal static partial class OpenCL {
        [DllImport("OpenCL")]
        internal static extern ErrorCode clGetPlatformIDs(UInt32 numEntries, [Out][MarshalAs(UnmanagedType.LPArray)]IntPtr[] platformIds, out UInt32 numPlatforms);
    }
}