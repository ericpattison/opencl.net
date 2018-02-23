namespace opencl.wrapper.enums {
    internal enum DeviceType : ulong {
        Default = (1 << 0),
        Cpu = (1 << 1),
        Gpu = (1 << 2),
        Accelerator = (1 << 3),
        All = 0xFFFFFFFF
    }
}