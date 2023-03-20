﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using oracle_project.DataSet1TableAdapters;

namespace oracle_project
{
    public partial class FormSaleReport : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormSaleReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("showsalereport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            adapter.Fill(ds, "sale");
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(ds.Tables["sale"]);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
