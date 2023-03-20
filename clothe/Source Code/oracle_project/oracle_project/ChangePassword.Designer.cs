namespace oracle_project
{
    partial class ChangePassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnConfirmedPassword = new System.Windows.Forms.Button();
			this.txtConfirmedNewPassword = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnOldPassword = new System.Windows.Forms.Button();
			this.txtOldPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChangePassword = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnNewPassword = new System.Windows.Forms.Button();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gold;
			this.label3.Location = new System.Drawing.Point(301, 213);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(249, 28);
			this.label3.TabIndex = 36;
			this.label3.Text = "Confirmed New Password";
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.btnConfirmedPassword);
			this.panel3.Controls.Add(this.txtConfirmedNewPassword);
			this.panel3.Location = new System.Drawing.Point(305, 249);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(281, 33);
			this.panel3.TabIndex = 38;
			// 
			// btnConfirmedPassword
			// 
			this.btnConfirmedPassword.BackColor = System.Drawing.Color.LightGray;
			this.btnConfirmedPassword.FlatAppearance.BorderSize = 0;
			this.btnConfirmedPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmedPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnConfirmedPassword.Image = global::oracle_project.Properties.Resources.eye_icon_close;
			this.btnConfirmedPassword.Location = new System.Drawing.Point(223, -1);
			this.btnConfirmedPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConfirmedPassword.Name = "btnConfirmedPassword";
			this.btnConfirmedPassword.Size = new System.Drawing.Size(59, 31);
			this.btnConfirmedPassword.TabIndex = 7;
			this.btnConfirmedPassword.UseVisualStyleBackColor = false;
			this.btnConfirmedPassword.Click += new System.EventHandler(this.btnConfirmedPassword_Click);
			// 
			// txtConfirmedNewPassword
			// 
			this.txtConfirmedNewPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtConfirmedNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConfirmedNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmedNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtConfirmedNewPassword.Location = new System.Drawing.Point(0, 0);
			this.txtConfirmedNewPassword.Margin = new System.Windows.Forms.Padding(13, 7, 5, 7);
			this.txtConfirmedNewPassword.Name = "txtConfirmedNewPassword";
			this.txtConfirmedNewPassword.Size = new System.Drawing.Size(281, 30);
			this.txtConfirmedNewPassword.TabIndex = 17;
			this.txtConfirmedNewPassword.UseSystemPasswordChar = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.btnOldPassword);
			this.panel2.Controls.Add(this.txtOldPassword);
			this.panel2.Location = new System.Drawing.Point(301, 80);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(281, 33);
			this.panel2.TabIndex = 37;
			// 
			// btnOldPassword
			// 
			this.btnOldPassword.BackColor = System.Drawing.Color.LightGray;
			this.btnOldPassword.FlatAppearance.BorderSize = 0;
			this.btnOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOldPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnOldPassword.Image = global::oracle_project.Properties.Resources.eye_icon_close;
			this.btnOldPassword.Location = new System.Drawing.Point(223, -1);
			this.btnOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOldPassword.Name = "btnOldPassword";
			this.btnOldPassword.Size = new System.Drawing.Size(59, 31);
			this.btnOldPassword.TabIndex = 7;
			this.btnOldPassword.UseVisualStyleBackColor = false;
			this.btnOldPassword.Click += new System.EventHandler(this.btnOldPassword_Click);
			// 
			// txtOldPassword
			// 
			this.txtOldPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOldPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtOldPassword.Location = new System.Drawing.Point(3, 0);
			this.txtOldPassword.Margin = new System.Windows.Forms.Padding(13, 7, 5, 7);
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.Size = new System.Drawing.Size(281, 30);
			this.txtOldPassword.TabIndex = 18;
			this.txtOldPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(296, 44);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 28);
			this.label1.TabIndex = 32;
			this.label1.Text = "Old Password";
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnChangePassword.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.btnChangePassword.FlatAppearance.BorderSize = 0;
			this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangePassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangePassword.ForeColor = System.Drawing.Color.Gold;
			this.btnChangePassword.Location = new System.Drawing.Point(309, 324);
			this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new System.Drawing.Size(276, 50);
			this.btnChangePassword.TabIndex = 33;
			this.btnChangePassword.Text = "Change Password";
			this.btnChangePassword.UseVisualStyleBackColor = false;
			this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnNewPassword);
			this.panel1.Controls.Add(this.txtNewPassword);
			this.panel1.Location = new System.Drawing.Point(304, 164);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(281, 33);
			this.panel1.TabIndex = 35;
			// 
			// btnNewPassword
			// 
			this.btnNewPassword.BackColor = System.Drawing.Color.LightGray;
			this.btnNewPassword.FlatAppearance.BorderSize = 0;
			this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnNewPassword.Image = global::oracle_project.Properties.Resources.eye_icon_close;
			this.btnNewPassword.Location = new System.Drawing.Point(223, -1);
			this.btnNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNewPassword.Name = "btnNewPassword";
			this.btnNewPassword.Size = new System.Drawing.Size(59, 31);
			this.btnNewPassword.TabIndex = 7;
			this.btnNewPassword.UseVisualStyleBackColor = false;
			this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtNewPassword.Location = new System.Drawing.Point(0, 0);
			this.txtNewPassword.Margin = new System.Windows.Forms.Padding(13, 7, 5, 7);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Size = new System.Drawing.Size(281, 30);
			this.txtNewPassword.TabIndex = 17;
			this.txtNewPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(297, 128);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 28);
			this.label2.TabIndex = 34;
			this.label2.Text = "New Password";
			// 
			// ChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
			this.ClientSize = new System.Drawing.Size(882, 420);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnChangePassword);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangePassword";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfirmedPassword;
        private System.Windows.Forms.TextBox txtConfirmedNewPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
    }
}