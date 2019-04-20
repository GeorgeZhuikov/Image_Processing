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

namespace Image_Processing.UCs.UCTools
{
    public partial class UCOpenFile : UserControl
    {
        private byte[] _bytes;
        private CustomImage _ci;

        public string CiType { get { return _ci.Type; } }
        public byte[] FileBytes { get { return  _bytes;  } }
        public Bitmap Image { get { return _ci.Image; } }
        public Action FileOpened { get; set; }

        public UCOpenFile()
        {
            Dock = DockStyle.Top;
            InitializeComponent();
        }

        private void lblFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    _bytes = File.ReadAllBytes(ofd.FileName);
                    _ci = new CustomImage(_bytes);
                    ofd.FileName = ofd.SafeFileName;
                    lblFile.Text = ofd.SafeFileName;
                }
                catch
                {
                    MessageBox.Show(string.Format("Открыть файл {0} не удалось",
                        ofd.FileName),
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (_ci != null) FileOpened?.Invoke();
            }
        }

        private void lblFile_MouseEnter(object sender, EventArgs e)
        {
            lblFile.ForeColor = Color.Blue;
        }

        private void lblFile_MouseLeave(object sender, EventArgs e)
        {
            lblFile.ForeColor = Color.Black;
        }
    }
}
