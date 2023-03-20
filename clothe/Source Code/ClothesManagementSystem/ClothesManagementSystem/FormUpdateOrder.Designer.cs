namespace ClothesManagementSystem
{
    partial class FormUpdateOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateOrder));
			this.txtQty = new System.Windows.Forms.TextBox();
			this.lblSize = new System.Windows.Forms.Label();
			this.sizeCombo = new System.Windows.Forms.ComboBox();
			this.lblColor = new System.Windows.Forms.Label();
			this.colorCombo = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtForPrice = new System.Windows.Forms.TextBox();
			this.btnMinus = new FontAwesome.Sharp.IconPictureBox();
			this.btnPlus = new FontAwesome.Sharp.IconPictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
			this.SuspendLayout();
			// 
			// txtQty
			// 
			this.txtQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(397, 165);
			this.txtQty.Margin = new System.Windows.Forms.Padding(4);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(101, 26);
			this.txtQty.TabIndex = 18;
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblSize
			// 
			this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSize.AutoSize = true;
			this.lblSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblSize.ForeColor = System.Drawing.Color.White;
			this.lblSize.Location = new System.Drawing.Point(241, 290);
			this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(55, 29);
			this.lblSize.TabIndex = 17;
			this.lblSize.Text = "Size";
			// 
			// sizeCombo
			// 
			this.sizeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.sizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sizeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sizeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sizeCombo.FormattingEnabled = true;
			this.sizeCombo.IntegralHeight = false;
			this.sizeCombo.ItemHeight = 20;
			this.sizeCombo.Location = new System.Drawing.Point(362, 281);
			this.sizeCombo.Margin = new System.Windows.Forms.Padding(4);
			this.sizeCombo.Name = "sizeCombo";
			this.sizeCombo.Size = new System.Drawing.Size(181, 28);
			this.sizeCombo.TabIndex = 15;
			// 
			// lblColor
			// 
			this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblColor.AutoSize = true;
			this.lblColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblColor.ForeColor = System.Drawing.Color.White;
			this.lblColor.Location = new System.Drawing.Point(228, 243);
			this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(62, 29);
			this.lblColor.TabIndex = 16;
			this.lblColor.Text = "Color";
			// 
			// colorCombo
			// 
			this.colorCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.colorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.colorCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorCombo.FormattingEnabled = true;
			this.colorCombo.IntegralHeight = false;
			this.colorCombo.ItemHeight = 18;
			this.colorCombo.Location = new System.Drawing.Point(362, 236);
			this.colorCombo.Margin = new System.Windows.Forms.Padding(4);
			this.colorCombo.Name = "colorCombo";
			this.colorCombo.Size = new System.Drawing.Size(181, 26);
			this.colorCombo.TabIndex = 14;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnUpdate.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.Gold;
			this.btnUpdate.Location = new System.Drawing.Point(371, 348);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(172, 62);
			this.btnUpdate.TabIndex = 20;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(838, 105);
			this.panel1.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(324, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 48);
			this.label1.TabIndex = 20;
			this.label1.Text = "Update Item";
			// 
			// lblQuantity
			// 
			this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblQuantity.ForeColor = System.Drawing.Color.White;
			this.lblQuantity.Location = new System.Drawing.Point(193, 173);
			this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(97, 29);
			this.lblQuantity.TabIndex = 19;
			this.lblQuantity.Text = "Quantity";
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
			this.txtTotalPrice.Location = new System.Drawing.Point(357, 439);
			this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(211, 26);
			this.txtTotalPrice.TabIndex = 23;
			this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(245, 439);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(90, 29);
			this.lblTotal.TabIndex = 22;
			this.lblTotal.Text = "Total : ";
			// 
			// txtForPrice
			// 
			this.txtForPrice.Location = new System.Drawing.Point(16, 457);
			this.txtForPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtForPrice.Name = "txtForPrice";
			this.txtForPrice.Size = new System.Drawing.Size(52, 22);
			this.txtForPrice.TabIndex = 24;
			this.txtForPrice.Visible = false;
			// 
			// btnMinus
			// 
			this.btnMinus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
			this.btnMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMinus.IconSize = 28;
			this.btnMinus.Location = new System.Drawing.Point(357, 165);
			this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(32, 28);
			this.btnMinus.TabIndex = 12;
			this.btnMinus.TabStop = false;
			this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnPlus.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.btnPlus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPlus.IconSize = 30;
			this.btnPlus.Location = new System.Drawing.Point(513, 166);
			this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(32, 30);
			this.btnPlus.TabIndex = 13;
			this.btnPlus.TabStop = false;
			this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
			// 
			// FormUpdateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(838, 621);
			this.Controls.Add(this.txtForPrice);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.lblSize);
			this.Controls.Add(this.sizeCombo);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.colorCombo);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnPlus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormUpdateOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormUpdateOrder";
			this.Load += new System.EventHandler(this.FormUpdateOrder_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox colorCombo;
        private FontAwesome.Sharp.IconPictureBox btnMinus;
        private FontAwesome.Sharp.IconPictureBox btnPlus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtForPrice;
    }
}