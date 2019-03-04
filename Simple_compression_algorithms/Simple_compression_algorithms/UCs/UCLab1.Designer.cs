namespace Simple_compression_algorithms.UCs
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
            this.lblFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRLE = new System.Windows.Forms.Label();
            this.gpbFile = new System.Windows.Forms.GroupBox();
            this.gpbCoefs = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLZ77 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.gpbFile.SuspendLayout();
            this.gpbCoefs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblFile.Location = new System.Drawing.Point(102, 37);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(92, 25);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "Выбрать";
            this.lblFile.Click += new System.EventHandler(this.lblFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Файл: ";
            // 
            // ofd
            // 
            this.ofd.Filter = "ppm |*.ppm| pgm |*.pgm";
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
            // gpbFile
            // 
            this.gpbFile.Controls.Add(this.label2);
            this.gpbFile.Controls.Add(this.lblFile);
            this.gpbFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbFile.Location = new System.Drawing.Point(0, 0);
            this.gpbFile.Name = "gpbFile";
            this.gpbFile.Size = new System.Drawing.Size(441, 85);
            this.gpbFile.TabIndex = 0;
            this.gpbFile.TabStop = false;
            this.gpbFile.Text = "Изображение";
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
            this.gpbCoefs.Location = new System.Drawing.Point(0, 85);
            this.gpbCoefs.Name = "gpbCoefs";
            this.gpbCoefs.Size = new System.Drawing.Size(441, 215);
            this.gpbCoefs.TabIndex = 0;
            this.gpbCoefs.TabStop = false;
            this.gpbCoefs.Text = "Коэффициенты сжатия";
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
            // lblHsC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHC.Location = new System.Drawing.Point(200, 120);
            this.lblHC.Name = "lblHsC";
            this.lblHC.Size = new System.Drawing.Size(19, 25);
            this.lblHC.TabIndex = 11;
            this.lblHC.Text = "-";
            // 
            // UCLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbCoefs);
            this.Controls.Add(this.gpbFile);
            this.Name = "UCLab1";
            this.Size = new System.Drawing.Size(441, 300);
            this.gpbFile.ResumeLayout(false);
            this.gpbFile.PerformLayout();
            this.gpbCoefs.ResumeLayout(false);
            this.gpbCoefs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRLE;
        private System.Windows.Forms.GroupBox gpbFile;
        private System.Windows.Forms.GroupBox gpbCoefs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLZ77;
    }
}
