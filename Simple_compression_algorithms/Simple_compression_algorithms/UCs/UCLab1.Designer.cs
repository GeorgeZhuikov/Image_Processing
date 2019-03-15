namespace Image_Processing.UCs
{
    partial class UCLab1
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblRLE = new System.Windows.Forms.Label();
            this.gpbCoefs = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLZ77 = new System.Windows.Forms.Label();
            this.ucOpenFile = new Image_Processing.UCs.UCTools.UCOpenFile();
            this.gpbCoefs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "RLE: ";
            // 
            // lblRLE
            // 
            this.lblRLE.AutoSize = true;
            this.lblRLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRLE.Location = new System.Drawing.Point(200, 42);
            this.lblRLE.Name = "lblRLE";
            this.lblRLE.Size = new System.Drawing.Size(19, 25);
            this.lblRLE.TabIndex = 7;
            this.lblRLE.Text = "-";
            // 
            // gpbCoefs
            // 
            this.gpbCoefs.Controls.Add(this.label5);
            this.gpbCoefs.Controls.Add(this.lblHC);
            this.gpbCoefs.Controls.Add(this.label1);
            this.gpbCoefs.Controls.Add(this.lblLZ77);
            this.gpbCoefs.Controls.Add(this.label3);
            this.gpbCoefs.Controls.Add(this.lblRLE);
            this.gpbCoefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbCoefs.Location = new System.Drawing.Point(0, 88);
            this.gpbCoefs.Name = "gpbCoefs";
            this.gpbCoefs.Size = new System.Drawing.Size(441, 212);
            this.gpbCoefs.TabIndex = 1;
            this.gpbCoefs.TabStop = false;
            this.gpbCoefs.Text = "Коэффициенты сжатия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(21, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Код Хаффмана: ";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHC.Location = new System.Drawing.Point(200, 120);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(19, 25);
            this.lblHC.TabIndex = 11;
            this.lblHC.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "LZ77: ";
            // 
            // lblLZ77
            // 
            this.lblLZ77.AutoSize = true;
            this.lblLZ77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLZ77.Location = new System.Drawing.Point(200, 81);
            this.lblLZ77.Name = "lblLZ77";
            this.lblLZ77.Size = new System.Drawing.Size(19, 25);
            this.lblLZ77.TabIndex = 9;
            this.lblLZ77.Text = "-";
            // 
            // ucOpenFile1
            // 
            this.ucOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucOpenFile.FileOpened = null;
            this.ucOpenFile.Location = new System.Drawing.Point(0, 0);
            this.ucOpenFile.Name = "ucOpenFile1";
            this.ucOpenFile.Size = new System.Drawing.Size(441, 88);
            this.ucOpenFile.TabIndex = 0;
            // 
            // UCLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbCoefs);
            this.Controls.Add(this.ucOpenFile);
            this.Name = "UCLab1";
            this.Size = new System.Drawing.Size(441, 300);
            this.gpbCoefs.ResumeLayout(false);
            this.gpbCoefs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRLE;
        private System.Windows.Forms.GroupBox gpbCoefs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLZ77;
        private Image_Processing.UCs.UCTools.UCOpenFile ucOpenFile;
    }
}
