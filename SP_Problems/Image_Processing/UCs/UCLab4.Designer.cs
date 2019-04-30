namespace Simple_compression_algorithms.UCs
{
    partial class UCLab4
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
            this.pcbOriginal = new System.Windows.Forms.PictureBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.pcbResult = new System.Windows.Forms.PictureBox();
            this.gpbOriginal = new System.Windows.Forms.GroupBox();
            this.gpb = new System.Windows.Forms.GroupBox();
            this.gpbFuncs = new System.Windows.Forms.GroupBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.ucOpenFile = new Image_Processing.UCs.UCTools.UCOpenFile();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).BeginInit();
            this.gpbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).BeginInit();
            this.gpbOriginal.SuspendLayout();
            this.gpb.SuspendLayout();
            this.gpbFuncs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbOriginal
            // 
            this.pcbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbOriginal.Location = new System.Drawing.Point(3, 22);
            this.pcbOriginal.Name = "pcbOriginal";
            this.pcbOriginal.Size = new System.Drawing.Size(632, 175);
            this.pcbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOriginal.TabIndex = 0;
            this.pcbOriginal.TabStop = false;
            // 
            // sfd
            // 
            this.sfd.FileName = "result";
            this.sfd.Filter = "ppm |*.ppm| pgm |*.pgm";
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.pcbResult);
            this.gpbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbResult.Location = new System.Drawing.Point(3, 324);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Size = new System.Drawing.Size(638, 118);
            this.gpbResult.TabIndex = 2;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "Результат преобразования";
            // 
            // pcbResult
            // 
            this.pcbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbResult.Location = new System.Drawing.Point(3, 22);
            this.pcbResult.Name = "pcbResult";
            this.pcbResult.Size = new System.Drawing.Size(632, 93);
            this.pcbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbResult.TabIndex = 1;
            this.pcbResult.TabStop = false;
            // 
            // gpbOriginal
            // 
            this.gpbOriginal.Controls.Add(this.pcbOriginal);
            this.gpbOriginal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbOriginal.Location = new System.Drawing.Point(3, 124);
            this.gpbOriginal.Name = "gpbOriginal";
            this.gpbOriginal.Size = new System.Drawing.Size(638, 200);
            this.gpbOriginal.TabIndex = 1;
            this.gpbOriginal.TabStop = false;
            this.gpbOriginal.Text = "Исходный сигнал";
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.gpbResult);
            this.gpb.Controls.Add(this.gpbOriginal);
            this.gpb.Controls.Add(this.gpbFuncs);
            this.gpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb.Location = new System.Drawing.Point(0, 92);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(644, 445);
            this.gpb.TabIndex = 4;
            this.gpb.TabStop = false;
            this.gpb.Text = "Дискретное преобразование Фурье";
            // 
            // gpbFuncs
            // 
            this.gpbFuncs.Controls.Add(this.btnProceed);
            this.gpbFuncs.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbFuncs.Location = new System.Drawing.Point(3, 22);
            this.gpbFuncs.Name = "gpbFuncs";
            this.gpbFuncs.Size = new System.Drawing.Size(638, 102);
            this.gpbFuncs.TabIndex = 8;
            this.gpbFuncs.TabStop = false;
            this.gpbFuncs.Text = "Функции";
            // 
            // btnProceed
            // 
            this.btnProceed.AutoSize = true;
            this.btnProceed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProceed.Location = new System.Drawing.Point(19, 37);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(165, 35);
            this.btnProceed.TabIndex = 0;
            this.btnProceed.Text = "Преобразовать";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Visible = false;
            // 
            // ucOpenFile
            // 
            this.ucOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucOpenFile.FileOpened = null;
            this.ucOpenFile.Location = new System.Drawing.Point(0, 0);
            this.ucOpenFile.Name = "ucOpenFile";
            this.ucOpenFile.Size = new System.Drawing.Size(644, 92);
            this.ucOpenFile.TabIndex = 3;
            // 
            // UCLab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.ucOpenFile);
            this.Name = "UCLab4";
            this.Size = new System.Drawing.Size(644, 537);
            this.Resize += new System.EventHandler(this.UCLab4_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).EndInit();
            this.gpbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResult)).EndInit();
            this.gpbOriginal.ResumeLayout(false);
            this.gpb.ResumeLayout(false);
            this.gpbFuncs.ResumeLayout(false);
            this.gpbFuncs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbOriginal;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.GroupBox gpbResult;
        private System.Windows.Forms.PictureBox pcbResult;
        private System.Windows.Forms.GroupBox gpbOriginal;
        private System.Windows.Forms.GroupBox gpb;
        private Image_Processing.UCs.UCTools.UCOpenFile ucOpenFile;
        private System.Windows.Forms.GroupBox gpbFuncs;
        private System.Windows.Forms.Button btnProceed;
    }
}
