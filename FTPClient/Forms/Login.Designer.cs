
namespace FTPClient
{
    partial class Login
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
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.server_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(83, 174);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(215, 20);
            this.username_txt.TabIndex = 0;
            this.username_txt.Text = "iktftpucet";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(83, 200);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(215, 20);
            this.password_txt.TabIndex = 1;
            this.password_txt.Text = "Hibiki123";
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(223, 255);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Přihlásit se";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // server_txt
            // 
            this.server_txt.Location = new System.Drawing.Point(83, 229);
            this.server_txt.Name = "server_txt";
            this.server_txt.Size = new System.Drawing.Size(215, 20);
            this.server_txt.TabIndex = 7;
            this.server_txt.Text = "slonice.endora.cz/idk.4fan.cz/web/xd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::FTPClient.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(323, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.server_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desu FTP Client ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox server_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

