using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ClothesManagementSystem
{
    public partial class FormInvoice : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormInvoice()
        {
            InitializeComponent();
        }
        private void showorder()
        {
            OracleCommand cmd = new OracleCommand("showinvoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cid", Convert.ToInt32(UserLogin.getUserID()));
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            adapter.Fill(ds, "invoice");
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(ds.Tables["invoice"]);
            crystalReportViewer1.ReportSource = rpt;
        }
        private void showsumtotal()
        {
            OracleCommand cmd = new OracleCommand("showinvoicetotal", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cid", Convert.ToInt32(UserLogin.getUserID()));
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            adapter.Fill(ds, "total");
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(ds.Tables["total"]);
            crystalReportViewer1.ReportSource = rpt;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            showorder();
         //   showsumtotal();
        }
    }
}
