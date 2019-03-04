namespace Simple_compression_algorithms
{
    partial class FMain
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
            this.tbc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucLab11 = new Simple_compression_algorithms.UCs.UCLab1();
            this.tbc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tabPage1);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 0);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(678, 644);
            this.tbc.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ucLab11);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лабораторная 1";
            // 
            // ucLab11
            // 
            this.ucLab11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab11.Location = new System.Drawing.Point(3, 3);
            this.ucLab11.Name = "ucLab11";
            this.ucLab11.Size = new System.Drawing.Size(664, 605);
            this.ucLab11.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.tbc);
            this.Name = "FMain";
            this.Text = "Простые алгоритмы сжатия";
            this.tbc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tabPage1;
        private UCs.UCLab1 ucLab11;
    }
}

