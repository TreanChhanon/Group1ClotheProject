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
    public partial class FormPurchase : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormPurchase()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext fr = new cleartext();
            fr.ClearText(this);
            dgvPurchase.ClearSelection();
        }
        private void ShowPurchase()
        {
            OracleCommand cmd = new OracleCommand("showadminpurchase", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "show");
            dgvPurchase.DataSource = ds.Tables["show"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }

		private void ShowEmployee()
        {
            OracleCommand cmd = new OracleCommand("showadminemployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "emp");
            comboEmployee.DataSource = ds.Tables["emp"];
            comboEmployee.DisplayMember = "EmployeeName";
            comboEmployee.ValueMember = "EmployeeID";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
 

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            ShowPurchase();
            ShowEmployee();
			

		}

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnUpdate.Enabled = false;
                btnAddNew.Text = "Save";
              
                btnDelete.Text = "Cancel";
                clear();
            }
            else if (string.IsNullOrEmpty(comboEmployee.Text))
            {
                MessageBox.Show("Please enter Employee Name!", "Employee Name cannot be null",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEmployee.Focus();

            }
            else
            {

                try
                {
                    // open the connection
                    conn.Open();

                    OracleCommand cmd_insert = new OracleCommand("Addadminpurchase", conn);
                    cmd_insert.CommandType = CommandType.StoredProcedure;
                    // set values for parameter
                    cmd_insert.Parameters.Add("empid", comboEmployee.SelectedValue);
                    cmd_insert.Parameters.Add("item", txtItem.Text);
                    cmd_insert.Parameters.Add("pdate", dateTimePicker1.Value);
                    cmd_insert.Parameters.Add("cby", UserLogin.getUsername());
                    cmd_insert.ExecuteNonQuery();
                    ShowPurchase();
                    // change text of button
                    btnAddNew.Text = "Add New";
                    btnDelete.Text = "Delete";
                    //enable button update
                    btnUpdate.Enabled = true;
                    //calling the method
                    clear();
                    MessageBox.Show("One record has been added. ", "Purchase Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex.Message, "Add Record Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // close the connection
                }
            }
        }

        private void DgvPurchase_Click(object sender, EventArgs e)
        {
            txtPurchaseID.Text = dgvPurchase.CurrentRow.Cells[0].Value.ToString();
            txtItem.Text = dgvPurchase.CurrentRow.Cells[1].Value.ToString();
            comboEmployee.Text = dgvPurchase.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dgvPurchase.CurrentRow.Cells[3].Value.ToString();
           
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboEmployee.Text))
            {
                MessageBox.Show("Please enter Employee Name!", "Employee Name cannot be null",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEmployee.Focus();

            }
            else
            {
                try

                {
                    //open the connection
                    conn.Open();
                    OracleCommand cmd_update = new OracleCommand("updatepurchase", conn);
                    cmd_update.CommandType = CommandType.StoredProcedure;

                    cmd_update.Parameters.Add("id", Convert.ToInt32(txtPurchaseID.Text));
                    cmd_update.Parameters.Add("empid", comboEmployee.SelectedValue);
                    cmd_update.Parameters.Add("item", txtItem.Text);
                    cmd_update.Parameters.Add("pdate", dateTimePicker1.Value);
                    cmd_update.Parameters.Add("uby", UserLogin.getUsername());

                    cmd_update.ExecuteNonQuery();
                    ShowPurchase();
                    clear();
                    MessageBox.Show("One Record has been updated", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Record Updated Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // close the connection
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                btnUpdate.Enabled = true;
                btnDelete.Text = "Delete";
                btnAddNew.Text = "Add New";

            }
        
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtPurchaseID.Text))
                {
                    MessageBox.Show("Please select a purchase that you want to delete!", "No purchase Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this Purchase'" + txtPurchaseID.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            // create command object
                            // set values for parameter of store procedure
                            OracleCommand cmd = new OracleCommand("deletepurchaseadmin", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //set values for parameters of store procedure
                            cmd.Parameters.Add("id", Convert.ToInt32(txtPurchaseID.Text));
                            cmd.ExecuteNonQuery();

                            // calling the method
                            ShowPurchase();
                            clear();
                            MessageBox.Show("One Reccord has Been Deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error." + ex.Message, "Delete Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            conn.Close(); // close the connection
                        }

                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("searchadminpurchase", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dgvPurchase.DataSource = ds.Tables["search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
    }
}
