using NAudio.Wave;
using System.Drawing;

namespace IP_API.Classes
{
    public static class Lab4
    {
        private static Pen _general = new Pen(Color.FromArgb(63, Color.Blue));

        private static byte[] BeginFourierTransform(WaveData signal)
        {
            byte[] bytes = new byte[signal.Bytes.Length];

            return bytes;
        }

        private static int GetRange(WaveData db, bool half)
        {
            int max = int.MinValue;
            for (int index = 0; index < db.Length; index++)
            {
                int value = db.GetBytesValue(index);
                if (value > max)
                    max = value;
            }
            int coef = 2;
            if (half)
                coef = 1;
            return coef * (max + 1);
        }

        private static void DrawByte(Graphics g, Pen pen,
            int range, int width, int height, int value, bool half)
        {
            int coef = 2;
            if (half) coef = 1;
            float currentRange = (float)coef * value / range;
            int iCurrentRange = (int)(height * currentRange);
            if (half)
                g.DrawLine(_general,
                    new Point(width, height - iCurrentRange),
                    new Point(width, height));
            else
                g.DrawLine(_general,
                    new Point(width, (height - iCurrentRange) / 2),
                    new Point(width, (height + iCurrentRange) / 2));
        }

        public static Bitmap GetDiagram(Size size, WaveData db, bool half = false)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(bmp);
            var range = GetRange(db, half);
            float step = (float)db.Length / size.Width;

            for (int width = 0; width < size.Width; width++)
                DrawByte(g, _general, range, width, bmp.Height,
                    db.GetBytesValue((int)(width * step)), half);
            return bmp;
        }

        public static WaveData GetWaveData(string path)
        {
            WaveData wd = new WaveData();
            var reader = new WaveFileReader(path);
            byte[] bytesBuffer = new byte[reader.Length];
            int read = reader.Read(bytesBuffer, 0, bytesBuffer.Length);
            wd.Bytes = bytesBuffer;
            wd.WaveFormat = reader.WaveFormat;
            return wd;
        }

        public static WaveData FourierTransform(WaveData signal)
        {
            WaveData wd = new WaveData();
            wd.WaveFormat = signal.WaveFormat;

            return wd;
        }
    }
}
