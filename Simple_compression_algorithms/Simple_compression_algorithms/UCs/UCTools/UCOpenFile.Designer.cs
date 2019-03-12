namespace Simple_compression_algorithms.UCs.UCTools
{
    partial class UCOpenFile
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
            this.gpbFile = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gpbFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFile
            // 
            this.gpbFile.Controls.Add(this.label2);
            this.gpbFile.Controls.Add(this.lblFile);
            this.gpbFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbFile.Location = new System.Drawing.Point(0, 0);
            this.gpbFile.Name = "gpbFile";
            this.gpbFile.Size = new System.Drawing.Size(150, 92);
            this.gpbFile.TabIndex = 1;
            this.gpbFile.TabStop = false;
            this.gpbFile.Text = "Изображение";
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
            this.lblFile.MouseEnter += new System.EventHandler(this.lblFile_MouseEnter);
            this.lblFile.MouseLeave += new System.EventHandler(this.lblFile_MouseLeave);
            // 
            // ofd
            // 
            this.ofd.Filter = "ppm |*.ppm| pgm |*.pgm";
            // 
            // UCOpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbFile);
            this.Name = "UCOpenFile";
            this.Size = new System.Drawing.Size(150, 92);
            this.gpbFile.ResumeLayout(false);
            this.gpbFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}
