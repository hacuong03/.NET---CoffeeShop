using System.ComponentModel;

namespace BTL_CoffeeShop
{
    partial class UIDangKiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regis_buttondangnhap = new System.Windows.Forms.Button();
            this.regis_button = new System.Windows.Forms.Button();
            this.regis_showpassword = new System.Windows.Forms.CheckBox();
            this.regis_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regis_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.regis_verpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.regis_buttondangnhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 664);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(115, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 350);
            this.label6.TabIndex = 9;
            this.label6.Text = "The Coffee House";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 566);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đã có tài khoản";
            // 
            // regis_buttondangnhap
            // 
            this.regis_buttondangnhap.BackColor = System.Drawing.Color.White;
            this.regis_buttondangnhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regis_buttondangnhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regis_buttondangnhap.Location = new System.Drawing.Point(24, 606);
            this.regis_buttondangnhap.Name = "regis_buttondangnhap";
            this.regis_buttondangnhap.Size = new System.Drawing.Size(421, 34);
            this.regis_buttondangnhap.TabIndex = 9;
            this.regis_buttondangnhap.Text = "Đăng nhập";
            this.regis_buttondangnhap.UseVisualStyleBackColor = false;
            this.regis_buttondangnhap.Click += new System.EventHandler(this.regis_buttondangnhap_Click);
            // 
            // regis_button
            // 
            this.regis_button.BackColor = System.Drawing.Color.White;
            this.regis_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regis_button.Location = new System.Drawing.Point(476, 558);
            this.regis_button.Name = "regis_button";
            this.regis_button.Size = new System.Drawing.Size(181, 34);
            this.regis_button.TabIndex = 17;
            this.regis_button.Text = "Đăng kí";
            this.regis_button.UseVisualStyleBackColor = false;
            this.regis_button.Click += new System.EventHandler(this.regis_button_Click);
            // 
            // regis_showpassword
            // 
            this.regis_showpassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regis_showpassword.Location = new System.Drawing.Point(476, 489);
            this.regis_showpassword.Name = "regis_showpassword";
            this.regis_showpassword.Size = new System.Drawing.Size(162, 30);
            this.regis_showpassword.TabIndex = 16;
            this.regis_showpassword.Text = "Hiện mật khẩu";
            this.regis_showpassword.UseVisualStyleBackColor = true;
            this.regis_showpassword.CheckedChanged += new System.EventHandler(this.regis_showpassword_CheckedChanged);
            // 
            // regis_password
            // 
            this.regis_password.Location = new System.Drawing.Point(476, 329);
            this.regis_password.Name = "regis_password";
            this.regis_password.PasswordChar = '*';
            this.regis_password.Size = new System.Drawing.Size(291, 22);
            this.regis_password.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // regis_username
            // 
            this.regis_username.Location = new System.Drawing.Point(476, 223);
            this.regis_username.Name = "regis_username";
            this.regis_username.Size = new System.Drawing.Size(291, 22);
            this.regis_username.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1019, 9);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 27);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // regis_verpassword
            // 
            this.regis_verpassword.Location = new System.Drawing.Point(476, 439);
            this.regis_verpassword.Name = "regis_verpassword";
            this.regis_verpassword.PasswordChar = '*';
            this.regis_verpassword.Size = new System.Drawing.Size(291, 22);
            this.regis_verpassword.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Verify Password";
            // 
            // UIDangKiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 664);
            this.Controls.Add(this.regis_verpassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regis_button);
            this.Controls.Add(this.regis_showpassword);
            this.Controls.Add(this.regis_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regis_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIDangKiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIDangKiForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox regis_verpassword;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button regis_buttondangnhap;
        private System.Windows.Forms.Button regis_button;
        private System.Windows.Forms.CheckBox regis_showpassword;
        private System.Windows.Forms.TextBox regis_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regis_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;

        #endregion
    }
}