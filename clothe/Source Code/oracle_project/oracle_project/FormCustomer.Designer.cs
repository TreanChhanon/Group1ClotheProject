namespace oracle_project
{
    partial class FormCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
			this.btnExit = new System.Windows.Forms.Button();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboMember = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.dgvCustomer = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(1109, 365);
			this.btnExit.Margin = new System.Windows.Forms.Padding(5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(215, 59);
			this.btnExit.TabIndex = 215;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(205, 288);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(424, 31);
			this.txtPhone.TabIndex = 214;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(139, 291);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 24);
			this.label1.TabIndex = 213;
			this.label1.Text = "Phone";
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJobTitle.Location = new System.Drawing.Point(205, 219);
			this.txtJobTitle.Margin = new System.Windows.Forms.Padding(5);
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.Size = new System.Drawing.Size(424, 31);
			this.txtJobTitle.TabIndex = 212;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(109, 226);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 24);
			this.label6.TabIndex = 211;
			this.label6.Text = "Job Title";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerName.Location = new System.Drawing.Point(205, 147);
			this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(424, 31);
			this.txtCustomerName.TabIndex = 210;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(54, 150);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 24);
			this.label7.TabIndex = 209;
			this.label7.Text = "Customer Name";
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(935, 211);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(74, 31);
			this.txtAddress.TabIndex = 208;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(843, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 24);
			this.label4.TabIndex = 207;
			this.label4.Text = "Address";
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(935, 87);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(74, 31);
			this.txtEmail.TabIndex = 206;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(872, 94);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 24);
			this.label3.TabIndex = 205;
			this.label3.Text = "Email";
			// 
			// comboMember
			// 
			this.comboMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboMember.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboMember.FormattingEnabled = true;
			this.comboMember.Location = new System.Drawing.Point(935, 287);
			this.comboMember.Margin = new System.Windows.Forms.Padding(5);
			this.comboMember.Name = "comboMember";
			this.comboMember.Size = new System.Drawing.Size(74, 32);
			this.comboMember.TabIndex = 204;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(845, 290);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 24);
			this.label5.TabIndex = 203;
			this.label5.Text = "Member";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(78, 84);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 24);
			this.label2.TabIndex = 202;
			this.label2.Text = "Customer ID";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCustomerID.Enabled = false;
			this.txtCustomerID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerID.Location = new System.Drawing.Point(205, 81);
			this.txtCustomerID.Margin = new System.Windows.Forms.Padding(5);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(74, 31);
			this.txtCustomerID.TabIndex = 201;
			// 
			// dgvCustomer
			// 
			this.dgvCustomer.AllowUserToAddRows = false;
			this.dgvCustomer.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCustomer.GridColor = System.Drawing.Color.DarkGray;
			this.dgvCustomer.Location = new System.Drawing.Point(31, 434);
			this.dgvCustomer.Margin = new System.Windows.Forms.Padding(5);
			this.dgvCustomer.Name = "dgvCustomer";
			this.dgvCustomer.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCustomer.RowHeadersWidth = 51;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomer.Size = new System.Drawing.Size(1291, 121);
			this.dgvCustomer.TabIndex = 200;
			this.dgvCustomer.Click += new System.EventHandler(this.DgvCustomer_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(205, 387);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(804, 31);
			this.txtSearch.TabIndex = 199;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(127, 390);
			this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 24);
			this.label10.TabIndex = 198;
			this.label10.Text = "Search";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(1109, 265);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(215, 59);
			this.btnDelete.TabIndex = 197;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(1109, 173);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(215, 59);
			this.btnUpdate.TabIndex = 196;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(1109, 72);
			this.btnAddNew.Margin = new System.Windows.Forms.Padding(5);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(215, 59);
			this.btnAddNew.TabIndex = 195;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(935, 155);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(74, 31);
			this.txtPassword.TabIndex = 217;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(837, 158);
			this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 24);
			this.label8.TabIndex = 216;
			this.label8.Text = "Password";
			// 
			// FormCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1351, 569);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtJobTitle);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboMember);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.dgvCustomer);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddNew);
			this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FormCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Mangement System";
			this.Load += new System.EventHandler(this.FormCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
    }
}