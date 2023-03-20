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
    public partial class FormRestoreProduct : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormRestoreProduct()
        {
            InitializeComponent();
        }


        private void ShowProduct()
        {
            OracleCommand cmd = new OracleCommand("ShowRestoreProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Product");
            dgvProduct.RowTemplate.Height = 75;
            dgvProduct.DataSource = ds.Tables["Product"];
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dgvProduct.Columns[12];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }
        private void FormRestoreProduct_Load(object sender, EventArgs e)
        {
            ShowProduct();
        }

        private void DgvProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try

            {
                conn.Open();
                // create command object
                // set values for parameter of store procedure
                OracleCommand cmd = new OracleCommand("RestoreProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //set values for parameters of store procedure

                cmd.Parameters.Add("ID", dgvProduct.CurrentRow.Cells[0].Value.ToString());
           
                cmd.ExecuteNonQuery();
                // calling the method
                ShowProduct();
                MessageBox.Show("One Reccord has Been Restore.", "Record Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex.Message, "Restore Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close(); // close the connection
            }
        }

        private void BtnRestoreAll_Click(object sender, EventArgs e)
        {
            try

            {
                conn.Open();
                // create command object
                // set values for parameter of store procedure
                OracleCommand cmd_restore = new OracleCommand("RestoreAllProduct", conn);
                cmd_restore.CommandType = CommandType.StoredProcedure;
                //set values for parameters of store procedure
                cmd_restore.ExecuteNonQuery();
                // calling the method
                ShowProduct();
                MessageBox.Show("All Reccord has Been Restore.", "All Record Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex.Message, "All Records Restore Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close(); // close the connection
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
