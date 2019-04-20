namespace Image_Processing
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucLab11 = new Image_Processing.UCs.UCLab1();
            this.ucLab21 = new Image_Processing.UCs.UCLab2();
            this.ucLab31 = new Image_Processing.UCs.UCLab3();
            this.tbc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tabPage1);
            this.tbc.Controls.Add(this.tabPage2);
            this.tbc.Controls.Add(this.tabPage3);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 0);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(678, 944);
            this.tbc.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ucLab11);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 911);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лабораторная 1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.ucLab21);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 911);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лабораторная 2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ucLab31);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(670, 911);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Лабораторная 3";
            // 
            // ucLab11
            // 
            this.ucLab11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab11.Location = new System.Drawing.Point(3, 3);
            this.ucLab11.Name = "ucLab11";
            this.ucLab11.Size = new System.Drawing.Size(664, 905);
            this.ucLab11.TabIndex = 0;
            // 
            // ucLab21
            // 
            this.ucLab21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab21.Location = new System.Drawing.Point(3, 3);
            this.ucLab21.Name = "ucLab21";
            this.ucLab21.Size = new System.Drawing.Size(664, 905);
            this.ucLab21.TabIndex = 0;
            // 
            // ucLab31
            // 
            this.ucLab31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab31.Location = new System.Drawing.Point(3, 3);
            this.ucLab31.Name = "ucLab31";
            this.ucLab31.Size = new System.Drawing.Size(664, 905);
            this.ucLab31.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 944);
            this.Controls.Add(this.tbc);
            this.Name = "FMain";
            this.Text = "Простые алгоритмы сжатия";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tabPage1;
        private UCs.UCLab1 ucLab11;
        private System.Windows.Forms.TabPage tabPage2;
        private Image_Processing.UCs.UCLab2 ucLab21;
        private System.Windows.Forms.TabPage tabPage3;
        private Image_Processing.UCs.UCLab3 ucLab31;
    }
}

