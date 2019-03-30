using IP_API.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_API.Classes
{
    public static class Lab3
    {
        private static Color GetH(Color pixel1, Color pixel2)
        {
            return Color.FromArgb(
                (pixel1.R + pixel2.R) / 2,
                (pixel1.G + pixel2.G) / 2,
                (pixel1.B + pixel2.B) / 2);
        }

        private static Color GetL(Color pixel1, Color pixel2)
        {
            return Color.FromArgb(
                Utils.ProceedNegativeByte(pixel1.R, pixel2.R),
                Utils.ProceedNegativeByte(pixel1.G, pixel2.G),
                Utils.ProceedNegativeByte(pixel1.B, pixel2.B));
        }

        private static Color GetHR(Color pixel1, Color pixel2)
        {
            return Color.FromArgb(
                (pixel1.R + pixel2.R) % byte.MaxValue,
                (pixel1.G + pixel2.G) % byte.MaxValue,
                (pixel1.B + pixel2.B) % byte.MaxValue);
        }

        private static Color GetLR(Color pixel1, Color pixel2)
        {
            return Color.FromArgb(
                Utils.ProceedNegativeByte(pixel1.R, pixel2.R, 1),
                Utils.ProceedNegativeByte(pixel1.G, pixel2.G, 1),
                Utils.ProceedNegativeByte(pixel1.B, pixel2.B, 1));
        }

        private static void EncodeHalf(ref Bitmap bmp, Bitmap image, bool direction = false)
        {
            int width = image.Width / 2, height = image.Height / 2;
            if (!direction)
                for (int y = 0; y < image.Height; y++)
                    for (int x = 0; x < width; x++)
                    {
                        int xImage = x * 2, xImageNext = xImage + 1;
                        var pixelH = GetH(image.GetPixel(xImage, y),
                            image.GetPixel(xImageNext, y));
                        var pixelL = GetL(image.GetPixel(xImage, y),
                            image.GetPixel(xImageNext, y));
                        bmp.SetPixel(x, y, pixelH);
                        bmp.SetPixel(width + x, y, pixelL);
                    }
            else
                for (int x = 0; x < image.Width; x++)
                    for (int y = 0; y < height; y++)
                    {
                        int yImage = y * 2, yImageNext = yImage + 1;
                        var pixelH = GetH(image.GetPixel(x, yImage),
                            image.GetPixel(x, yImageNext));
                        var pixelL = GetL(image.GetPixel(x, yImage),
                            image.GetPixel(x, yImageNext));
                        bmp.SetPixel(x, y, pixelH);
                        bmp.SetPixel(x, height + y, pixelL);
                    }
        }

        private static void DecodeHalf(ref Bitmap bmp, Bitmap image, bool direction = false)
        {
            int width = image.Width / 2, height = image.Height / 2;
            if (!direction)
                for (int y = 0; y < image.Height; y++)
                    for (int x = 0; x < width; x++)
                    {
                        int xImage = x * 2, xImageNext = xImage + 1;
                        var pixelH = GetHR(image.GetPixel(x, y),
                            image.GetPixel(x + width, y));
                        var pixelL = GetLR(image.GetPixel(x, y),
                            image.GetPixel(x + width, y));
                        bmp.SetPixel(xImage, y, pixelH);
                        bmp.SetPixel(xImageNext, y, pixelL);
                    }
            else
                for (int x = 0; x < image.Width; x++)
                    for (int y = 0; y < height; y++)
                    {
                        int yImage = y * 2, yImageNext = yImage + 1;
                        var pixelH = GetHR(image.GetPixel(x, y),
                            image.GetPixel(x, y + height));
                        var pixelL = GetLR(image.GetPixel(x, y),
                            image.GetPixel(x, y + height));
                        bmp.SetPixel(x, yImage, pixelH);
                        bmp.SetPixel(x, yImageNext, pixelL);
                    }
        }

        public static Bitmap Encode(Bitmap image)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            EncodeHalf(ref bmp, image);
            image = bmp;
            bmp = new Bitmap(image.Width, image.Height);
            EncodeHalf(ref bmp, image, true);
            return bmp;
        }

        public static Bitmap Decode(Bitmap image)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            DecodeHalf(ref bmp, image, true);
            image = bmp;
            bmp = new Bitmap(image.Width, image.Height);
            DecodeHalf(ref bmp, image);
            return bmp;
        }
    }
}
