namespace SE_Manager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb = new System.Windows.Forms.GroupBox();
            this.gpbTop = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.gpb.SuspendLayout();
            this.gpbTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetConnection
            // 
            this.btnSetConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetConnection.Location = new System.Drawing.Point(68, 74);
            this.btnSetConnection.Name = "btnSetConnection";
            this.btnSetConnection.Size = new System.Drawing.Size(100, 23);
            this.btnSetConnection.TabIndex = 4;
            this.btnSetConnection.Text = "Подключение";
            this.btnSetConnection.UseVisualStyleBackColor = true;
            this.btnSetConnection.Click += new System.EventHandler(this.btnSetConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сервер: ";
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(68, 22);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(100, 20);
            this.txbServer.TabIndex = 1;
            this.txbServer.Text = "localhost";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(68, 48);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(100, 20);
            this.txbLogin.TabIndex = 2;
            this.txbLogin.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин: ";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(240, 48);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль: ";
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.lblStatus);
            this.gpb.Controls.Add(this.btnAddUrl);
            this.gpb.Controls.Add(this.label4);
            this.gpb.Controls.Add(this.txbUrl);
            this.gpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb.Enabled = false;
            this.gpb.Location = new System.Drawing.Point(0, 111);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(381, 85);
            this.gpb.TabIndex = 5;
            this.gpb.TabStop = false;
            this.gpb.Text = "Управление контентом";
            // 
            // gpbTop
            // 
            this.gpbTop.Controls.Add(this.lblConnStatus);
            this.gpbTop.Controls.Add(this.txbPassword);
            this.gpbTop.Controls.Add(this.label1);
            this.gpbTop.Controls.Add(this.label3);
            this.gpbTop.Controls.Add(this.btnSetConnection);
            this.gpbTop.Controls.Add(this.txbLogin);
            this.gpbTop.Controls.Add(this.txbServer);
            this.gpbTop.Controls.Add(this.label2);
            this.gpbTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbTop.Enabled = false;
            this.gpbTop.Location = new System.Drawing.Point(0, 0);
            this.gpbTop.Name = "gpbTop";
            this.gpbTop.Size = new System.Drawing.Size(381, 111);
            this.gpbTop.TabIndex = 0;
            this.gpbTop.TabStop = false;
            this.gpbTop.Text = "Настройка подключения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ссылка: ";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(70, 22);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(270, 20);
            this.txbUrl.TabIndex = 6;
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUrl.Location = new System.Drawing.Point(68, 48);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(100, 23);
            this.btnAddUrl.TabIndex = 7;
            this.btnAddUrl.Text = "Принять";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(174, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 8;
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(174, 79);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(0, 13);
            this.lblConnStatus.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 196);
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.gpbTop);
            this.Name = "Main";
            this.Text = "SE Менеджер ресурсов";
            this.gpb.ResumeLayout(false);
            this.gpb.PerformLayout();
            this.gpbTop.ResumeLayout(false);
            this.gpbTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetConnection;
        private System.Windows.Forms.GroupBox gpb;
        private System.Windows.Forms.GroupBox gpbTop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label lblConnStatus;
    }
}

