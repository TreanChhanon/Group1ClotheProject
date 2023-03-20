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
namespace oracle_project
{
    public partial class FormPayment : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormPayment()
        {
            InitializeComponent();
        }
        private void ShowPaymentAdmin()
        {
            OracleCommand cmd = new OracleCommand("ShowPaymentAdmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "all");
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.DataSource = ds.Tables["all"];
   
           
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

         
            this.dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();

        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            
            ShowPaymentAdmin();
        }
    }
}
