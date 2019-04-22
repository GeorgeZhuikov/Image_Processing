using System.Drawing;

namespace IP_API.Classes
{
    public static class Lab2
    {
        private static Color GetColor(Bitmap bmp, int x, int y)
        {
            Color color = Color.Black;
            if (0 <= x && x < bmp.Width && 0 <= y && y < bmp.Height)
                color = bmp.GetPixel(x, y);
            return color;
        }

        private static int ProceedSum(double sum, double coreSum)
        {
            sum /= coreSum;
            if (sum > byte.MaxValue) sum = byte.MaxValue;
            if (sum < 0) sum = 0;
            return (int)sum;
        }

        private static Color GetResultColor(Bitmap bmp, int[,] core, int x, int y,
            int coreWidth, int coreHeight, double coef)
        {
            x -= coreWidth / 2;
            y -= coreHeight / 2;
            double r = 0, g = 0, b = 0, c = 0;
            for (int yy = 0; yy < coreHeight; yy++)
                for (int xx = 0; xx < coreWidth; xx++)
                {
                    var color = GetColor(bmp, x + xx, y + yy);
                    double coreValue = core[yy, xx] * coef;
                    r += coreValue * color.R;
                    g += coreValue * color.G;
                    b += coreValue * color.B;
                    c += coreValue;
                }
            if (c <= 0) c = 1;
            r = ProceedSum(r, c);
            g = ProceedSum(g, c);
            b = ProceedSum(b, c);
            return Color.FromArgb((int)r, (int)g, (int)b);
        }

        public static Bitmap Convolution(Bitmap bmp, int[,] core, double coef)
        {
            Bitmap newBmp = new Bitmap(bmp);
            int coreWidth = core.GetLength(0), coreHeight = core.GetLength(1);
            for (int y = 0; y < newBmp.Height; y++)
                for (int x = 0; x < newBmp.Width; x++)
                    newBmp.SetPixel(x, y, GetResultColor(bmp, core, x, y, 
                        coreWidth, coreHeight, coef));
            return newBmp;
        }
    }
}
