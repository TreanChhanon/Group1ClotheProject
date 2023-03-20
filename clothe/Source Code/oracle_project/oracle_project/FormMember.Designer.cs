namespace oracle_project
{
    partial class FormMember
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
			this.btnExit = new System.Windows.Forms.Button();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMemberID = new System.Windows.Forms.TextBox();
			this.dgvMember = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(1106, 321);
			this.btnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(215, 58);
			this.btnExit.TabIndex = 208;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// txtMemberName
			// 
			this.txtMemberName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMemberName.Location = new System.Drawing.Point(204, 142);
			this.txtMemberName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(424, 33);
			this.txtMemberName.TabIndex = 207;
			// 
			// txtDiscount
			// 
			this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiscount.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscount.Location = new System.Drawing.Point(934, 142);
			this.txtDiscount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(74, 33);
			this.txtDiscount.TabIndex = 206;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 142);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 24);
			this.label1.TabIndex = 205;
			this.label1.Text = "Member Name";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(749, 147);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 24);
			this.label5.TabIndex = 204;
			this.label5.Text = "Discount Percentage";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(92, 67);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 24);
			this.label2.TabIndex = 203;
			this.label2.Text = "Member ID";
			// 
			// txtMemberID
			// 
			this.txtMemberID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMemberID.Enabled = false;
			this.txtMemberID.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMemberID.Location = new System.Drawing.Point(204, 64);
			this.txtMemberID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtMemberID.Name = "txtMemberID";
			this.txtMemberID.Size = new System.Drawing.Size(804, 33);
			this.txtMemberID.TabIndex = 202;
			// 
			// dgvMember
			// 
			this.dgvMember.AllowUserToAddRows = false;
			this.dgvMember.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMember.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvMember.GridColor = System.Drawing.Color.DarkGray;
			this.dgvMember.Location = new System.Drawing.Point(35, 406);
			this.dgvMember.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvMember.Name = "dgvMember";
			this.dgvMember.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvMember.RowHeadersWidth = 51;
			this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMember.Size = new System.Drawing.Size(1291, 148);
			this.dgvMember.TabIndex = 201;
			this.dgvMember.Click += new System.EventHandler(this.DgvMember_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(185, 344);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(804, 33);
			this.txtSearch.TabIndex = 200;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(108, 347);
			this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 24);
			this.label10.TabIndex = 199;
			this.label10.Text = "Search";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(1106, 230);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(215, 58);
			this.btnDelete.TabIndex = 198;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(1106, 147);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(215, 58);
			this.btnUpdate.TabIndex = 197;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(1106, 64);
			this.btnAddNew.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(215, 58);
			this.btnAddNew.TabIndex = 196;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
			// 
			// FormMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1351, 569);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtMemberName);
			this.Controls.Add(this.txtDiscount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMemberID);
			this.Controls.Add(this.dgvMember);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddNew);
			this.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "FormMember";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Member Management System";
			this.Load += new System.EventHandler(this.FormMember_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
    }
}