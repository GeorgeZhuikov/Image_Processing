namespace Simple_compression_algorithms.UCs
{
    partial class UCLab3
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
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.gpbFuncs = new System.Windows.Forms.GroupBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.pcbOriginal = new System.Windows.Forms.PictureBox();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.pcbResult = new System.Windows.Forms.PictureBox();
            this.gpbOriginal = new System.Windows.Forms.GroupBox();
            this.gpb = new System.Windows.Forms.GroupBox();
            this.ucOpenFile = new Image_Processing.UCs.UCTools.UCOpenFile();
            this.btnChange = new System.Windows.Forms.Button();
            this.gpbFuncs.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).BeginInit();
            this.gpbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).BeginInit();
            this.gpbOriginal.SuspendLayout();
            this.gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveResult.Location = new System.Drawing.Point(19, 193);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(158, 35);
            this.btnSaveResult.TabIndex = 3;
            this.btnSaveResult.Text = "Сохранить";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Visible = false;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // sfd
            // 
            this.sfd.FileName = "result";
            this.sfd.Filter = "ppm |*.ppm| pgm |*.pgm";
            // 
            // gpbFuncs
            // 
            this.gpbFuncs.Controls.Add(this.btnChange);
            this.gpbFuncs.Controls.Add(this.btnDecode);
            this.gpbFuncs.Controls.Add(this.btnEncode);
            this.gpbFuncs.Controls.Add(this.btnSaveResult);
            this.gpbFuncs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbFuncs.Location = new System.Drawing.Point(0, 0);
            this.gpbFuncs.Name = "gpbFuncs";
            this.gpbFuncs.Size = new System.Drawing.Size(200, 513);
            this.gpbFuncs.TabIndex = 7;
            this.gpbFuncs.TabStop = false;
            this.gpbFuncs.Text = "Функции";
            // 
            // btnDecode
            // 
            this.btnDecode.AutoSize = true;
            this.btnDecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDecode.Location = new System.Drawing.Point(19, 90);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(158, 35);
            this.btnDecode.TabIndex = 1;
            this.btnDecode.Text = "Декодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Visible = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEncode.Location = new System.Drawing.Point(19, 37);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(158, 35);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "Кодировать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Visible = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.gpbFuncs);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl.Location = new System.Drawing.Point(3, 22);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 513);
            this.pnl.TabIndex = 8;
            // 
            // pcbOriginal
            // 
            this.pcbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbOriginal.Location = new System.Drawing.Point(3, 22);
            this.pcbOriginal.Name = "pcbOriginal";
            this.pcbOriginal.Size = new System.Drawing.Size(194, 488);
            this.pcbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOriginal.TabIndex = 0;
            this.pcbOriginal.TabStop = false;
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.pcbResult);
            this.gpbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbResult.Location = new System.Drawing.Point(403, 22);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Size = new System.Drawing.Size(258, 513);
            this.gpbResult.TabIndex = 2;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "Результат преобразования";
            // 
            // pcbResult
            // 
            this.pcbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbResult.Location = new System.Drawing.Point(3, 22);
            this.pcbResult.Name = "pcbResult";
            this.pcbResult.Size = new System.Drawing.Size(252, 488);
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
            this.gpbOriginal.Size = new System.Drawing.Size(200, 513);
            this.gpbOriginal.TabIndex = 1;
            this.gpbOriginal.TabStop = false;
            this.gpbOriginal.Text = "Исходное изображение";
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.gpbResult);
            this.gpb.Controls.Add(this.gpbOriginal);
            this.gpb.Controls.Add(this.pnl);
            this.gpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb.Location = new System.Drawing.Point(0, 92);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(664, 538);
            this.gpb.TabIndex = 2;
            this.gpb.TabStop = false;
            this.gpb.Text = "Преобразование Хаара";
            // 
            // ucOpenFile
            // 
            this.ucOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucOpenFile.FileOpened = null;
            this.ucOpenFile.Location = new System.Drawing.Point(0, 0);
            this.ucOpenFile.Name = "ucOpenFile";
            this.ucOpenFile.Size = new System.Drawing.Size(664, 92);
            this.ucOpenFile.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChange.Location = new System.Drawing.Point(19, 140);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(158, 35);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Заменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // UCLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.ucOpenFile);
            this.Name = "UCLab3";
            this.Size = new System.Drawing.Size(664, 630);
            this.Resize += new System.EventHandler(this.UCLab3_Resize);
            this.gpbFuncs.ResumeLayout(false);
            this.gpbFuncs.PerformLayout();
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).EndInit();
            this.gpbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).EndInit();
            this.gpbOriginal.ResumeLayout(false);
            this.gpb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Image_Processing.UCs.UCTools.UCOpenFile ucOpenFile;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.GroupBox gpbFuncs;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.PictureBox pcbOriginal;
        private System.Windows.Forms.GroupBox gpbResult;
        private System.Windows.Forms.PictureBox pcbResult;
        private System.Windows.Forms.GroupBox gpbOriginal;
        private System.Windows.Forms.GroupBox gpb;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnChange;
    }
}
