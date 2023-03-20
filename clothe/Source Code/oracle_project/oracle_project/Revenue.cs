using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace oracle_project
{

	internal class Revenue
	{
		
		internal static DataTable RevenueChart(int week)
		{
			OracleConnection conn = DbConnection.connect();
			OracleCommand cmd = new OracleCommand("chartsale", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			return dt;
		}
		internal static DataTable Top3(int days)
		{
			OracleConnection conn = DbConnection.connect();
			OracleCommand cmd = new OracleCommand("topthree", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			OracleDataAdapter dapter = new OracleDataAdapter(cmd);
			DataTable data = new DataTable();
			dapter.Fill(data);
			return data;
		}
	}
}
