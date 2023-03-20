namespace ClothesManagementSystem
{
    partial class FormPayment
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboTotalAmount = new System.Windows.Forms.ComboBox();
			this.cboQty = new System.Windows.Forms.ComboBox();
			this.lblPaymentCount = new System.Windows.Forms.Label();
			this.lblQtyBuy = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cboTotalAmount);
			this.panel1.Controls.Add(this.cboQty);
			this.panel1.Controls.Add(this.lblPaymentCount);
			this.panel1.Controls.Add(this.lblQtyBuy);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(853, 78);
			this.panel1.TabIndex = 2;
			// 
			// cboTotalAmount
			// 
			this.cboTotalAmount.FormattingEnabled = true;
			this.cboTotalAmount.Location = new System.Drawing.Point(633, 28);
			this.cboTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboTotalAmount.Name = "cboTotalAmount";
			this.cboTotalAmount.Size = new System.Drawing.Size(160, 24);
			this.cboTotalAmount.TabIndex = 3;
			this.cboTotalAmount.Visible = false;
			// 
			// cboQty
			// 
			this.cboQty.FormattingEnabled = true;
			this.cboQty.Location = new System.Drawing.Point(163, 28);
			this.cboQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboQty.Name = "cboQty";
			this.cboQty.Size = new System.Drawing.Size(160, 24);
			this.cboQty.TabIndex = 2;
			this.cboQty.Visible = false;
			// 
			// lblPaymentCount
			// 
			this.lblPaymentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPaymentCount.AutoSize = true;
			this.lblPaymentCount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblPaymentCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPaymentCount.Location = new System.Drawing.Point(420, 26);
			this.lblPaymentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPaymentCount.Name = "lblPaymentCount";
			this.lblPaymentCount.Size = new System.Drawing.Size(0, 28);
			this.lblPaymentCount.TabIndex = 1;
			// 
			// lblQtyBuy
			// 
			this.lblQtyBuy.AutoSize = true;
			this.lblQtyBuy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblQtyBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblQtyBuy.Location = new System.Drawing.Point(73, 26);
			this.lblQtyBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQtyBuy.Name = "lblQtyBuy";
			this.lblQtyBuy.Size = new System.Drawing.Size(0, 28);
			this.lblQtyBuy.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 45;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 85);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 11F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersWidth = 40;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(853, 494);
			this.dataGridView1.TabIndex = 11;
			// 
			// FormPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(853, 581);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormPayment";
			this.Text = "Payment";
			this.Load += new System.EventHandler(this.FormPayment_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPaymentCount;
        private System.Windows.Forms.Label lblQtyBuy;
        private System.Windows.Forms.ComboBox cboTotalAmount;
        private System.Windows.Forms.ComboBox cboQty;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}