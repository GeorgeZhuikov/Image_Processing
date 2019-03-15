using IP_API.Classes;
using SCA_API.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Processing.UCs
{
    public partial class UCLab2 : UserControl
    {
        private CustomImage _ciResult;

        public UCLab2()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            Prepare();
        }

        private void UCLab2_Resize(object sender, EventArgs e)
        {
            gpbOriginal.Width = (Width - gpbCore.Width)/ 2;
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            SetDGV();
            dgvConvolutions.Focus();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Proceed();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (_ciResult.Save(sfd.FileName))
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
            Utils.DoubleAndMinusInputCheck(e);
        }

        private void FileOpend()
        {
            pcbOriginal.Image = ucOpenFile.Image;
            ResetForm("");
        }

        private void Prepare()
        {
            SetDGV();
            ucOpenFile.FileOpened = FileOpend;
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
                btnSaveResult.Visible = true;
                _ciResult = new CustomImage(pcbResult.Image as Bitmap, ucOpenFile.CiType);
            }
            catch
            {
                ResetForm("Ошибка");
            }
        }

        private void ResetForm(string text)
        {
            pcbResult.Image = null;
            lblStatus.Text = text;
            btnSaveResult.Visible = false;
        }
    }
}
