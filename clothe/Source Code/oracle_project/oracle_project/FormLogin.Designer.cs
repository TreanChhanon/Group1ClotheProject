namespace oracle_project
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnShowhidepassword = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnShowhidepassword);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Location = new System.Drawing.Point(94, 364);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(281, 33);
			this.panel1.TabIndex = 27;
			// 
			// btnShowhidepassword
			// 
			this.btnShowhidepassword.BackColor = System.Drawing.Color.LightGray;
			this.btnShowhidepassword.FlatAppearance.BorderSize = 0;
			this.btnShowhidepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowhidepassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnShowhidepassword.Image = global::oracle_project.Properties.Resources.eye_icon_close;
			this.btnShowhidepassword.Location = new System.Drawing.Point(223, -1);
			this.btnShowhidepassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowhidepassword.Name = "btnShowhidepassword";
			this.btnShowhidepassword.Size = new System.Drawing.Size(59, 31);
			this.btnShowhidepassword.TabIndex = 7;
			this.btnShowhidepassword.UseVisualStyleBackColor = false;
			this.btnShowhidepassword.Click += new System.EventHandler(this.BtnShowhidepassword_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtPassword.Location = new System.Drawing.Point(0, 0);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(13, 7, 5, 7);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(281, 30);
			this.txtPassword.TabIndex = 17;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(89, 329);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 28);
			this.label2.TabIndex = 26;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(86, 249);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 28);
			this.label1.TabIndex = 22;
			this.label1.Text = "UserName";
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtUsername.Location = new System.Drawing.Point(93, 278);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(281, 31);
			this.txtUsername.TabIndex = 25;
			this.txtUsername.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLogin.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.Gold;
			this.btnLogin.Location = new System.Drawing.Point(93, 431);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(123, 50);
			this.btnLogin.TabIndex = 24;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(93, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(283, 226);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnExit.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Gold;
			this.btnExit.Location = new System.Drawing.Point(256, 431);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 50);
			this.btnExit.TabIndex = 28;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(457, 546);
			this.ControlBox = false;
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIGN IN";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowhidepassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}