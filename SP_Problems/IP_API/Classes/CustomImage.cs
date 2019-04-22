using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_API.Classes
{
    public class CustomImage
    {
        private string _type;
        private int _width, _height;
        private byte[] _bytes;
        private Bitmap _image;

        public Bitmap Image { get { return _image; } }
        public string Type { get { return _type; } }

        public CustomImage(byte[] bytes)
        {
            _bytes = bytes;
            ProceedBytes();
        }

        public CustomImage(Bitmap image, string type)
        {
            _type = type;
            _image = image;
            _width = _image.Width;
            _height = _image.Height;
            ProceedBitmap();
        }

        public CustomImage(Image image)
        {
            _type = SaveFormats.GetDefaultType();
            _image = image as Bitmap;
            _width = _image.Width;
            _height = _image.Height;
            ProceedBitmap();
        }

        private void ProceedBytes()
        {
            int index = -1;
            _type = Encoding.UTF8.GetString(GetParam(ref index));
            _width = Convert.ToInt32(Encoding.UTF8.GetString(GetParam(ref index)));
            _height = Convert.ToInt32(Encoding.UTF8.GetString(GetParam(ref index)));
            GetParam(ref index);
            ConvertBytesToBitmap(ref index);
        }

        private byte[] GetParam(ref int index)
        {
            List<byte> selectedBytes = new List<byte>();
            if (index + 1 < _bytes.Length && _bytes[index + 1] == 35)
                for (; ++index < _bytes.Length && _bytes[index] != 10;) { }
            for (; ++index < _bytes.Length && _bytes[index] != 32 && _bytes[index] != 10;)
                selectedBytes.Add(_bytes[index]);
            return selectedBytes.ToArray();
        }

        private Color GetColor(ref int index)
        {
            List<byte> selectedBytes = new List<byte>();
            for (; selectedBytes.Count != 3 && ++index < _bytes.Length;)
                selectedBytes.Add(_bytes[index]);
            return Color.FromArgb(selectedBytes[0], selectedBytes[1], selectedBytes[2]);
        }

        private void ProceedBitmap()
        {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(Encoding.UTF8.GetBytes(_type));
            bytes.Add(10);
            bytes.AddRange(Encoding.UTF8.GetBytes(_width.ToString()));
            bytes.Add(32);
            bytes.AddRange(Encoding.UTF8.GetBytes(_height.ToString()));
            var imageBytes = ConvertBitmapToBytes();
            bytes.Add(10);
            bytes.AddRange(Encoding.UTF8.GetBytes(GetMaxValue(imageBytes).ToString()));
            bytes.Add(10);
            bytes.AddRange(imageBytes);
            _bytes = bytes.ToArray();
        }

        private void ConvertBytesToBitmap(ref int index)
        {
            _image = new Bitmap(_width, _height);
            for (int y = 0; y < _height; y++)
                for (int x = 0; x < _width; x++)
                    _image.SetPixel(x, y, GetColor(ref index));
        }

        private byte[] ConvertBitmapToBytes()
        {
            List<byte> bytes = new List<byte>();
            for (int y = 0; y < _image.Height; y++)
                for (int x = 0; x < _image.Width; x++)
                {
                    var color = _image.GetPixel(x, y);
                    bytes.Add(color.R);
                    bytes.Add(color.G);
                    bytes.Add(color.B);
                }
            return bytes.ToArray();
        }

        private byte GetMaxValue(byte[] bytes)
        {
            byte max = byte.MinValue;
            for (int index = 0; index < bytes.Length; index++)
            {
                var currentByte = bytes[index];
                if (max < currentByte) max = currentByte;
            }
            return max;
        }

        private byte[] GetBytesToSave(string type)
        {
            List<byte> bytes = _bytes.ToList();
            bytes.RemoveRange(0, 2);
            bytes.InsertRange(0, Encoding.UTF8.GetBytes(type));
            return bytes.ToArray();
        }

        public bool Save(string fileName)
        {
            bool done = false;
            try
            {
                var tf = SaveFormats.GetCITF(fileName);
                File.WriteAllBytes(fileName, GetBytesToSave(tf.Type));
                done = true;
            }
            catch { }
            return done;
        }
    }
}
