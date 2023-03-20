namespace ClothesManagementSystem
{
    partial class FormDashboard
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblAvailable = new System.Windows.Forms.Label();
			this.lblQtyBuy = new System.Windows.Forms.Label();
			this.available = new FontAwesome.Sharp.IconPictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblOrderQty = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cart = new FontAwesome.Sharp.IconPictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblSpent = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.payment = new FontAwesome.Sharp.IconPictureBox();
			this.cboTotalAmount = new System.Windows.Forms.ComboBox();
			this.cboQty = new System.Windows.Forms.ComboBox();
			this.cboAvailable = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.available)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.lblAvailable);
			this.panel1.Controls.Add(this.lblQtyBuy);
			this.panel1.Controls.Add(this.available);
			this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			this.panel1.Location = new System.Drawing.Point(77, 66);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(331, 121);
			this.panel1.TabIndex = 3;
			// 
			// lblAvailable
			// 
			this.lblAvailable.AutoSize = true;
			this.lblAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAvailable.ForeColor = System.Drawing.Color.Yellow;
			this.lblAvailable.Location = new System.Drawing.Point(32, 68);
			this.lblAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAvailable.Name = "lblAvailable";
			this.lblAvailable.Size = new System.Drawing.Size(0, 29);
			this.lblAvailable.TabIndex = 7;
			// 
			// lblQtyBuy
			// 
			this.lblQtyBuy.AutoSize = true;
			this.lblQtyBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblQtyBuy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblQtyBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblQtyBuy.Location = new System.Drawing.Point(32, 28);
			this.lblQtyBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQtyBuy.Name = "lblQtyBuy";
			this.lblQtyBuy.Size = new System.Drawing.Size(156, 28);
			this.lblQtyBuy.TabIndex = 6;
			this.lblQtyBuy.Text = "Available Items";
			// 
			// available
			// 
			this.available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.available.ForeColor = System.Drawing.Color.Yellow;
			this.available.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
			this.available.IconColor = System.Drawing.Color.Yellow;
			this.available.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.available.IconSize = 54;
			this.available.Location = new System.Drawing.Point(252, 28);
			this.available.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.available.Name = "available";
			this.available.Size = new System.Drawing.Size(59, 54);
			this.available.TabIndex = 6;
			this.available.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Controls.Add(this.lblOrderQty);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cart);
			this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			this.panel2.Location = new System.Drawing.Point(493, 66);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(331, 121);
			this.panel2.TabIndex = 4;
			// 
			// lblOrderQty
			// 
			this.lblOrderQty.AutoSize = true;
			this.lblOrderQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrderQty.ForeColor = System.Drawing.Color.Yellow;
			this.lblOrderQty.Location = new System.Drawing.Point(37, 68);
			this.lblOrderQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOrderQty.Name = "lblOrderQty";
			this.lblOrderQty.Size = new System.Drawing.Size(0, 31);
			this.lblOrderQty.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(39, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = "Total Ordered";
			// 
			// cart
			// 
			this.cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cart.ForeColor = System.Drawing.Color.Lime;
			this.cart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.cart.IconColor = System.Drawing.Color.Lime;
			this.cart.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.cart.IconSize = 54;
			this.cart.Location = new System.Drawing.Point(248, 28);
			this.cart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cart.Name = "cart";
			this.cart.Size = new System.Drawing.Size(56, 54);
			this.cart.TabIndex = 7;
			this.cart.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.lblSpent);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.payment);
			this.panel3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			this.panel3.Location = new System.Drawing.Point(904, 66);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(331, 121);
			this.panel3.TabIndex = 5;
			// 
			// lblSpent
			// 
			this.lblSpent.AutoSize = true;
			this.lblSpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpent.ForeColor = System.Drawing.Color.Yellow;
			this.lblSpent.Location = new System.Drawing.Point(31, 68);
			this.lblSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSpent.Name = "lblSpent";
			this.lblSpent.Size = new System.Drawing.Size(0, 31);
			this.lblSpent.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(32, 28);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 28);
			this.label2.TabIndex = 7;
			this.label2.Text = "Spent Amount";
			// 
			// payment
			// 
			this.payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.payment.ForeColor = System.Drawing.Color.MediumOrchid;
			this.payment.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
			this.payment.IconColor = System.Drawing.Color.MediumOrchid;
			this.payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.payment.IconSize = 54;
			this.payment.Location = new System.Drawing.Point(255, 28);
			this.payment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.payment.Name = "payment";
			this.payment.Size = new System.Drawing.Size(56, 54);
			this.payment.TabIndex = 7;
			this.payment.TabStop = false;
			// 
			// cboTotalAmount
			// 
			this.cboTotalAmount.FormattingEnabled = true;
			this.cboTotalAmount.Location = new System.Drawing.Point(761, 219);
			this.cboTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboTotalAmount.Name = "cboTotalAmount";
			this.cboTotalAmount.Size = new System.Drawing.Size(160, 24);
			this.cboTotalAmount.TabIndex = 7;
			this.cboTotalAmount.Visible = false;
			// 
			// cboQty
			// 
			this.cboQty.FormattingEnabled = true;
			this.cboQty.Location = new System.Drawing.Point(761, 219);
			this.cboQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboQty.Name = "cboQty";
			this.cboQty.Size = new System.Drawing.Size(160, 24);
			this.cboQty.TabIndex = 6;
			this.cboQty.Visible = false;
			// 
			// cboAvailable
			// 
			this.cboAvailable.FormattingEnabled = true;
			this.cboAvailable.Location = new System.Drawing.Point(529, 219);
			this.cboAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboAvailable.Name = "cboAvailable";
			this.cboAvailable.Size = new System.Drawing.Size(160, 24);
			this.cboAvailable.TabIndex = 8;
			this.cboAvailable.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(73, 252);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 28);
			this.label3.TabIndex = 9;
			this.label3.Text = "Recent Ordered";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 40;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.GridColor = System.Drawing.Color.Green;
			this.dataGridView1.Location = new System.Drawing.Point(16, 289);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1253, 290);
			this.dataGridView1.TabIndex = 10;
			// 
			// FormDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1285, 581);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboAvailable);
			this.Controls.Add(this.cboTotalAmount);
			this.Controls.Add(this.cboQty);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormDashboard";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.FormDashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.available)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox available;
        private FontAwesome.Sharp.IconPictureBox cart;
        private FontAwesome.Sharp.IconPictureBox payment;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblQtyBuy;
        private System.Windows.Forms.Label lblOrderQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTotalAmount;
        private System.Windows.Forms.ComboBox cboQty;
        private System.Windows.Forms.ComboBox cboAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}