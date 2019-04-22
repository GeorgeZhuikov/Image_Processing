using System.Windows.Forms;
using IP_API.Classes;

namespace Image_Processing.UCs
{
    public partial class UCLab1 : UserControl
    {
        private byte[] _bytes;

        public UCLab1()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            ucOpenFile.FileOpened = FileOpened;
        }

        private void FileOpened()
        {
            _bytes = ucOpenFile.FileBytes;
            ProceedResult();
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
