namespace Image_Processing.UCs
{
    partial class UCLab2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb = new System.Windows.Forms.GroupBox();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.pcbResult = new System.Windows.Forms.PictureBox();
            this.gpbOriginal = new System.Windows.Forms.GroupBox();
            this.pcbOriginal = new System.Windows.Forms.PictureBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.gpbConvolutions = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txbCoef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbCore = new System.Windows.Forms.GroupBox();
            this.dgvConvolutions = new System.Windows.Forms.DataGridView();
            this.pnlConvolutions = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ucOpenFile = new Image_Processing.UCs.UCTools.UCOpenFile();
            this.gpb.SuspendLayout();
            this.gpbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).BeginInit();
            this.gpbOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).BeginInit();
            this.pnl.SuspendLayout();
            this.gpbConvolutions.SuspendLayout();
            this.gpbCore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvolutions)).BeginInit();
            this.pnlConvolutions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.gpbResult);
            this.gpb.Controls.Add(this.gpbOriginal);
            this.gpb.Controls.Add(this.pnl);
            this.gpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb.Location = new System.Drawing.Point(0, 92);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(718, 800);
            this.gpb.TabIndex = 0;
            this.gpb.TabStop = false;
            this.gpb.Text = "Параметры свёртки";
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.pcbResult);
            this.gpbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbResult.Location = new System.Drawing.Point(403, 22);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Size = new System.Drawing.Size(312, 775);
            this.gpbResult.TabIndex = 2;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "Результат свёртки";
            // 
            // pcbResult
            // 
            this.pcbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbResult.Location = new System.Drawing.Point(3, 22);
            this.pcbResult.Name = "pcbResult";
            this.pcbResult.Size = new System.Drawing.Size(306, 750);
            this.pcbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbResult.TabIndex = 1;
            this.pcbResult.TabStop = false;
            // 
            // gpbOriginal
            // 
            this.gpbOriginal.Controls.Add(this.pcbOriginal);
            this.gpbOriginal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbOriginal.Location = new System.Drawing.Point(203, 22);
            this.gpbOriginal.Name = "gpbOriginal";
            this.gpbOriginal.Size = new System.Drawing.Size(200, 775);
            this.gpbOriginal.TabIndex = 1;
            this.gpbOriginal.TabStop = false;
            this.gpbOriginal.Text = "Исходное изображение";
            // 
            // pcbOriginal
            // 
            this.pcbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbOriginal.Location = new System.Drawing.Point(3, 22);
            this.pcbOriginal.Name = "pcbOriginal";
            this.pcbOriginal.Size = new System.Drawing.Size(194, 750);
            this.pcbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOriginal.TabIndex = 0;
            this.pcbOriginal.TabStop = false;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.gpbConvolutions);
            this.pnl.Controls.Add(this.gpbCore);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl.Location = new System.Drawing.Point(3, 22);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 775);
            this.pnl.TabIndex = 8;
            // 
            // gpbConvolutions
            // 
            this.gpbConvolutions.Controls.Add(this.btnSaveResult);
            this.gpbConvolutions.Controls.Add(this.lblStatus);
            this.gpbConvolutions.Controls.Add(this.btnProceed);
            this.gpbConvolutions.Controls.Add(this.txbCoef);
            this.gpbConvolutions.Controls.Add(this.label3);
            this.gpbConvolutions.Controls.Add(this.label4);
            this.gpbConvolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbConvolutions.Location = new System.Drawing.Point(0, 422);
            this.gpbConvolutions.Name = "gpbConvolutions";
            this.gpbConvolutions.Size = new System.Drawing.Size(200, 353);
            this.gpbConvolutions.TabIndex = 7;
            this.gpbConvolutions.TabStop = false;
            this.gpbConvolutions.Text = "Свёртка";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.AutoSize = true;
            this.btnSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveResult.Location = new System.Drawing.Point(26, 190);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(121, 35);
            this.btnSaveResult.TabIndex = 8;
            this.btnSaveResult.Text = "Сохранить";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Visible = false;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(18, 153);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 25);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Статус";
            // 
            // btnProceed
            // 
            this.btnProceed.AutoSize = true;
            this.btnProceed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProceed.Location = new System.Drawing.Point(23, 104);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(135, 35);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Обработать";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txbCoef
            // 
            this.txbCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbCoef.Location = new System.Drawing.Point(58, 60);
            this.txbCoef.Name = "txbCoef";
            this.txbCoef.Size = new System.Drawing.Size(100, 30);
            this.txbCoef.TabIndex = 6;
            this.txbCoef.Text = "1";
            this.txbCoef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCoef_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Коэффициент:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "1 / ";
            // 
            // gpbCore
            // 
            this.gpbCore.Controls.Add(this.dgvConvolutions);
            this.gpbCore.Controls.Add(this.pnlConvolutions);
            this.gpbCore.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbCore.Location = new System.Drawing.Point(0, 0);
            this.gpbCore.Name = "gpbCore";
            this.gpbCore.Size = new System.Drawing.Size(200, 422);
            this.gpbCore.TabIndex = 0;
            this.gpbCore.TabStop = false;
            this.gpbCore.Text = "Ядро";
            // 
            // dgvConvolutions
            // 
            this.dgvConvolutions.AllowUserToAddRows = false;
            this.dgvConvolutions.AllowUserToDeleteRows = false;
            this.dgvConvolutions.AllowUserToResizeColumns = false;
            this.dgvConvolutions.AllowUserToResizeRows = false;
            this.dgvConvolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvolutions.ColumnHeadersVisible = false;
            this.dgvConvolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConvolutions.Location = new System.Drawing.Point(3, 228);
            this.dgvConvolutions.Name = "dgvConvolutions";
            this.dgvConvolutions.RowHeadersVisible = false;
            this.dgvConvolutions.RowHeadersWidth = 18;
            this.dgvConvolutions.RowTemplate.Height = 24;
            this.dgvConvolutions.Size = new System.Drawing.Size(194, 191);
            this.dgvConvolutions.TabIndex = 4;
            // 
            // pnlConvolutions
            // 
            this.pnlConvolutions.Controls.Add(this.btn);
            this.pnlConvolutions.Controls.Add(this.txbHeight);
            this.pnlConvolutions.Controls.Add(this.label1);
            this.pnlConvolutions.Controls.Add(this.txbWidth);
            this.pnlConvolutions.Controls.Add(this.label2);
            this.pnlConvolutions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConvolutions.Location = new System.Drawing.Point(3, 22);
            this.pnlConvolutions.Name = "pnlConvolutions";
            this.pnlConvolutions.Size = new System.Drawing.Size(194, 206);
            this.pnlConvolutions.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn.Location = new System.Drawing.Point(23, 158);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(102, 35);
            this.btn.TabIndex = 3;
            this.btn.Text = "Принять";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txbHeight
            // 
            this.txbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbHeight.Location = new System.Drawing.Point(23, 109);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(100, 30);
            this.txbHeight.TabIndex = 2;
            this.txbHeight.Text = "3";
            this.txbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Высота: ";
            // 
            // txbWidth
            // 
            this.txbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbWidth.Location = new System.Drawing.Point(23, 36);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(100, 30);
            this.txbWidth.TabIndex = 1;
            this.txbWidth.Text = "3";
            this.txbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWidth_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина: ";
            // 
            // sfd
            // 
            this.sfd.FileName = "result";
            this.sfd.Filter = "ppm |*.ppm| pgm |*.pgm";
            // 
            // ucOpenFile
            // 
            this.ucOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucOpenFile.FileOpened = null;
            this.ucOpenFile.Location = new System.Drawing.Point(0, 0);
            this.ucOpenFile.Name = "ucOpenFile";
            this.ucOpenFile.Size = new System.Drawing.Size(718, 92);
            this.ucOpenFile.TabIndex = 0;
            // 
            // UCLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.ucOpenFile);
            this.Name = "UCLab2";
            this.Size = new System.Drawing.Size(718, 892);
            this.Resize += new System.EventHandler(this.UCLab2_Resize);
            this.gpb.ResumeLayout(false);
            this.gpbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).EndInit();
            this.gpbOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).EndInit();
            this.pnl.ResumeLayout(false);
            this.gpbConvolutions.ResumeLayout(false);
            this.gpbConvolutions.PerformLayout();
            this.gpbCore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvolutions)).EndInit();
            this.pnlConvolutions.ResumeLayout(false);
            this.pnlConvolutions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb;
        private UCTools.UCOpenFile ucOpenFile;
        private System.Windows.Forms.GroupBox gpbCore;
        private System.Windows.Forms.DataGridView dgvConvolutions;
        private System.Windows.Forms.Panel pnlConvolutions;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbResult;
        private System.Windows.Forms.GroupBox gpbOriginal;
        private System.Windows.Forms.PictureBox pcbResult;
        private System.Windows.Forms.PictureBox pcbOriginal;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox gpbConvolutions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txbCoef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}
