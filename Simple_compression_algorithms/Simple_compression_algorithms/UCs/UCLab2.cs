using IP_API.Classes;
using SCA_API.Classes;
using System;
using System.Windows.Forms;

namespace Simple_compression_algorithms.UCs
{
    public partial class UCLab2 : UserControl
    {
        public UCLab2()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            Prepare();
        }

        private void UCLab2_Resize(object sender, EventArgs e)
        {
            gpbOriginal.Width = Width / 2;
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            SetDGV();
            dgvConvolutions.Focus();
        }

        private void txbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.DigitInputCheck(e);
        }

        private void txbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.DigitInputCheck(e);
        }

        private void txbCoef_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.DigitAndMinusInputCheck(e);
        }
        
        private void btnProceed_Click(object sender, EventArgs e)
        {
            Proceed();
        }        

        private void Prepare()
        {
            SetDGV();
            ucOpenFile.FileOpened = FileOpend;
        }

        private void FileOpend()
        {
            pcbOriginal.Image = ucOpenFile.Image;
            pcbResult.Image = null;
            lblStatus.Text = "";
        }

        private void SetDGV()
        {
            try
            {
                dgvConvolutions.Rows.Clear();
                dgvConvolutions.Columns.Clear();
                dgvConvolutions.ColumnCount = Convert.ToInt32(txbWidth.Text);
                dgvConvolutions.RowCount = Convert.ToInt32(txbHeight.Text);
                foreach (DataGridViewColumn column in dgvConvolutions.Columns)
                    column.Width = dgvConvolutions.RowTemplate.Height;
            }
            catch { }
        }        

        private void Proceed()
        {
            try
            {
                pcbResult.Image = Lab2.Convolution(ucOpenFile.Image,
                  Utils.DgvToIntArray(dgvConvolutions), Convert.ToDouble(txbCoef.Text));
                lblStatus.Text = "Готово";
            }
            catch
            {
                lblStatus.Text = "Ошибка";
            }
        }

    }
}
