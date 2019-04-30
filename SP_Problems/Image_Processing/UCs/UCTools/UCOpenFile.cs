using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using IP_API.Classes;

namespace Image_Processing.UCs.UCTools
{
    public partial class UCOpenFile : UserControl
    {
        private byte[] _bytes;
        private CustomImage _ci;
        private WaveData _wd;

        public string CiType { get { return _ci.Type; } }
        public byte[] FileBytes { get { return  _bytes;  } }
        public Bitmap Image { get { return _ci.Image; } }
        public Action FileOpened { get; set; }
        public string Filter { set { ofd.Filter = value; } }
        public string Caption { set { gpbFile.Text = value; } }
        public WaveData WaveData { get { return _wd; } }

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
                    var ext = Path.GetExtension(ofd.FileName);
                    if (ext == ".ppm" || ext == ".pgm")
                        _ci = new CustomImage(_bytes);
                    if (ext == ".wav")
                        _wd = Lab4.GetWaveData(ofd.FileName);
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
                if (_ci != null || _wd != null) FileOpened?.Invoke();
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
