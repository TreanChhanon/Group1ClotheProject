namespace ClothesManagementSystem
{
    partial class FormAddPayment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPayment));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPrint = new FontAwesome.Sharp.IconPictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cboDiscount = new System.Windows.Forms.ComboBox();
			this.lbldiscountprice = new System.Windows.Forms.Label();
			this.lbldiscount = new System.Windows.Forms.Label();
			this.txtDiscountPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPayment = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboPaymentType = new System.Windows.Forms.ComboBox();
			this.btnPayment = new FontAwesome.Sharp.IconPictureBox();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPayment)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnPrint);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.cboDiscount);
			this.panel1.Controls.Add(this.lbldiscountprice);
			this.panel1.Controls.Add(this.lbldiscount);
			this.panel1.Controls.Add(this.txtDiscountPrice);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtPayment);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cboPaymentType);
			this.panel1.Controls.Add(this.btnPayment);
			this.panel1.Controls.Add(this.txtTotalAmount);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(836, 596);
			this.panel1.TabIndex = 0;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.btnPrint.ForeColor = System.Drawing.Color.GreenYellow;
			this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
			this.btnPrint.IconColor = System.Drawing.Color.GreenYellow;
			this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPrint.IconSize = 108;
			this.btnPrint.Location = new System.Drawing.Point(585, 128);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(108, 112);
			this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnPrint.TabIndex = 230;
			this.btnPrint.TabStop = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.Blue;
			this.textBox1.Location = new System.Drawing.Point(322, 314);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(207, 26);
			this.textBox1.TabIndex = 229;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cboDiscount
			// 
			this.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.cboDiscount.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cboDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cboDiscount.FormattingEnabled = true;
			this.cboDiscount.Location = new System.Drawing.Point(52, 473);
			this.cboDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboDiscount.Name = "cboDiscount";
			this.cboDiscount.Size = new System.Drawing.Size(84, 25);
			this.cboDiscount.TabIndex = 228;
			// 
			// lbldiscountprice
			// 
			this.lbldiscountprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbldiscountprice.AutoSize = true;
			this.lbldiscountprice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lbldiscountprice.ForeColor = System.Drawing.Color.White;
			this.lbldiscountprice.Location = new System.Drawing.Point(121, 374);
			this.lbldiscountprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbldiscountprice.Name = "lbldiscountprice";
			this.lbldiscountprice.Size = new System.Drawing.Size(144, 28);
			this.lbldiscountprice.TabIndex = 227;
			this.lbldiscountprice.Text = "Discount Price";
			// 
			// lbldiscount
			// 
			this.lbldiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbldiscount.AutoSize = true;
			this.lbldiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lbldiscount.ForeColor = System.Drawing.Color.White;
			this.lbldiscount.Location = new System.Drawing.Point(127, 315);
			this.lbldiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbldiscount.Name = "lbldiscount";
			this.lbldiscount.Size = new System.Drawing.Size(113, 28);
			this.lbldiscount.TabIndex = 226;
			this.lbldiscount.Text = "Discount %";
			// 
			// txtDiscountPrice
			// 
			this.txtDiscountPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtDiscountPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscountPrice.ForeColor = System.Drawing.Color.Blue;
			this.txtDiscountPrice.Location = new System.Drawing.Point(323, 373);
			this.txtDiscountPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDiscountPrice.Name = "txtDiscountPrice";
			this.txtDiscountPrice.ReadOnly = true;
			this.txtDiscountPrice.Size = new System.Drawing.Size(205, 26);
			this.txtDiscountPrice.TabIndex = 225;
			this.txtDiscountPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(131, 126);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 28);
			this.label4.TabIndex = 223;
			this.label4.Text = "Amount Pay";
			// 
			// txtPayment
			// 
			this.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPayment.ForeColor = System.Drawing.Color.Blue;
			this.txtPayment.Location = new System.Drawing.Point(323, 128);
			this.txtPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPayment.Name = "txtPayment";
			this.txtPayment.ReadOnly = true;
			this.txtPayment.Size = new System.Drawing.Size(211, 26);
			this.txtPayment.TabIndex = 222;
			this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(127, 251);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 28);
			this.label3.TabIndex = 221;
			this.label3.Text = "Payment Type";
			// 
			// cboPaymentType
			// 
			this.cboPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPaymentType.ForeColor = System.Drawing.Color.Green;
			this.cboPaymentType.FormattingEnabled = true;
			this.cboPaymentType.Location = new System.Drawing.Point(322, 249);
			this.cboPaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboPaymentType.Name = "cboPaymentType";
			this.cboPaymentType.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cboPaymentType.Size = new System.Drawing.Size(207, 33);
			this.cboPaymentType.TabIndex = 220;
			// 
			// btnPayment
			// 
			this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.btnPayment.ForeColor = System.Drawing.Color.GreenYellow;
			this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
			this.btnPayment.IconColor = System.Drawing.Color.GreenYellow;
			this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPayment.IconSize = 108;
			this.btnPayment.Location = new System.Drawing.Point(585, 277);
			this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(108, 112);
			this.btnPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnPayment.TabIndex = 219;
			this.btnPayment.TabStop = false;
			this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalAmount.ForeColor = System.Drawing.Color.Blue;
			this.txtTotalAmount.Location = new System.Drawing.Point(323, 190);
			this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.ReadOnly = true;
			this.txtTotalAmount.Size = new System.Drawing.Size(211, 26);
			this.txtTotalAmount.TabIndex = 30;
			this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(131, 190);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 28);
			this.label2.TabIndex = 29;
			this.label2.Text = "Total Amount";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(836, 85);
			this.panel2.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(351, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 42);
			this.label1.TabIndex = 27;
			this.label1.Text = "Payment";
			// 
			// FormAddPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(836, 596);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormAddPayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payment";
			this.Load += new System.EventHandler(this.FormAddPayment_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPayment)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox btnPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.TextBox txtDiscountPrice;
        private System.Windows.Forms.Label lbldiscountprice;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox btnPrint;
    }
}