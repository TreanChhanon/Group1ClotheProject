namespace ClothesManagementSystem
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnLogOut = new FontAwesome.Sharp.IconButton();
			this.btnPayment = new FontAwesome.Sharp.IconButton();
			this.btnShopping = new FontAwesome.Sharp.IconButton();
			this.btnProfile = new FontAwesome.Sharp.IconButton();
			this.btnDashboard = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
			this.btnZoom = new FontAwesome.Sharp.IconPictureBox();
			this.btnExit = new FontAwesome.Sharp.IconPictureBox();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.slidePic = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnZoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.Controls.Add(this.btnLogOut);
			this.panelMenu.Controls.Add(this.btnPayment);
			this.panelMenu.Controls.Add(this.btnShopping);
			this.panelMenu.Controls.Add(this.btnProfile);
			this.panelMenu.Controls.Add(this.btnDashboard);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(293, 1055);
			this.panelMenu.TabIndex = 3;
			// 
			// btnLogOut
			// 
			this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogOut.FlatAppearance.BorderSize = 0;
			this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogOut.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogOut.ForeColor = System.Drawing.Color.Yellow;
			this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
			this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnLogOut.Location = new System.Drawing.Point(0, 981);
			this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(293, 74);
			this.btnLogOut.TabIndex = 11;
			this.btnLogOut.Text = "Sign Out";
			this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
			// 
			// btnPayment
			// 
			this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPayment.FlatAppearance.BorderSize = 0;
			this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPayment.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnPayment.ForeColor = System.Drawing.Color.White;
			this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
			this.btnPayment.IconColor = System.Drawing.Color.White;
			this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPayment.Location = new System.Drawing.Point(0, 394);
			this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(293, 74);
			this.btnPayment.TabIndex = 3;
			this.btnPayment.Text = "Payment";
			this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPayment.UseVisualStyleBackColor = true;
			this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
			// 
			// btnShopping
			// 
			this.btnShopping.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnShopping.FlatAppearance.BorderSize = 0;
			this.btnShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShopping.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnShopping.ForeColor = System.Drawing.Color.White;
			this.btnShopping.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.btnShopping.IconColor = System.Drawing.Color.White;
			this.btnShopping.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnShopping.Location = new System.Drawing.Point(0, 320);
			this.btnShopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShopping.Name = "btnShopping";
			this.btnShopping.Size = new System.Drawing.Size(293, 74);
			this.btnShopping.TabIndex = 2;
			this.btnShopping.Text = "Shopping";
			this.btnShopping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnShopping.UseVisualStyleBackColor = true;
			this.btnShopping.Click += new System.EventHandler(this.BtnShopping_Click);
			// 
			// btnProfile
			// 
			this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProfile.FlatAppearance.BorderSize = 0;
			this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProfile.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnProfile.ForeColor = System.Drawing.Color.White;
			this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
			this.btnProfile.IconColor = System.Drawing.Color.White;
			this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProfile.Location = new System.Drawing.Point(0, 246);
			this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnProfile.Name = "btnProfile";
			this.btnProfile.Size = new System.Drawing.Size(293, 74);
			this.btnProfile.TabIndex = 1;
			this.btnProfile.Text = "Profile";
			this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProfile.UseVisualStyleBackColor = true;
			this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.FlatAppearance.BorderSize = 0;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
			this.btnDashboard.IconColor = System.Drawing.Color.White;
			this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.Location = new System.Drawing.Point(0, 172);
			this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(293, 74);
			this.btnDashboard.TabIndex = 0;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.btnHome);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(293, 172);
			this.panelLogo.TabIndex = 0;
			// 
			// btnHome
			// 
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnHome.Image = global::ClothesManagementSystem.Properties.Resources.dior;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(293, 172);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 4;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panelTitleBar.Controls.Add(this.btnMinimize);
			this.panelTitleBar.Controls.Add(this.btnZoom);
			this.panelTitleBar.Controls.Add(this.btnExit);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(293, 0);
			this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1631, 98);
			this.panelTitleBar.TabIndex = 4;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMinimize.IconSize = 30;
			this.btnMinimize.Location = new System.Drawing.Point(1503, 15);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(32, 30);
			this.btnMinimize.TabIndex = 4;
			this.btnMinimize.TabStop = false;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
			// 
			// btnZoom
			// 
			this.btnZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnZoom.ForeColor = System.Drawing.Color.LightCyan;
			this.btnZoom.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
			this.btnZoom.IconColor = System.Drawing.Color.LightCyan;
			this.btnZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnZoom.IconSize = 30;
			this.btnZoom.Location = new System.Drawing.Point(1543, 15);
			this.btnZoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnZoom.Name = "btnZoom";
			this.btnZoom.Size = new System.Drawing.Size(32, 30);
			this.btnZoom.TabIndex = 3;
			this.btnZoom.TabStop = false;
			this.btnZoom.Click += new System.EventHandler(this.BtnZoom_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
			this.btnExit.IconColor = System.Drawing.Color.Red;
			this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExit.IconSize = 30;
			this.btnExit.Location = new System.Drawing.Point(1583, 15);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 30);
			this.btnExit.TabIndex = 2;
			this.btnExit.TabStop = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
			this.lblTitleChildForm.Location = new System.Drawing.Point(72, 41);
			this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(64, 28);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Home";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Yellow;
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.Yellow;
			this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconCurrentChildForm.IconSize = 38;
			this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 31);
			this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 38);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(293, 98);
			this.panelShadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1631, 11);
			this.panelShadow.TabIndex = 5;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.panelDesktop.Controls.Add(this.slidePic);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(293, 109);
			this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1631, 946);
			this.panelDesktop.TabIndex = 6;
			this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint);
			// 
			// slidePic
			// 
			this.slidePic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slidePic.Image = global::ClothesManagementSystem.Properties.Resources._3;
			this.slidePic.Location = new System.Drawing.Point(0, 0);
			this.slidePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.slidePic.Name = "slidePic";
			this.slidePic.Size = new System.Drawing.Size(1631, 946);
			this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.slidePic.TabIndex = 0;
			this.slidePic.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 2200;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(1924, 1055);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(961, 0);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnZoom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
     //   private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
      //  private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
      //  private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnShopping;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnZoom;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
    }
}

