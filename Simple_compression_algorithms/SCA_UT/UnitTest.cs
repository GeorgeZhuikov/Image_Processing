using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using IP_API.Classes;
using SCA_API.Classes;

namespace IP_UT
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Lab1Test()
        {
            var bytes = File.ReadAllBytes(@"C:\Repos\Simple_compression_algorithms\Simple_compression_algorithms\Simple_compression_algorithms\Resources\house_1.ppm");
            var compressed = Lab1.LZ77(bytes);
        }

        [TestMethod]
        public void Lab2Test()
        {
            var bytes = File.ReadAllBytes(@"C:\Repos\Simple_compression_algorithms\Simple_compression_algorithms\Simple_compression_algorithms\Resources\house_1.ppm");
            var ci = new CustomImage(bytes);
        }
    }
}
