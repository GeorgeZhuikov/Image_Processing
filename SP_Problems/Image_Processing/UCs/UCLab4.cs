using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP_API.Classes;

namespace Simple_compression_algorithms.UCs
{
    public partial class UCLab4 : UserControl
    {
        public UCLab4()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            Prepare();
        }

        private void Prepare()
        {
            ucOpenFile.FileOpened = FileOpend;
            ucOpenFile.Caption = "Звуковой файл";
            ucOpenFile.Filter = "wav |*.wav";
        }

        private void FileOpend()
        {
            btnProceed.Visible = true;
            pcbOriginal.Image = Lab4.GetDiagram(pcbOriginal.Size, ucOpenFile.WaveData);
        }

        private void UCLab4_Resize(object sender, EventArgs e)
        {
            gpbOriginal.Height = (gpb.Height - gpbFuncs.Height) / 2;
        }
    }
}
