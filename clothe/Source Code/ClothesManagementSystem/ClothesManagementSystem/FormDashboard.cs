using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace ClothesManagementSystem
{
    public partial class FormDashboard : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormDashboard()
        {
            InitializeComponent();
        }
        private static Double Total;
        private static String test1;
        private static String test2;
        private void showtotayorder()
        {
                OracleCommand cmd = new OracleCommand("todayorder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("cid", UserLogin.getUserID());
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "all");
                dataGridView1.RowTemplate.Height = 50;
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
        private void showuserpaymentamount()
        {
            OracleCommand cmd = new OracleCommand("showuserpaymentamount", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cid", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "amount");

            cboTotalAmount.DataSource = ds.Tables["amount"];
            cboTotalAmount.DisplayMember = "Payment";
            cboTotalAmount.ValueMember = "Payment";

            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void showqtyuser()
        {
            OracleCommand cmd = new OracleCommand("showqtyuser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cid", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "itemqty");

            cboQty.DataSource = ds.Tables["itemqty"];
            cboQty.DisplayMember = "qty";
            cboQty.ValueMember = "qty";

            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }

        private void availableproduct()
        {
            OracleCommand cmd = new OracleCommand("availableproduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "available");

            cboAvailable.DataSource = ds.Tables["available"];
            cboAvailable.DisplayMember = "available";
            cboAvailable.ValueMember = "available";

            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void FormDashboard_Load(object sender, EventArgs e)

        {
 
            showtotayorder();
            showuserpaymentamount();
            showqtyuser();
            availableproduct();
            lblAvailable.Text = Convert.ToString(cboAvailable.SelectedValue);
            test1 = Convert.ToString(cboQty.SelectedValue);
            test2 = Convert.ToString(cboQty.SelectedValue);
            if(test1 != "" && test2 != "")
            {
                Total = Convert.ToDouble(cboTotalAmount.SelectedValue);
                lblSpent.Text = Total.ToString("#,##0.00" + "$");
                lblOrderQty.Text = Convert.ToString(cboQty.SelectedValue);
            }
            else
            {
                lblSpent.Text = "0 $";
                lblOrderQty.Text = "0";
            }

        }
    }
}
