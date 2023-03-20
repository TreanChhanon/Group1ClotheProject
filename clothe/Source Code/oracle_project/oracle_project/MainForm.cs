using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Oracle.ManagedDataAccess.Client;

namespace oracle_project
{
    public partial class MainForm : Form
    {
        OracleConnection conn = DbConnection.connect();
        public MainForm()
        {
            InitializeComponent();
        }
        private static Double total;
        private void allorderforadmin()
        {
            OracleCommand cmd = new OracleCommand("allorderforadmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "all");
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = ds.Tables["all"];
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();

        }
        private void saleitemforadmin()
        {
            OracleCommand cmd = new OracleCommand("saleitemforadmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "item");
            comboTotalSale.DataSource = ds.Tables["item"];
            comboTotalSale.DisplayMember = "qty";
            comboTotalSale.ValueMember = "qty";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void showitemadmin()
        {
            OracleCommand cmd = new OracleCommand("showitemadmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "showitemadmin");
            comboTotalItem.DataSource = ds.Tables["showitemadmin"];
            comboTotalItem.DisplayMember = "qty";
            comboTotalItem.ValueMember = "qty";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void showadminearning()
        {
            OracleCommand cmd = new OracleCommand("showadminearning", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "showadminearning");
            comboEarning.DataSource = ds.Tables["showadminearning"];
            comboEarning.DisplayMember = "total";
            comboEarning.ValueMember = "total";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            statusUserName.Text = UserLogin.getUsername();
            statusUserType.Text = UserLogin.getuserType();
            statusShowDate.Text = DateTime.Now.ToString("D");
            timer1.Start();
            allorderforadmin();
            saleitemforadmin();
            showitemadmin();
            showadminearning();
            loadrevenue();
            loadtop3();
            if(UserLogin.getuserType() == "member")
            {
                toolStripMenuItem1.Enabled = false;
                salesToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
				toolStripMenuItem4.Enabled = false;
				toolStripMenuItem5.Enabled = false;
                toolStripMenuItem5.Enabled = false;
				toolStripMenuItem11.Enabled = false;
				toolStripMenuItem7.Enabled = false;
				toolStripMenuItem6.Enabled = false;
                toolStripMenuItem3.Enabled = false;

			}
            if(UserLogin.getuserType() == "manager")
            {
				toolStripMenuItem1.Enabled = false;
				salesToolStripMenuItem.Enabled = false;
				toolStripMenuItem2.Enabled = false;
				toolStripMenuItem4.Enabled = false;
				employeesToolStripMenuItem.Enabled= false;
				employeesToolStripMenuItem.Enabled =false;
				menuCategories.Enabled = false;
				MenuOpenProduct.Enabled = false;
				toolStripMenuItem6.Enabled = false;
			}

       

				if (Convert.ToInt32(comboTotalItem.SelectedValue) != 0 && Convert.ToInt32(comboTotalItem.SelectedValue) != 0)
				{
					lblTotalSales.Text = Convert.ToString(comboTotalSale.SelectedValue);
					lblTotalItem.Text = Convert.ToString(comboTotalItem.SelectedValue);
					total = Convert.ToDouble(comboEarning.SelectedValue);
					lblEarning.Text = total.ToString("#,##0.00" + "$");

				}
			
     
 
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            statusShowTime.Text = DateTime.Now.ToString("T");
        }
        private void OpenForm(Form frm, string title)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == title)
                {
                    isOpen = true;
                    form.Focus();
                }
            }

            if (isOpen == false)
            {
                frm.Show();
            }
        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormEmployee(), "Employee Management Form");
        }

        private void MenuOpenProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProduct(), "Product Management Form");
        }

        private void MenuCategories_Click(object sender, EventArgs e)
        {
            OpenForm(new frmCategory(), "Category Management Form");
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMember(), "Member Management Form");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            OpenForm(new ChangePassword(), "ChangePassword Management Form");
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCustomer(), "Customer Management Form");
        }

        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SalesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormSalesDetails(), "SalesDetails Management Form");
        }



        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPurchase(), "Purchase Management Form");
        }

        private void PurchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPurchaseDetails(), "Purchase Details Management Form");
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormMember(), "Member Management Form");
        }

        private void salesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormSalesDetails(), "Sales Detail Management Form");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormOrder(), "Order Management Form");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPayment(), "Payment Management Form");
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormPurchase(), "Payment Management Form");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPurchaseDetails(), "Purchase Details Management Form");
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormSaleReport(), "Daily Sale Report Management Form");
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            OpenForm(new WeeklyReport(), "Weekly Sale Report Management Form");
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            OpenForm(new MonthlyReport(), "Monthly Sale Report Management Form");
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormCustomer(), "Customer Management Form");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        void loadrevenue()
        {
            DataTable dtrevenue = Revenue.RevenueChart(1);

            SaleChart.Titles.Add("Last 7 Days");
            SaleChart.DataSource = dtrevenue;
            SaleChart.Series["Sales"].XValueMember = "dte";
			SaleChart.Series["Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
			SaleChart.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
			SaleChart.Series["Sales"].YValueMembers = "QTY";
			SaleChart.Series["Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			SaleChart.ChartAreas[0].AxisX.IsMarginVisible = false;
		}

        void loadtop3()
        {
            DataTable dttop3 = Revenue.Top3(7);
            ChartTop.Titles.Add("Current Top 3");
            ChartTop.DataSource = dttop3;
            ChartTop.Series["Top"].XValueMember = "ITEM";
            ChartTop.Series["Top"].YValueMembers = "QTY";

		}
		private void SaleChart_Click(object sender, EventArgs e)
		{
            
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormLogin frm = new FormLogin();
			frm.ShowDialog();
			this.Close();
		}

		private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
		{
			OpenForm(new FormPurchaseDetails(), "PurchaseDetails Management Form");
		}

		private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
		{
			OpenForm(new ChangePassword(), "ChangePassword Management Form");
		}
	}
}
