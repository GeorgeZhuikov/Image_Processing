using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Prepare();
        }

        private void Prepare()
        {
            if (Manager.CheckConnection())
                gpb.Enabled = true;
            else
                gpbTop.Enabled = true;
        }

        private void btnSetConnection_Click(object sender, EventArgs e)
        {
            if (Manager.CreateDataBase(txbServer.Text, txbLogin.Text, txbPassword.Text))
            {
                gpb.Enabled = true;
                gpbTop.Enabled = false;
            }
            else
                lblConnStatus.Text = string.Format("{0} {1}", DateTime.Now.ToLongTimeString(), "Подключение не удалось");
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            if (Manager.ProceedUrl(txbUrl.Text))
                lblStatus.Text = string.Format("{0} {1}", DateTime.Now.ToLongTimeString(), "Ссылка обработана");
            else
                lblStatus.Text = string.Format("{0} {1}", DateTime.Now.ToLongTimeString(), "Ссылка не обработана");
        }
    }
}
