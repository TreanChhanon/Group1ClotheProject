namespace oracle_project
{
    partial class FormOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboCustomer = new System.Windows.Forms.ComboBox();
			this.cboProduct = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboColor = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cboSize = new System.Windows.Forms.ComboBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cboPrice = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnUndoCancel = new System.Windows.Forms.Button();
			this.btnAddPayment = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(83, 260);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(1223, 31);
			this.txtSearch.TabIndex = 217;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 263);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 24);
			this.label5.TabIndex = 216;
			this.label5.Text = "Search";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(539, 211);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(116, 41);
			this.btnDelete.TabIndex = 215;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(311, 211);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(116, 41);
			this.btnUpdate.TabIndex = 214;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(113, 211);
			this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(116, 41);
			this.btnAddNew.TabIndex = 213;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(169, 94);
			this.txtQty.Margin = new System.Windows.Forms.Padding(4);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(263, 31);
			this.txtQty.TabIndex = 211;
			this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
			// 
			// txtOrderID
			// 
			this.txtOrderID.Enabled = false;
			this.txtOrderID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOrderID.Location = new System.Drawing.Point(169, 31);
			this.txtOrderID.Margin = new System.Windows.Forms.Padding(4);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Size = new System.Drawing.Size(263, 31);
			this.txtOrderID.TabIndex = 210;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(581, 33);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 24);
			this.label3.TabIndex = 209;
			this.label3.Text = "Product";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(80, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 24);
			this.label2.TabIndex = 208;
			this.label2.Text = "Quantity";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 24);
			this.label1.TabIndex = 207;
			this.label1.Text = "OrderID";
			// 
			// cboCustomer
			// 
			this.cboCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboCustomer.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboCustomer.FormattingEnabled = true;
			this.cboCustomer.Location = new System.Drawing.Point(659, 154);
			this.cboCustomer.Margin = new System.Windows.Forms.Padding(4);
			this.cboCustomer.Name = "cboCustomer";
			this.cboCustomer.Size = new System.Drawing.Size(249, 32);
			this.cboCustomer.TabIndex = 219;
			// 
			// cboProduct
			// 
			this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboProduct.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboProduct.FormattingEnabled = true;
			this.cboProduct.Location = new System.Drawing.Point(659, 30);
			this.cboProduct.Margin = new System.Windows.Forms.Padding(4);
			this.cboProduct.Name = "cboProduct";
			this.cboProduct.Size = new System.Drawing.Size(249, 32);
			this.cboProduct.TabIndex = 220;
			this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(565, 158);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 24);
			this.label4.TabIndex = 221;
			this.label4.Text = "Customer";
			// 
			// cboColor
			// 
			this.cboColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboColor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboColor.FormattingEnabled = true;
			this.cboColor.Location = new System.Drawing.Point(1056, 30);
			this.cboColor.Margin = new System.Windows.Forms.Padding(4);
			this.cboColor.Name = "cboColor";
			this.cboColor.Size = new System.Drawing.Size(249, 32);
			this.cboColor.TabIndex = 222;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(995, 34);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 24);
			this.label6.TabIndex = 223;
			this.label6.Text = "Color";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1002, 94);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 24);
			this.label7.TabIndex = 225;
			this.label7.Text = "Size";
			// 
			// cboSize
			// 
			this.cboSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboSize.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSize.FormattingEnabled = true;
			this.cboSize.Location = new System.Drawing.Point(1056, 87);
			this.cboSize.Margin = new System.Windows.Forms.Padding(4);
			this.cboSize.Name = "cboSize";
			this.cboSize.Size = new System.Drawing.Size(249, 32);
			this.cboSize.TabIndex = 224;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.Location = new System.Drawing.Point(169, 155);
			this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(263, 31);
			this.txtTotalPrice.TabIndex = 229;
			this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(67, 158);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 24);
			this.label9.TabIndex = 228;
			this.label9.Text = "TotalPrice";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 40;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.GridColor = System.Drawing.Color.Green;
			this.dataGridView1.Location = new System.Drawing.Point(-5, 303);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1356, 264);
			this.dataGridView1.TabIndex = 231;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// cboPrice
			// 
			this.cboPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPrice.FormattingEnabled = true;
			this.cboPrice.Location = new System.Drawing.Point(659, 94);
			this.cboPrice.Margin = new System.Windows.Forms.Padding(4);
			this.cboPrice.Name = "cboPrice";
			this.cboPrice.Size = new System.Drawing.Size(249, 32);
			this.cboPrice.TabIndex = 232;
			this.cboPrice.SelectedIndexChanged += new System.EventHandler(this.cboPrice_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(565, 97);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 24);
			this.label10.TabIndex = 233;
			this.label10.Text = "Unit Price";
			// 
			// btnUndoCancel
			// 
			this.btnUndoCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnUndoCancel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUndoCancel.Location = new System.Drawing.Point(742, 211);
			this.btnUndoCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnUndoCancel.Name = "btnUndoCancel";
			this.btnUndoCancel.Size = new System.Drawing.Size(116, 41);
			this.btnUndoCancel.TabIndex = 234;
			this.btnUndoCancel.Text = "Undo Cancel";
			this.btnUndoCancel.UseVisualStyleBackColor = true;
			this.btnUndoCancel.Click += new System.EventHandler(this.btnUndoCancel_Click);
			// 
			// btnAddPayment
			// 
			this.btnAddPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAddPayment.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPayment.Location = new System.Drawing.Point(913, 211);
			this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddPayment.Name = "btnAddPayment";
			this.btnAddPayment.Size = new System.Drawing.Size(199, 41);
			this.btnAddPayment.TabIndex = 235;
			this.btnAddPayment.Text = "Add Payment";
			this.btnAddPayment.UseVisualStyleBackColor = true;
			this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(1163, 211);
			this.btnExit.Margin = new System.Windows.Forms.Padding(6);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(143, 39);
			this.btnExit.TabIndex = 236;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FormOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1351, 569);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAddPayment);
			this.Controls.Add(this.btnUndoCancel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cboPrice);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cboSize);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cboColor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboProduct);
			this.Controls.Add(this.cboCustomer);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.txtOrderID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Order Management System";
			this.Load += new System.EventHandler(this.FormOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUndoCancel;
        private System.Windows.Forms.Button btnAddPayment;
		private System.Windows.Forms.Button btnExit;
	}
}