using opencl.wrapper.enums;
using System;
using System.Runtime.InteropServices;

namespace opencl.wrapper
{
    internal static partial class OpenCL {
		[DllImport("OpenCL")]
		internal static extern IntPtr clCreateContext([In][MarshalAs(UnmanagedType.LPArray)]ContextProperty[] properties, UInt32 numDevices, [In][MarshalAs(UnmanagedType.LPArray)]IntPtr[] devices, ContextNotify pfnNotify, IntPtr userData, out ErrorCode result);
    }
}
