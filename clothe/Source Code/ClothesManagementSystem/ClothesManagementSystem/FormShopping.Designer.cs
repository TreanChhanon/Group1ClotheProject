namespace ClothesManagementSystem
{
    partial class FormShopping
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnKidFashion = new FontAwesome.Sharp.IconButton();
			this.btnMaleFashion = new FontAwesome.Sharp.IconButton();
			this.btnWomanFashion = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnBag = new FontAwesome.Sharp.IconButton();
			this.btnJewelry = new FontAwesome.Sharp.IconButton();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMenu.Controls.Add(this.btnJewelry);
			this.panelMenu.Controls.Add(this.btnBag);
			this.panelMenu.Controls.Add(this.btnKidFashion);
			this.panelMenu.Controls.Add(this.btnMaleFashion);
			this.panelMenu.Controls.Add(this.btnWomanFashion);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelMenu.Location = new System.Drawing.Point(992, 0);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(293, 581);
			this.panelMenu.TabIndex = 4;
			// 
			// btnKidFashion
			// 
			this.btnKidFashion.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKidFashion.FlatAppearance.BorderSize = 0;
			this.btnKidFashion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKidFashion.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnKidFashion.ForeColor = System.Drawing.Color.White;
			this.btnKidFashion.IconChar = FontAwesome.Sharp.IconChar.ChildDress;
			this.btnKidFashion.IconColor = System.Drawing.Color.White;
			this.btnKidFashion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnKidFashion.IconSize = 35;
			this.btnKidFashion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKidFashion.Location = new System.Drawing.Point(0, 270);
			this.btnKidFashion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnKidFashion.Name = "btnKidFashion";
			this.btnKidFashion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnKidFashion.Size = new System.Drawing.Size(293, 49);
			this.btnKidFashion.TabIndex = 4;
			this.btnKidFashion.Text = "Kid\'s Fashion";
			this.btnKidFashion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKidFashion.UseVisualStyleBackColor = true;
			this.btnKidFashion.Click += new System.EventHandler(this.BtnKidFashion_Click);
			// 
			// btnMaleFashion
			// 
			this.btnMaleFashion.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMaleFashion.FlatAppearance.BorderSize = 0;
			this.btnMaleFashion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaleFashion.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnMaleFashion.ForeColor = System.Drawing.Color.White;
			this.btnMaleFashion.IconChar = FontAwesome.Sharp.IconChar.Person;
			this.btnMaleFashion.IconColor = System.Drawing.Color.White;
			this.btnMaleFashion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMaleFashion.IconSize = 35;
			this.btnMaleFashion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMaleFashion.Location = new System.Drawing.Point(0, 221);
			this.btnMaleFashion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMaleFashion.Name = "btnMaleFashion";
			this.btnMaleFashion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnMaleFashion.Size = new System.Drawing.Size(293, 49);
			this.btnMaleFashion.TabIndex = 1;
			this.btnMaleFashion.Text = "Male\'s Fashion";
			this.btnMaleFashion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMaleFashion.UseVisualStyleBackColor = true;
			this.btnMaleFashion.Click += new System.EventHandler(this.BtnMaleFashion_Click);
			// 
			// btnWomanFashion
			// 
			this.btnWomanFashion.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnWomanFashion.FlatAppearance.BorderSize = 0;
			this.btnWomanFashion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWomanFashion.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnWomanFashion.ForeColor = System.Drawing.Color.White;
			this.btnWomanFashion.IconChar = FontAwesome.Sharp.IconChar.Female;
			this.btnWomanFashion.IconColor = System.Drawing.Color.White;
			this.btnWomanFashion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnWomanFashion.IconSize = 35;
			this.btnWomanFashion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnWomanFashion.Location = new System.Drawing.Point(0, 172);
			this.btnWomanFashion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnWomanFashion.Name = "btnWomanFashion";
			this.btnWomanFashion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnWomanFashion.Size = new System.Drawing.Size(293, 49);
			this.btnWomanFashion.TabIndex = 0;
			this.btnWomanFashion.Text = "Woman\'s Fashion";
			this.btnWomanFashion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnWomanFashion.UseVisualStyleBackColor = true;
			this.btnWomanFashion.Click += new System.EventHandler(this.BtnWomanFashion_Click);
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
			this.btnHome.Image = global::ClothesManagementSystem.Properties.Resources.dior_shop_new_york1;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(293, 172);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 4;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// panelDesktop
			// 
			this.panelDesktop.Controls.Add(this.pictureBox1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(0, 0);
			this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(992, 581);
			this.panelDesktop.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::ClothesManagementSystem.Properties.Resources.Jisoo_Dior2;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(992, 581);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnBag
			// 
			this.btnBag.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBag.FlatAppearance.BorderSize = 0;
			this.btnBag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBag.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnBag.ForeColor = System.Drawing.Color.White;
			this.btnBag.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
			this.btnBag.IconColor = System.Drawing.Color.White;
			this.btnBag.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBag.IconSize = 35;
			this.btnBag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBag.Location = new System.Drawing.Point(0, 319);
			this.btnBag.Margin = new System.Windows.Forms.Padding(4);
			this.btnBag.Name = "btnBag";
			this.btnBag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnBag.Size = new System.Drawing.Size(293, 49);
			this.btnBag.TabIndex = 5;
			this.btnBag.Text = "Bag\'s Fashion";
			this.btnBag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBag.UseVisualStyleBackColor = true;
			this.btnBag.Click += new System.EventHandler(this.btnBag_Click_1);
			// 
			// btnJewelry
			// 
			this.btnJewelry.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnJewelry.FlatAppearance.BorderSize = 0;
			this.btnJewelry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnJewelry.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnJewelry.ForeColor = System.Drawing.Color.White;
			this.btnJewelry.IconChar = FontAwesome.Sharp.IconChar.Gem;
			this.btnJewelry.IconColor = System.Drawing.Color.White;
			this.btnJewelry.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnJewelry.IconSize = 35;
			this.btnJewelry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnJewelry.Location = new System.Drawing.Point(0, 368);
			this.btnJewelry.Margin = new System.Windows.Forms.Padding(4);
			this.btnJewelry.Name = "btnJewelry";
			this.btnJewelry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnJewelry.Size = new System.Drawing.Size(293, 49);
			this.btnJewelry.TabIndex = 6;
			this.btnJewelry.Text = "Jewelry";
			this.btnJewelry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnJewelry.UseVisualStyleBackColor = true;
			this.btnJewelry.Click += new System.EventHandler(this.btnJewelry_Click_1);
			// 
			// FormShopping
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1285, 581);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelMenu);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormShopping";
			this.Text = "Shopping";
			this.Load += new System.EventHandler(this.FormShopping_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnWomanFashion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnKidFashion;
        private FontAwesome.Sharp.IconButton btnMaleFashion;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
		private FontAwesome.Sharp.IconButton btnJewelry;
		private FontAwesome.Sharp.IconButton btnBag;
	}
}