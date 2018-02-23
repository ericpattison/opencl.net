using System;
using System.Collections.Generic;
using System.Linq;
using opencl.wrapper;

namespace opencl.Api {
    public class Platform {
        public IntPtr Handle { get; private set; }

        public Platform(IntPtr handle) {
            Handle = handle;
        }
    }

    public class Platforms : List<Platform> {
        public Platforms() {
            UInt32 numPlatforms = 0;
            var error = OpenCL.clGetPlatformIDs(0, null, out numPlatforms);

            IntPtr[] platformIds = new IntPtr[numPlatforms];
            error = OpenCL.clGetPlatformIDs(numPlatforms, platformIds, out numPlatforms);

            this.AddRange(platformIds.Select( handle => new Platform(handle)));
        }
    }
}