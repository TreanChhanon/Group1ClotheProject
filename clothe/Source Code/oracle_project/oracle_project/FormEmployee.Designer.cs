namespace oracle_project
{
    partial class FormEmployee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
			this.txtUserType = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.empProductImage = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtRole = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.datagridEmployee = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.empProductImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datagridEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUserType
			// 
			this.txtUserType.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserType.Location = new System.Drawing.Point(227, 303);
			this.txtUserType.Margin = new System.Windows.Forms.Padding(6);
			this.txtUserType.Name = "txtUserType";
			this.txtUserType.Size = new System.Drawing.Size(333, 33);
			this.txtUserType.TabIndex = 230;
			this.txtUserType.TextChanged += new System.EventHandler(this.txtUserType_TextChanged);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.Location = new System.Drawing.Point(1226, 490);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(351, 56);
			this.btnBrowse.TabIndex = 229;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// empProductImage
			// 
			this.empProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.empProductImage.Image = global::oracle_project.Properties.Resources.No_Image_Available;
			this.empProductImage.Location = new System.Drawing.Point(1226, 40);
			this.empProductImage.Margin = new System.Windows.Forms.Padding(6);
			this.empProductImage.Name = "empProductImage";
			this.empProductImage.Size = new System.Drawing.Size(351, 410);
			this.empProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.empProductImage.TabIndex = 228;
			this.empProductImage.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(1606, 488);
			this.btnExit.Margin = new System.Windows.Forms.Padding(6);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(236, 58);
			this.btnExit.TabIndex = 227;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(754, 376);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(415, 33);
			this.txtEmail.TabIndex = 224;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(626, 390);
			this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 24);
			this.label11.TabIndex = 223;
			this.label11.Text = "Email";
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtJobTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJobTitle.Location = new System.Drawing.Point(754, 255);
			this.txtJobTitle.Margin = new System.Windows.Forms.Padding(6);
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.Size = new System.Drawing.Size(415, 33);
			this.txtJobTitle.TabIndex = 222;
			this.txtJobTitle.TextChanged += new System.EventHandler(this.txtJobTitle_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(626, 267);
			this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 24);
			this.label12.TabIndex = 221;
			this.label12.Text = "Job Title";
			// 
			// txtRole
			// 
			this.txtRole.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRole.Location = new System.Drawing.Point(227, 369);
			this.txtRole.Margin = new System.Windows.Forms.Padding(6);
			this.txtRole.Name = "txtRole";
			this.txtRole.Size = new System.Drawing.Size(333, 33);
			this.txtRole.TabIndex = 220;
			this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(32, 376);
			this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(46, 24);
			this.label13.TabIndex = 219;
			this.label13.Text = "Role";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(32, 309);
			this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(94, 24);
			this.label17.TabIndex = 214;
			this.label17.Text = "User Type";
			// 
			// txtPhone
			// 
			this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(754, 102);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(415, 33);
			this.txtPhone.TabIndex = 212;
			this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(628, 105);
			this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 24);
			this.label8.TabIndex = 211;
			this.label8.Text = "Phone";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(227, 242);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(333, 33);
			this.txtPassword.TabIndex = 210;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 255);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 24);
			this.label1.TabIndex = 209;
			this.label1.Text = "Password";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(227, 174);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(6);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(333, 33);
			this.txtUserName.TabIndex = 208;
			this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 186);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 24);
			this.label6.TabIndex = 207;
			this.label6.Text = "User Name";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmployeeName.Location = new System.Drawing.Point(227, 102);
			this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(6);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(333, 33);
			this.txtEmployeeName.TabIndex = 206;
			this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(32, 110);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(138, 24);
			this.label7.TabIndex = 205;
			this.label7.Text = "Employee Name";
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(754, 177);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(415, 33);
			this.txtAddress.TabIndex = 204;
			this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(628, 183);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 24);
			this.label4.TabIndex = 203;
			this.label4.Text = "Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 24);
			this.label2.TabIndex = 199;
			this.label2.Text = "Employee ID";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmployeeID.Enabled = false;
			this.txtEmployeeID.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmployeeID.Location = new System.Drawing.Point(227, 34);
			this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(6);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(940, 33);
			this.txtEmployeeID.TabIndex = 198;
			this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
			// 
			// datagridEmployee
			// 
			this.datagridEmployee.AllowUserToAddRows = false;
			this.datagridEmployee.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.datagridEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datagridEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.datagridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagridEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datagridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagridEmployee.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagridEmployee.GridColor = System.Drawing.Color.DarkGray;
			this.datagridEmployee.Location = new System.Drawing.Point(37, 603);
			this.datagridEmployee.Margin = new System.Windows.Forms.Padding(6);
			this.datagridEmployee.Name = "datagridEmployee";
			this.datagridEmployee.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.datagridEmployee.RowHeadersWidth = 51;
			this.datagridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.datagridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagridEmployee.Size = new System.Drawing.Size(1805, 273);
			this.datagridEmployee.TabIndex = 197;
			this.datagridEmployee.Click += new System.EventHandler(this.DatagridEmployee_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(227, 510);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(940, 33);
			this.txtSearch.TabIndex = 196;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(32, 514);
			this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 24);
			this.label10.TabIndex = 195;
			this.label10.Text = "Search";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(1606, 354);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(236, 58);
			this.btnDelete.TabIndex = 194;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(1606, 213);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(236, 58);
			this.btnUpdate.TabIndex = 193;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(1606, 40);
			this.btnAddNew.Margin = new System.Windows.Forms.Padding(6);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(236, 58);
			this.btnAddNew.TabIndex = 192;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FormEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1876, 912);
			this.Controls.Add(this.txtUserType);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.empProductImage);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtJobTitle);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtRole);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.datagridEmployee);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddNew);
			this.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Mangement System";
			this.Load += new System.EventHandler(this.FormEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.empProductImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datagridEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox empProductImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DataGridView datagridEmployee;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}