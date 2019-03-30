using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCA_API.Classes;
using IP_API.Classes;

namespace Simple_compression_algorithms.UCs
{
    public partial class UCLab3 : UserControl
    {
        public UCLab3()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            Prepare();
        }

        private void UCLab3_Resize(object sender, EventArgs e)
        {
            gpbOriginal.Width = (Width - gpbFuncs.Width) / 2;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            Utils.SaveImage(sfd, new CustomImage(pcbResult.Image as Bitmap));
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            pcbResult.Image = Lab3.Encode(pcbOriginal.Image as Bitmap);
            btnChange.Visible = true;
            btnSaveResult.Visible = true;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            pcbResult.Image = Lab3.Decode(pcbOriginal.Image as Bitmap);
            btnChange.Visible = true;
            btnSaveResult.Visible = true;
        }

        private void FileOpend()
        {
            pcbOriginal.Image = ucOpenFile.Image;
            btnChange.Visible = false;
            btnSaveResult.Visible = false;
            pcbResult.Image = null;
            btnEncode.Visible = true;
            btnDecode.Visible = true;
        }

        private void Prepare()
        {
            ucOpenFile.FileOpened = FileOpend;
            btnEncode.Size = btnDecode.Size;
            btnChange.Size = btnDecode.Size;
            btnSaveResult.Size = btnDecode.Size;
        }

        private void Change()
        {
            pcbOriginal.Image = pcbResult.Image;
            pcbResult.Image = null;
            btnChange.Visible = false;
            btnSaveResult.Visible = false;
        }
    }
}
