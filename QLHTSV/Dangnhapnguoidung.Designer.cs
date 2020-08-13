namespace QLHTSV
{
    partial class Dangnhapnguoidung
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
            this.btnThoatND = new System.Windows.Forms.Button();
            this.btnDangnhapND = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordND = new System.Windows.Forms.TextBox();
            this.txtUsernameND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoatND
            // 
            this.btnThoatND.Location = new System.Drawing.Point(475, 284);
            this.btnThoatND.Name = "btnThoatND";
            this.btnThoatND.Size = new System.Drawing.Size(93, 40);
            this.btnThoatND.TabIndex = 11;
            this.btnThoatND.Text = "Thoát";
            this.btnThoatND.UseVisualStyleBackColor = true;
            // 
            // btnDangnhapND
            // 
            this.btnDangnhapND.Location = new System.Drawing.Point(342, 284);
            this.btnDangnhapND.Name = "btnDangnhapND";
            this.btnDangnhapND.Size = new System.Drawing.Size(93, 40);
            this.btnDangnhapND.TabIndex = 10;
            this.btnDangnhapND.Text = "Đăng nhập";
            this.btnDangnhapND.UseVisualStyleBackColor = true;
            this.btnDangnhapND.Click += new System.EventHandler(this.btnDangnhapND_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // txtPasswordND
            // 
            this.txtPasswordND.Location = new System.Drawing.Point(342, 213);
            this.txtPasswordND.Name = "txtPasswordND";
            this.txtPasswordND.Size = new System.Drawing.Size(209, 22);
            this.txtPasswordND.TabIndex = 7;
            // 
            // txtUsernameND
            // 
            this.txtUsernameND.Location = new System.Drawing.Point(342, 127);
            this.txtUsernameND.Name = "txtUsernameND";
            this.txtUsernameND.Size = new System.Drawing.Size(209, 22);
            this.txtUsernameND.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username: ";
            // 
            // Dangnhapnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoatND);
            this.Controls.Add(this.btnDangnhapND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordND);
            this.Controls.Add(this.txtUsernameND);
            this.Name = "Dangnhapnguoidung";
            this.Text = "Dangnhapnguoidung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoatND;
        private System.Windows.Forms.Button btnDangnhapND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordND;
        private System.Windows.Forms.TextBox txtUsernameND;
        private System.Windows.Forms.Label label1;
    }
}