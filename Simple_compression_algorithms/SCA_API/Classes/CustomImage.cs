using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_API.Classes
{
    public class CustomImage
    {
        private string _type;
        private int _width, _height;
        private Bitmap _image;

        public Bitmap Image { get { return _image; } }

        public CustomImage(byte[] bytes)
        {
            ProceedBytes(bytes);
        }

        private void ProceedBytes(byte[] bytes)
        {
            int index = -1;
            _type = Encoding.UTF8.GetString(GetParam(bytes, ref index));
            _width = Convert.ToInt32(Encoding.UTF8
                .GetString(GetParam(bytes, ref index)));
            _height = Convert.ToInt32(Encoding.UTF8
                .GetString(GetParam(bytes, ref index)));
            GetParam(bytes, ref index);
            _image = new Bitmap(_width, _height);
            for (int y = 0; y < _height;y++)
                for (int x=0;x<_width;x++)
                    _image.SetPixel(x, y, GetColor(bytes, ref index));
        }

        private byte[] GetParam(byte[] bytes, ref int index)
        {
            List<byte> selectedBytes = new List<byte>();
            for (; ++index < bytes.Length && bytes[index] != 32 && bytes[index] != 10;)
                selectedBytes.Add(bytes[index]);
            return selectedBytes.ToArray();
        }

        private Color GetColor(byte[] bytes, ref int index)
        {
            List<byte> selectedBytes = new List<byte>();
            for (;selectedBytes.Count != 3 && ++index < bytes.Length;)
                selectedBytes.Add(bytes[index]);
            return Color.FromArgb(selectedBytes[0], selectedBytes[1], selectedBytes[2]);
        }
    }
}
