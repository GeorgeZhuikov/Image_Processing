using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SCA_API.Classes;

namespace Simple_compression_algorithms.UCs
{
    public partial class UCLab1 : UserControl
    {
        private byte[] _bytes;

        public UCLab1()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void lblFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblFile.Text = ofd.SafeFileName;
                _bytes = File.ReadAllBytes(ofd.FileName);
                ofd.FileName = ofd.SafeFileName;
                ProceedResult();
            }
        }

        private void ProceedResult()
        {
            var rle = Lab1.RLE(_bytes);
            lblRLE.Text = Utils.GetCompressPercentage(_bytes, rle);
            var lz77 = Lab1.LZ77(_bytes);
            //lblLZ77.Text = Utils.GetCompressPercentage(_bytes, lz77);
            var hc = Lab1.HuffmanCode(_bytes);
            //lblHC.Text = Utils.GetCompressPercentage(_bytes, hc);
        }
    }
}
