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
  
    public partial class FormPayment : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormPayment()
        {
            InitializeComponent();
        }
     
        private void showallpayment()
        {
            OracleCommand cmd = new OracleCommand("showallpayment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cid", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "showallpayment");
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = ds.Tables["showallpayment"];
            dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
      //    this.dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
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
        private void FormPayment_Load(object sender, EventArgs e)
        {
            showallpayment();
            
            showuserpaymentamount();
            showqtyuser();
            lblPaymentCount.Text = "Total Paid Payment : " + cboTotalAmount.SelectedValue + " $";
            lblQtyBuy.Text = "Total Items : " + cboQty.SelectedValue;
             dataGridView1.ClearSelection();
            }
    }
}
