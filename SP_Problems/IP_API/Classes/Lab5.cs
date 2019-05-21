using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_API.Classes
{
    public static class Lab5
    {
        private static BitArray GetCompressedByte(byte[] bytes)
        {
            var result = new BitArray(8);
            var bits = new BitArray(bytes);
            int pos = 0;
            for (int index = 15; index > 7; index--)
                if (bits[index] == true)
                {
                    pos = 15 - index;
                    index = 8;
                }
            result[0] = !bits[0];
            var firstPart = new BitArray(BitConverter.GetBytes(8 - pos));
            for (int index = 1; index < 4; index++)
                result[index] = firstPart[index - 1];
            for (int index = 0; index < 4; index++)
                result[4 + index] = bits[14 - pos - index ];
                return result;
        }

        private static BitArray Invert(BitArray bits)
        {
            for (int index = 1; index < 8; index += 2)
                bits[index] = !bits[index];
            var newBits = new BitArray(8);
            for (int index = 0; index < 8; index++)
                newBits[index] = bits[7 - index];
            return newBits;
        }

        public static byte A_law(byte[] bytes)
        {
            bytes = new byte[2] { bytes[0], bytes[1] };
            var temp = GetCompressedByte(bytes);
            temp = Invert(temp);
            var result = new byte[1];
            temp.CopyTo(result, 0);
            return result[0];
        }
    }
}
