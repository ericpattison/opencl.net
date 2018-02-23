using Microsoft.VisualStudio.TestTools.UnitTesting;
using opencl.Api;

namespace opencl.test {
	[TestClass]
    public class FullTest {
		[TestMethod]
		public void CompleteTest() {
			var platforms = new Platforms();
			var devices = new Devices(platforms);
			var contexts = new Contexts(devices);
		}
    }
}
