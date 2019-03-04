using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_API.Classes
{
    public static class Lab1
    {
        private static byte[] GetSameBytes(byte[] original, ref int index)
        {
            byte first = original[index], current = first;
            List<byte> bytes = new List<byte>() { first };
            for (; first == current && ++index < original.Length && bytes.Count < 128;)
            {
                current = original[index];
                if (first == current) bytes.Add(current);
            }
            index--;
            return bytes.ToArray();
        }

        private static void AddNotCompressedBytesToList(List<byte> compressed, List<byte> notCompressed)
        {
            byte control = (byte)(notCompressed.Count - 1);
            compressed.Add(control);
            compressed.AddRange(notCompressed);
        }

        public static byte[] RLE(byte[] original)
        {
            List<byte> compressed = new List<byte>();
            List<byte> notCompressed = new List<byte>();
            for (int index=0;index < original.Length;index++)
            {
                var bytes = GetSameBytes(original, ref index);
                if (bytes.Length >= 2)
                {
                    AddNotCompressedBytesToList(compressed, notCompressed);
                    notCompressed = new List<byte>();

                    byte control = (byte)((byte)(bytes.Length - 2) | (1 << 7));
                    compressed.Add(control);
                    compressed.Add(bytes.First());
                }
                else
                    notCompressed.Add(bytes.First());
            }
            return compressed.ToArray();
        }
    }
}
