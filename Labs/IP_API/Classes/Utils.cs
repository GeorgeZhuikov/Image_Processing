using IP_API.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace IP_API.Classes
{
    public static class Utils
    {
        public static string GetCompressPercentage(byte[] original, byte[] compressed)
        {
            return string.Format("{0:P2}", 1 - (double)compressed.Length / original.Length);
        }

        public static void DigitInputCheck(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public static void DoubleAndMinusInputCheck(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && !(e.KeyChar == '-' || e.KeyChar == ','))
                e.Handled = true;
        }

        public static int[,] DgvToIntArray(DataGridView dgv)
        {
            var array = new int[dgv.RowCount, dgv.ColumnCount];
            for (int i = 0; i < dgv.RowCount; i++)
                for (int j = 0; j < dgv.ColumnCount; j++)
                    array[i, j] = Convert.ToInt32(dgv.Rows[i].Cells[j].Value);
            return array;
        }

        public static void SaveImage(SaveFileDialog sfd, CustomImage ci)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (ci.Save(sfd.FileName))
                    MessageBox.Show(
                        "Файл сохранён.",
                        "Сохранить",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show(
                            string.Format("Не удалось сохранить файл:{0}{1}",
                            Environment.NewLine, sfd.FileName),
                            "Сохранить",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                sfd.FileName = Path.GetFileName(sfd.FileName);
            }

        }

        public static byte ProceedNegativeByte(byte byte1, byte byte2, byte div = 2)
        {
            double result = ((double)byte1 - byte2) / div;
            if (result < 0)
                result += byte.MaxValue;
            return (byte)result;
        }
    }
}
