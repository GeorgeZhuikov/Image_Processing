namespace Simple_compression_algorithms.UCs
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
            this.gpbConvolutionsCore = new System.Windows.Forms.GroupBox();
            this.dgvConvolutions = new System.Windows.Forms.DataGridView();
            this.gpbConvolutions = new System.Windows.Forms.GroupBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txbCoef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlConvolutions = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ucOpenFile = new Simple_compression_algorithms.UCs.UCTools.UCOpenFile();
            this.gpb.SuspendLayout();
            this.gpbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).BeginInit();
            this.gpbOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).BeginInit();
            this.gpbConvolutionsCore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvolutions)).BeginInit();
            this.gpbConvolutions.SuspendLayout();
            this.pnlConvolutions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.gpbResult);
            this.gpb.Controls.Add(this.gpbOriginal);
            this.gpb.Controls.Add(this.gpbConvolutionsCore);
            this.gpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb.Location = new System.Drawing.Point(0, 92);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(629, 505);
            this.gpb.TabIndex = 0;
            this.gpb.TabStop = false;
            this.gpb.Text = "Параметры свёртки";
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.pcbResult);
            this.gpbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbResult.Location = new System.Drawing.Point(203, 369);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Size = new System.Drawing.Size(423, 133);
            this.gpbResult.TabIndex = 2;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "Результат свёртки";
            // 
            // pcbResult
            // 
            this.pcbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbResult.Location = new System.Drawing.Point(3, 22);
            this.pcbResult.Name = "pcbResult";
            this.pcbResult.Size = new System.Drawing.Size(417, 108);
            this.pcbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbResult.TabIndex = 1;
            this.pcbResult.TabStop = false;
            // 
            // gpbOriginal
            // 
            this.gpbOriginal.Controls.Add(this.pcbOriginal);
            this.gpbOriginal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbOriginal.Location = new System.Drawing.Point(3, 369);
            this.gpbOriginal.Name = "gpbOriginal";
            this.gpbOriginal.Size = new System.Drawing.Size(200, 133);
            this.gpbOriginal.TabIndex = 1;
            this.gpbOriginal.TabStop = false;
            this.gpbOriginal.Text = "Исходное изображение";
            // 
            // pcbOriginal
            // 
            this.pcbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbOriginal.Location = new System.Drawing.Point(3, 22);
            this.pcbOriginal.Name = "pcbOriginal";
            this.pcbOriginal.Size = new System.Drawing.Size(194, 108);
            this.pcbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOriginal.TabIndex = 0;
            this.pcbOriginal.TabStop = false;
            // 
            // gpbConvolutionsCore
            // 
            this.gpbConvolutionsCore.Controls.Add(this.dgvConvolutions);
            this.gpbConvolutionsCore.Controls.Add(this.gpbConvolutions);
            this.gpbConvolutionsCore.Controls.Add(this.pnlConvolutions);
            this.gpbConvolutionsCore.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbConvolutionsCore.Location = new System.Drawing.Point(3, 22);
            this.gpbConvolutionsCore.Name = "gpbConvolutionsCore";
            this.gpbConvolutionsCore.Size = new System.Drawing.Size(623, 347);
            this.gpbConvolutionsCore.TabIndex = 0;
            this.gpbConvolutionsCore.TabStop = false;
            this.gpbConvolutionsCore.Text = "Ядро";
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
            this.dgvConvolutions.Location = new System.Drawing.Point(3, 76);
            this.dgvConvolutions.Name = "dgvConvolutions";
            this.dgvConvolutions.RowHeadersVisible = false;
            this.dgvConvolutions.RowHeadersWidth = 18;
            this.dgvConvolutions.RowTemplate.Height = 24;
            this.dgvConvolutions.Size = new System.Drawing.Size(617, 193);
            this.dgvConvolutions.TabIndex = 4;
            // 
            // gpbConvolutions
            // 
            this.gpbConvolutions.Controls.Add(this.lblStatus);
            this.gpbConvolutions.Controls.Add(this.btnProceed);
            this.gpbConvolutions.Controls.Add(this.txbCoef);
            this.gpbConvolutions.Controls.Add(this.label3);
            this.gpbConvolutions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbConvolutions.Location = new System.Drawing.Point(3, 269);
            this.gpbConvolutions.Name = "gpbConvolutions";
            this.gpbConvolutions.Size = new System.Drawing.Size(617, 75);
            this.gpbConvolutions.TabIndex = 5;
            this.gpbConvolutions.TabStop = false;
            this.gpbConvolutions.Text = "Свёртка";
            // 
            // btnProceed
            // 
            this.btnProceed.AutoSize = true;
            this.btnProceed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProceed.Location = new System.Drawing.Point(310, 20);
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
            this.txbCoef.Location = new System.Drawing.Point(192, 23);
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
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Коэффициент:  ";
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
            this.pnlConvolutions.Size = new System.Drawing.Size(617, 54);
            this.pnlConvolutions.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn.Location = new System.Drawing.Point(459, 2);
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
            this.txbHeight.Location = new System.Drawing.Point(341, 5);
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
            this.label1.Location = new System.Drawing.Point(242, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Высота: ";
            // 
            // txbWidth
            // 
            this.txbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbWidth.Location = new System.Drawing.Point(117, 5);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(464, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 9;
            // 
            // ucOpenFile
            // 
            this.ucOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucOpenFile.FileOpened = null;
            this.ucOpenFile.Location = new System.Drawing.Point(0, 0);
            this.ucOpenFile.Name = "ucOpenFile";
            this.ucOpenFile.Size = new System.Drawing.Size(629, 92);
            this.ucOpenFile.TabIndex = 0;
            // 
            // UCLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.ucOpenFile);
            this.Name = "UCLab2";
            this.Size = new System.Drawing.Size(629, 597);
            this.Resize += new System.EventHandler(this.UCLab2_Resize);
            this.gpb.ResumeLayout(false);
            this.gpbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).EndInit();
            this.gpbOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).EndInit();
            this.gpbConvolutionsCore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvolutions)).EndInit();
            this.gpbConvolutions.ResumeLayout(false);
            this.gpbConvolutions.PerformLayout();
            this.pnlConvolutions.ResumeLayout(false);
            this.pnlConvolutions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb;
        private UCTools.UCOpenFile ucOpenFile;
        private System.Windows.Forms.GroupBox gpbConvolutionsCore;
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
        private System.Windows.Forms.GroupBox gpbConvolutions;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txbCoef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
    }
}
