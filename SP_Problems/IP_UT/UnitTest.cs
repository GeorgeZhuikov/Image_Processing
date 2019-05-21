using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using IP_API.Classes;
using IP_API.Classes;
using SCA_API.Classes;
using System;

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

        [TestMethod]
        public void Lab3Test()
        {
            var bytes = File.ReadAllBytes(@"C:\Repos\Simple_compression_algorithms\Simple_compression_algorithms\Simple_compression_algorithms\Resources\house_1.ppm");
            var ci = new CustomImage(bytes);
            new CustomImage(Lab3.Encode(ci.Image)).Save(@"C:\Users\q1\Desktop\FreeSpace\Test\testLab3EncodeResult.ppm");
            new CustomImage(Lab3.Decode(ci.Image)).Save(@"C:\Users\q1\Desktop\FreeSpace\Test\testLab3DecodeResult.ppm");
        }

        [TestMethod]
        public void Lab4Test()
        {
            var a_law = Lab4.A_law(BitConverter.GetBytes(666));
            Assert.AreEqual(a_law, (byte)241);
        }
    }
}
