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
    public partial class FormCustomer : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormCustomer()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext fr = new cleartext();
            fr.ClearText(this);
            dgvCustomer.ClearSelection();
        }

        private void ShowCustomer()
        {
            OracleCommand cmd = new OracleCommand("ShowCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "customer");
            dgvCustomer.DataSource = ds.Tables["customer"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void ShowMember()
        {
            OracleCommand cmd = new OracleCommand("ShowMember", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Member");
            comboMember.DataSource = ds.Tables["Member"];
            comboMember.DisplayMember = "MemberName";
            comboMember.ValueMember = "MemberID";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            ShowCustomer();
            ShowMember();
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
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    MessageBox.Show("Please Enter Customer Name!", "Required Customer Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerName.Focus();

                }
                else if (string.IsNullOrEmpty(txtJobTitle.Text))
                {
                    MessageBox.Show("Please enter customer jobtitle!", "Required jobtitle",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtJobTitle.Focus();
                }
                else if (string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Please enter Customer Phone Number!", "Required customer phone number",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Please enter Customer Email!", "Required customer email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter Customer password!", "Required customer password",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please enter Customer address!", "Required customer address",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                }
                else if (string.IsNullOrEmpty(comboMember.Text))
                {
                    MessageBox.Show("Please enter Member!", "Required Member",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboMember.Focus();
                }

                else
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd_insert = new OracleCommand("addcustomer", conn);
                        cmd_insert.CommandType = CommandType.StoredProcedure;
                        // set values for parameter
                        cmd_insert.Parameters.Add("name", txtCustomerName.Text);
                        cmd_insert.Parameters.Add("job", txtJobTitle.Text);
                        cmd_insert.Parameters.Add("ph", txtPhone.Text);
                        cmd_insert.Parameters.Add("em", txtEmail.Text);
                        cmd_insert.Parameters.Add("pass", txtPassword.Text);
                        cmd_insert.Parameters.Add("add", txtAddress.Text);
                        cmd_insert.Parameters.Add("id", comboMember.SelectedValue);
                        cmd_insert.Parameters.Add("cby", UserLogin.getUsername());

                        cmd_insert.ExecuteNonQuery();
                        ShowCustomer();
                        // change text of button
                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        //enable button update
                        btnUpdate.Enabled = true;
                        //calling the method
                        clear();
                
                        MessageBox.Show("One record has been added. ", "Customer Details Added",
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
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                btnUpdate.Enabled = true;
                btnAddNew.Text = "Add New";
                btnDelete.Text = "Delete";

            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text))
                {
                    MessageBox.Show("Please select a customer that you want to delete!", "No purchase Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete'" + txtCustomerName.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            // create command object
                            // set values for parameter of store procedure
                            OracleCommand cmd = new OracleCommand("deletecustomer", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //set values for parameters of store procedure
                            cmd.Parameters.Add("id", Convert.ToInt32(txtCustomerID.Text));
                            cmd.ExecuteNonQuery();

                            // calling the method
                            ShowCustomer();
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

        private void DgvCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtJobTitle.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            comboMember.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Please Enter Customer Name!", "Required Customer Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();

            }
            else if (string.IsNullOrEmpty(txtJobTitle.Text))
            {
                MessageBox.Show("Please enter customer jobtitle!", "Required jobtitle",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJobTitle.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter Customer Phone Number!", "Required customer phone number",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter Customer Email!", "Required customer email",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter Customer Password!", "Required customer password",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter Customer address!", "Required customer address",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(comboMember.Text))
            {
                MessageBox.Show("Please enter Member!", "Required Member",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboMember.Focus();
            }
            else
            {
                try

                {
                    //open the connection
                    conn.Open();
                    OracleCommand cmd_update = new OracleCommand("updatecustomer", conn);
                    cmd_update.CommandType = CommandType.StoredProcedure;

                    cmd_update.Parameters.Add("id", Convert.ToInt32(txtCustomerID.Text));
                    cmd_update.Parameters.Add("name", txtCustomerName.Text);
                    cmd_update.Parameters.Add("job", txtJobTitle.Text);
                    cmd_update.Parameters.Add("ph", txtPhone.Text);
                    cmd_update.Parameters.Add("em", txtEmail.Text);
                    cmd_update.Parameters.Add("pass", txtPassword.Text);
                    cmd_update.Parameters.Add("add", txtAddress.Text);
                    cmd_update.Parameters.Add("id", comboMember.SelectedValue);
                    cmd_update.Parameters.Add("uby", UserLogin.getUsername());

                    cmd_update.ExecuteNonQuery();
                    ShowCustomer();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dgvCustomer.DataSource = ds.Tables["search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
    }
}
