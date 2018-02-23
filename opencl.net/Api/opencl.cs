using System;
using opencl.wrapper;

namespace opencl.Api {
    public static class OpenCLApi {
        public static Platforms GetPlatforms() {
            var platforms = new Platforms();

            UInt32 numPlatforms = 0;
            var error = OpenCL.clGetPlatformIDs(0, null, out numPlatforms);

            IntPtr[] platformIds = new IntPtr[numPlatforms];
            error = OpenCL.clGetPlatformIDs(numPlatforms, platformIds, out numPlatforms);
            
            foreach(var handle in platformIds) {
                platforms.Add(new Platform(handle));
            }

            return platforms;
        }
    }
}