using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Configuration;

namespace oracle_project
{
    class DbConnection
    {
        // static fieild
        private static OracleConnection conn;
        // static method
        public static OracleConnection connect()
        {
            try
            {
                conn = new OracleConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["StrConn"].ToString();
               // //conn.Open();
              //  MessageBox.Show(" Connection to database is ok !");
                return conn;

            } catch(Exception exe)
            {
                MessageBox.Show("Error: " + exe.Message, " Connection Errors........", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
