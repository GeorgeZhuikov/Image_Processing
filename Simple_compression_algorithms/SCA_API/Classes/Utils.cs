using System;
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
        
    }
}
