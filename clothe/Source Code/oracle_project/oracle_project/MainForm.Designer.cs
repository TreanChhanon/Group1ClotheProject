namespace oracle_project
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnExit = new System.Windows.Forms.Button();
			this.statusShowDate = new System.Windows.Forms.Label();
			this.statusShowTime = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.statusUserType = new System.Windows.Forms.Label();
			this.statusUserName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOpenProduct = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCategories = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btnLogOut = new FontAwesome.Sharp.IconButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ChartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.SaleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label5 = new System.Windows.Forms.Label();
			this.comboEarning = new System.Windows.Forms.ComboBox();
			this.comboTotalSale = new System.Windows.Forms.ComboBox();
			this.comboTotalItem = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblEarning = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.payment = new FontAwesome.Sharp.IconPictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblTotalSales = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cart = new FontAwesome.Sharp.IconPictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lblTotalItem = new System.Windows.Forms.Label();
			this.lblQtyBuy = new System.Windows.Forms.Label();
			this.available = new FontAwesome.Sharp.IconPictureBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChartTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SaleChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.available)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Location = new System.Drawing.Point(1803, 938);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 28);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// statusShowDate
			// 
			this.statusShowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.statusShowDate.AutoSize = true;
			this.statusShowDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusShowDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.statusShowDate.Location = new System.Drawing.Point(632, 27);
			this.statusShowDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusShowDate.Name = "statusShowDate";
			this.statusShowDate.Size = new System.Drawing.Size(118, 29);
			this.statusShowDate.TabIndex = 14;
			this.statusShowDate.Text = "Show Date";
			// 
			// statusShowTime
			// 
			this.statusShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.statusShowTime.AutoSize = true;
			this.statusShowTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusShowTime.ForeColor = System.Drawing.Color.Magenta;
			this.statusShowTime.Location = new System.Drawing.Point(1420, 33);
			this.statusShowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusShowTime.Name = "statusShowTime";
			this.statusShowTime.Size = new System.Drawing.Size(111, 29);
			this.statusShowTime.TabIndex = 13;
			this.statusShowTime.Text = "ShowTime";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(329, 27);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 29);
			this.label3.TabIndex = 12;
			this.label3.Text = "User Type:";
			// 
			// statusUserType
			// 
			this.statusUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.statusUserType.AutoSize = true;
			this.statusUserType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusUserType.ForeColor = System.Drawing.Color.Lime;
			this.statusUserType.Location = new System.Drawing.Point(457, 27);
			this.statusUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusUserType.Name = "statusUserType";
			this.statusUserType.Size = new System.Drawing.Size(120, 29);
			this.statusUserType.TabIndex = 11;
			this.statusUserType.Text = "Show Type";
			// 
			// statusUserName
			// 
			this.statusUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.statusUserName.AutoSize = true;
			this.statusUserName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusUserName.ForeColor = System.Drawing.Color.Yellow;
			this.statusUserName.Location = new System.Drawing.Point(155, 27);
			this.statusUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusUserName.Name = "statusUserName";
			this.statusUserName.Size = new System.Drawing.Size(164, 29);
			this.statusUserName.TabIndex = 10;
			this.statusUserName.Text = "ShowUserName";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(17, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 29);
			this.label1.TabIndex = 9;
			this.label1.Text = "UserName:";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.MenuOpenProduct,
            this.toolStripMenuItem1,
            this.salesToolStripMenuItem,
            this.menuCategories,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.toolStripMenuItem11,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(230, 978);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// employeesToolStripMenuItem
			// 
			this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.employeesToolStripMenuItem.Image = global::oracle_project.Properties.Resources.employees;
			this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
			this.employeesToolStripMenuItem.Size = new System.Drawing.Size(213, 52);
			this.employeesToolStripMenuItem.Text = "Employees";
			this.employeesToolStripMenuItem.Click += new System.EventHandler(this.EmployeesToolStripMenuItem_Click);
			// 
			// MenuOpenProduct
			// 
			this.MenuOpenProduct.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuOpenProduct.ForeColor = System.Drawing.Color.White;
			this.MenuOpenProduct.Image = global::oracle_project.Properties.Resources.products;
			this.MenuOpenProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MenuOpenProduct.Name = "MenuOpenProduct";
			this.MenuOpenProduct.Size = new System.Drawing.Size(213, 52);
			this.MenuOpenProduct.Text = "Products";
			this.MenuOpenProduct.Click += new System.EventHandler(this.MenuOpenProduct_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem1.Image = global::oracle_project.Properties.Resources.shop_icon;
			this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem1.Text = "Order";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.salesToolStripMenuItem.Image = global::oracle_project.Properties.Resources.sale_icon;
			this.salesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(213, 52);
			this.salesToolStripMenuItem.Text = "Sales Details";
			this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click_1);
			// 
			// menuCategories
			// 
			this.menuCategories.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuCategories.ForeColor = System.Drawing.Color.White;
			this.menuCategories.Image = global::oracle_project.Properties.Resources.category;
			this.menuCategories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuCategories.Name = "menuCategories";
			this.menuCategories.Size = new System.Drawing.Size(213, 52);
			this.menuCategories.Text = "Categories";
			this.menuCategories.Click += new System.EventHandler(this.MenuCategories_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem2.Image = global::oracle_project.Properties.Resources.Invoice_icon1;
			this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 68);
			this.toolStripMenuItem2.Text = "Payment";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem4.Image = global::oracle_project.Properties.Resources.members;
			this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem4.Text = "Members";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem5.Image = global::oracle_project.Properties.Resources.purchase;
			this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem5.Text = "Purchases";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click_1);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem3.Image = global::oracle_project.Properties.Resources.customers;
			this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem3.Text = "Customers";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
			this.toolStripMenuItem7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem7.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem7.Image = global::oracle_project.Properties.Resources.reports_icon;
			this.toolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem7.Text = "Sale Report";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Image = global::oracle_project.Properties.Resources.reports_icon;
			this.toolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(252, 54);
			this.toolStripMenuItem8.Text = "Daily Report";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click_1);
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.Image = global::oracle_project.Properties.Resources.reports_icon;
			this.toolStripMenuItem13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(252, 54);
			this.toolStripMenuItem13.Text = "Weekly Report";
			this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.Image = global::oracle_project.Properties.Resources.reports_icon;
			this.toolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(252, 54);
			this.toolStripMenuItem14.Text = "Montly Report";
			this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(30, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 978);
			this.panel1.TabIndex = 16;
			// 
			// panel7
			// 
			this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel7.Controls.Add(this.btnLogOut);
			this.panel7.Location = new System.Drawing.Point(5, 877);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(295, 89);
			this.panel7.TabIndex = 9;
			// 
			// btnLogOut
			// 
			this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogOut.FlatAppearance.BorderSize = 0;
			this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.btnLogOut.ForeColor = System.Drawing.Color.Yellow;
			this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
			this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnLogOut.Location = new System.Drawing.Point(0, 15);
			this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(295, 74);
			this.btnLogOut.TabIndex = 12;
			this.btnLogOut.Text = "Sign Out";
			this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panel2.Controls.Add(this.statusShowTime);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.statusUserName);
			this.panel2.Controls.Add(this.statusUserType);
			this.panel2.Controls.Add(this.statusShowDate);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(300, 882);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1624, 96);
			this.panel2.TabIndex = 17;
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
			this.panel3.Controls.Add(this.ChartTop);
			this.panel3.Controls.Add(this.SaleChart);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.comboEarning);
			this.panel3.Controls.Add(this.comboTotalSale);
			this.panel3.Controls.Add(this.comboTotalItem);
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.Location = new System.Drawing.Point(300, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1624, 882);
			this.panel3.TabIndex = 18;
			// 
			// ChartTop
			// 
			this.ChartTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.ChartTop.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.ChartTop.Legends.Add(legend1);
			this.ChartTop.Location = new System.Drawing.Point(1066, 232);
			this.ChartTop.Name = "ChartTop";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Top";
			this.ChartTop.Series.Add(series1);
			this.ChartTop.Size = new System.Drawing.Size(465, 372);
			this.ChartTop.TabIndex = 20;
			this.ChartTop.Text = "ChartTop";
			// 
			// SaleChart
			// 
			this.SaleChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.Name = "RevenueArea";
			this.SaleChart.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.SaleChart.Legends.Add(legend2);
			this.SaleChart.Location = new System.Drawing.Point(69, 232);
			this.SaleChart.Name = "SaleChart";
			series2.ChartArea = "RevenueArea";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
			series2.IsValueShownAsLabel = true;
			series2.Legend = "Legend1";
			series2.Name = "Sales";
			series2.YValuesPerPoint = 2;
			this.SaleChart.Series.Add(series2);
			this.SaleChart.Size = new System.Drawing.Size(926, 372);
			this.SaleChart.TabIndex = 19;
			this.SaleChart.Text = "Revenue";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(65, 639);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 24);
			this.label5.TabIndex = 18;
			this.label5.Text = "Lastest Ordered";
			// 
			// comboEarning
			// 
			this.comboEarning.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboEarning.FormattingEnabled = true;
			this.comboEarning.Location = new System.Drawing.Point(918, 13);
			this.comboEarning.Margin = new System.Windows.Forms.Padding(4);
			this.comboEarning.Name = "comboEarning";
			this.comboEarning.Size = new System.Drawing.Size(119, 32);
			this.comboEarning.TabIndex = 17;
			this.comboEarning.Visible = false;
			// 
			// comboTotalSale
			// 
			this.comboTotalSale.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTotalSale.FormattingEnabled = true;
			this.comboTotalSale.Location = new System.Drawing.Point(752, 13);
			this.comboTotalSale.Margin = new System.Windows.Forms.Padding(4);
			this.comboTotalSale.Name = "comboTotalSale";
			this.comboTotalSale.Size = new System.Drawing.Size(119, 32);
			this.comboTotalSale.TabIndex = 16;
			this.comboTotalSale.Visible = false;
			// 
			// comboTotalItem
			// 
			this.comboTotalItem.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTotalItem.FormattingEnabled = true;
			this.comboTotalItem.Location = new System.Drawing.Point(553, 13);
			this.comboTotalItem.Margin = new System.Windows.Forms.Padding(4);
			this.comboTotalItem.Name = "comboTotalItem";
			this.comboTotalItem.Size = new System.Drawing.Size(119, 32);
			this.comboTotalItem.TabIndex = 15;
			this.comboTotalItem.Visible = false;
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
			this.dataGridView1.Location = new System.Drawing.Point(69, 680);
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
			this.dataGridView1.Size = new System.Drawing.Size(1462, 194);
			this.dataGridView1.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.AutoSize = true;
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel4.Controls.Add(this.lblEarning);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.payment);
			this.panel4.Location = new System.Drawing.Point(1066, 47);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(465, 121);
			this.panel4.TabIndex = 13;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// lblEarning
			// 
			this.lblEarning.AutoSize = true;
			this.lblEarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblEarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEarning.ForeColor = System.Drawing.Color.Yellow;
			this.lblEarning.Location = new System.Drawing.Point(31, 68);
			this.lblEarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEarning.Name = "lblEarning";
			this.lblEarning.Size = new System.Drawing.Size(0, 31);
			this.lblEarning.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(32, 28);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Earning Amount";
			// 
			// payment
			// 
			this.payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.payment.ForeColor = System.Drawing.Color.MediumOrchid;
			this.payment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
			this.payment.IconColor = System.Drawing.Color.MediumOrchid;
			this.payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.payment.IconSize = 54;
			this.payment.Location = new System.Drawing.Point(290, 28);
			this.payment.Margin = new System.Windows.Forms.Padding(4);
			this.payment.Name = "payment";
			this.payment.Size = new System.Drawing.Size(56, 54);
			this.payment.TabIndex = 7;
			this.payment.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.AutoSize = true;
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel5.Controls.Add(this.lblTotalSales);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.cart);
			this.panel5.Location = new System.Drawing.Point(629, 47);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(366, 121);
			this.panel5.TabIndex = 12;
			// 
			// lblTotalSales
			// 
			this.lblTotalSales.AutoSize = true;
			this.lblTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalSales.ForeColor = System.Drawing.Color.Yellow;
			this.lblTotalSales.Location = new System.Drawing.Point(38, 68);
			this.lblTotalSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalSales.Name = "lblTotalSales";
			this.lblTotalSales.Size = new System.Drawing.Size(0, 31);
			this.lblTotalSales.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(24, 28);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ordered Quantity";
			// 
			// cart
			// 
			this.cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cart.ForeColor = System.Drawing.Color.Lime;
			this.cart.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
			this.cart.IconColor = System.Drawing.Color.Lime;
			this.cart.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.cart.IconSize = 54;
			this.cart.Location = new System.Drawing.Point(291, 28);
			this.cart.Margin = new System.Windows.Forms.Padding(4);
			this.cart.Name = "cart";
			this.cart.Size = new System.Drawing.Size(56, 54);
			this.cart.TabIndex = 7;
			this.cart.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.AutoSize = true;
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel6.Controls.Add(this.lblTotalItem);
			this.panel6.Controls.Add(this.lblQtyBuy);
			this.panel6.Controls.Add(this.available);
			this.panel6.Location = new System.Drawing.Point(69, 47);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(464, 121);
			this.panel6.TabIndex = 11;
			// 
			// lblTotalItem
			// 
			this.lblTotalItem.AutoSize = true;
			this.lblTotalItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalItem.ForeColor = System.Drawing.Color.Yellow;
			this.lblTotalItem.Location = new System.Drawing.Point(32, 68);
			this.lblTotalItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalItem.Name = "lblTotalItem";
			this.lblTotalItem.Size = new System.Drawing.Size(0, 29);
			this.lblTotalItem.TabIndex = 7;
			// 
			// lblQtyBuy
			// 
			this.lblQtyBuy.AutoSize = true;
			this.lblQtyBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblQtyBuy.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQtyBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblQtyBuy.Location = new System.Drawing.Point(32, 28);
			this.lblQtyBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQtyBuy.Name = "lblQtyBuy";
			this.lblQtyBuy.Size = new System.Drawing.Size(109, 24);
			this.lblQtyBuy.TabIndex = 6;
			this.lblQtyBuy.Text = "Total Items";
			// 
			// available
			// 
			this.available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.available.ForeColor = System.Drawing.Color.Yellow;
			this.available.IconChar = FontAwesome.Sharp.IconChar.TShirt;
			this.available.IconColor = System.Drawing.Color.Yellow;
			this.available.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.available.IconSize = 54;
			this.available.Location = new System.Drawing.Point(252, 28);
			this.available.Margin = new System.Windows.Forms.Padding(4);
			this.available.Name = "available";
			this.available.Size = new System.Drawing.Size(54, 54);
			this.available.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.available.TabIndex = 6;
			this.available.TabStop = false;
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
			this.toolStripMenuItem11.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem11.Image = global::oracle_project.Properties.Resources.changepwd;
			this.toolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem11.Text = "Changes Password";
			this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click_1);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
			this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem6.Image = global::oracle_project.Properties.Resources.products;
			this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(213, 52);
			this.toolStripMenuItem6.Text = "PurchaseDetails";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click_1);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 978);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnExit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin System";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChartTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SaleChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.available)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label statusShowDate;
        private System.Windows.Forms.Label statusShowTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusUserType;
        private System.Windows.Forms.Label statusUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenProduct;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCategories;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEarning;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox payment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox cart;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label lblQtyBuy;
        private FontAwesome.Sharp.IconPictureBox available;
        private System.Windows.Forms.ComboBox comboTotalSale;
        private System.Windows.Forms.ComboBox comboTotalItem;
        private System.Windows.Forms.ComboBox comboEarning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DataVisualization.Charting.Chart SaleChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart ChartTop;
		private System.Windows.Forms.Panel panel7;
		private FontAwesome.Sharp.IconButton btnLogOut;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
	}
}