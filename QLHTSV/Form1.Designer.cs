﻿namespace QLHTSV
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maychuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguoidungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maychuToolStripMenuItem,
            this.nguoidungToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hethongToolStripMenuItem.Text = "Hethong";
            // 
            // maychuToolStripMenuItem
            // 
            this.maychuToolStripMenuItem.Name = "maychuToolStripMenuItem";
            this.maychuToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.maychuToolStripMenuItem.Text = "Maychu";
            this.maychuToolStripMenuItem.Click += new System.EventHandler(this.maychuToolStripMenuItem_Click);
            // 
            // nguoidungToolStripMenuItem
            // 
            this.nguoidungToolStripMenuItem.Name = "nguoidungToolStripMenuItem";
            this.nguoidungToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.nguoidungToolStripMenuItem.Text = "Nguoidung";
            this.nguoidungToolStripMenuItem.Click += new System.EventHandler(this.nguoidungToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maychuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguoidungToolStripMenuItem;
    }
}

