using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_API.Classes
{
    public class WaveData
    {
        public byte[] Bytes { get; set; }
        public WaveFormat WaveFormat { get; set; }
        public int BytesPerSample { get { return WaveFormat.BitsPerSample / 8; } }
        public int Length { get { return Bytes.Length / (WaveFormat.BitsPerSample / 8); } }
        public string FileName { get; set; }

        public int GetBytesValue(int index)
        {
            int value = 0;
            for (int i = 0; i < BytesPerSample; i++)
                value += Bytes[index + i];
            return value;
        }
    }
}
