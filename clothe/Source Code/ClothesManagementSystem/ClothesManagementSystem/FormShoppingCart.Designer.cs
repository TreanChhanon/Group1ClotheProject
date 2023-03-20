namespace ClothesManagementSystem
{
    partial class FormShoppingCart
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShoppingCart));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			this.lblItemCount = new System.Windows.Forms.Label();
			this.btnUpdate = new FontAwesome.Sharp.IconPictureBox();
			this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
			this.btnAddCart = new FontAwesome.Sharp.IconPictureBox();
			this.cboCountrow = new System.Windows.Forms.ComboBox();
			this.cboTotalAmount = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 29;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(16, 193);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1367, 555);
			this.dataGridView1.TabIndex = 0;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
			this.txtTotalPrice.Location = new System.Drawing.Point(1184, 17);
			this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(187, 26);
			this.txtTotalPrice.TabIndex = 219;
			this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTotalPrice
			// 
			this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
			this.lblTotalPrice.Location = new System.Drawing.Point(1012, 17);
			this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(134, 28);
			this.lblTotalPrice.TabIndex = 220;
			this.lblTotalPrice.Text = "Total Amount";
			// 
			// lblItemCount
			// 
			this.lblItemCount.AutoSize = true;
			this.lblItemCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblItemCount.ForeColor = System.Drawing.Color.White;
			this.lblItemCount.Location = new System.Drawing.Point(11, 17);
			this.lblItemCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblItemCount.Name = "lblItemCount";
			this.lblItemCount.Size = new System.Drawing.Size(0, 27);
			this.lblItemCount.TabIndex = 221;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnUpdate.ForeColor = System.Drawing.Color.LawnGreen;
			this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FilePen;
			this.btnUpdate.IconColor = System.Drawing.Color.LawnGreen;
			this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnUpdate.IconSize = 42;
			this.btnUpdate.Location = new System.Drawing.Point(1232, 144);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(45, 42);
			this.btnUpdate.TabIndex = 223;
			this.btnUpdate.TabStop = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnDelete.ForeColor = System.Drawing.Color.Red;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.Red;
			this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDelete.IconSize = 41;
			this.btnDelete.Location = new System.Drawing.Point(1319, 144);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(41, 42);
			this.btnDelete.TabIndex = 222;
			this.btnDelete.TabStop = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnAddCart
			// 
			this.btnAddCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.btnAddCart.ForeColor = System.Drawing.Color.GreenYellow;
			this.btnAddCart.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
			this.btnAddCart.IconColor = System.Drawing.Color.GreenYellow;
			this.btnAddCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAddCart.IconSize = 73;
			this.btnAddCart.Location = new System.Drawing.Point(599, 2);
			this.btnAddCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAddCart.Name = "btnAddCart";
			this.btnAddCart.Size = new System.Drawing.Size(167, 73);
			this.btnAddCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnAddCart.TabIndex = 218;
			this.btnAddCart.TabStop = false;
			this.btnAddCart.Click += new System.EventHandler(this.BtnAddCart_Click);
			// 
			// cboCountrow
			// 
			this.cboCountrow.FormattingEnabled = true;
			this.cboCountrow.Location = new System.Drawing.Point(213, 145);
			this.cboCountrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboCountrow.Name = "cboCountrow";
			this.cboCountrow.Size = new System.Drawing.Size(160, 24);
			this.cboCountrow.TabIndex = 224;
			// 
			// cboTotalAmount
			// 
			this.cboTotalAmount.FormattingEnabled = true;
			this.cboTotalAmount.Location = new System.Drawing.Point(424, 148);
			this.cboTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboTotalAmount.Name = "cboTotalAmount";
			this.cboTotalAmount.Size = new System.Drawing.Size(160, 24);
			this.cboTotalAmount.TabIndex = 225;
			// 
			// FormShoppingCart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1388, 753);
			this.Controls.Add(this.cboTotalAmount);
			this.Controls.Add(this.cboCountrow);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lblItemCount);
			this.Controls.Add(this.lblTotalPrice);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.btnAddCart);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormShoppingCart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shopping Cart";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox btnAddCart;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblItemCount;
        private FontAwesome.Sharp.IconPictureBox btnDelete;
        private FontAwesome.Sharp.IconPictureBox btnUpdate;
        private System.Windows.Forms.ComboBox cboCountrow;
        private System.Windows.Forms.ComboBox cboTotalAmount;
    }
}