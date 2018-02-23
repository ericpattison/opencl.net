using System;
using System.Runtime.InteropServices;
using opencl.wrapper.enums;

namespace opencl.wrapper {
    internal static partial class OpenCL {
        [DllImport("OpenCL")]
        internal static extern ErrorCode clGetDeviceIDs(IntPtr platformId, DeviceType deviceType, UInt32 numEntries, [Out][MarshalAs(UnmanagedType.LPArray)]IntPtr[] deviceIds, out UInt32 numDevices);
    }
}