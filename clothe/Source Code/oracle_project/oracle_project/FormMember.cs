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

    public partial class FormMember : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormMember()
        {
            InitializeComponent();
        }

        private void clear()
        {
            cleartext clear = new cleartext();
            clear.ClearText(this);
            dgvMember.ClearSelection();
           
        }
        public void ShowMember()
        {
            OracleCommand cmd = new OracleCommand("ShowMember", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Member");
            dgvMember.DataSource = ds.Tables["Member"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();

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
                if (string.IsNullOrEmpty(txtMemberName.Text))
                {
                    MessageBox.Show("Please enter member Name!", "Required member Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMemberName.Focus();

                }
                else if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    MessageBox.Show("Please enter discount!", "Required dicount value",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiscount.Focus();
                }

                else
                {
                    try
                    {
                        
                        conn.Open();
                        OracleCommand cmd_insert = new OracleCommand("AddMember", conn);
                        cmd_insert.CommandType = CommandType.StoredProcedure;
                        // set values for parameter
                        cmd_insert.Parameters.Add("name", txtMemberName.Text);
                        cmd_insert.Parameters.Add("dis", Convert.ToInt32(txtDiscount.Text));
                        cmd_insert.Parameters.Add("cby", "Sakavy");
                        cmd_insert.ExecuteNonQuery();
                        ShowMember();
                        // change text of button
                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        //enable button update
                        btnUpdate.Enabled = true;
                        //calling the method
                        clear();
                        dgvMember.ClearSelection();
                        MessageBox.Show("One record has been added. ", "Member Details Added",
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show("Please Enter Member Name!", "Required Member Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMemberName.Focus();

            }
            else if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("Please enter Discount %!", "Required discount %",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Focus();
            }
            else
            {
                try

                {
                    //open the connection
                    conn.Open();

                    OracleCommand cmd_update = new OracleCommand("UpdateMember", conn);
                    cmd_update.CommandType = CommandType.StoredProcedure;

                    cmd_update.Parameters.Add("id", Convert.ToInt32(txtMemberID.Text));
                    cmd_update.Parameters.Add("name", txtMemberName.Text);
                    cmd_update.Parameters.Add("dis", Convert.ToInt32(txtDiscount.Text));
                    cmd_update.Parameters.Add("uby", "Sakavy");

                    cmd_update.ExecuteNonQuery();
                    ShowMember();
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

        private void DgvMember_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
            txtMemberName.Text = dgvMember.CurrentRow.Cells[1].Value.ToString();
            txtDiscount.Text = dgvMember.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                btnDelete.Text = "Delete";
                btnAddNew.Text = "Add New";
                btnUpdate.Enabled = true;

            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtMemberName.Text))
                {
                    MessageBox.Show("Please select a Member that you want to delete!", "No purchase Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete'" + txtMemberName.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            // create command object
                            // set values for parameter of store procedure
                            OracleCommand cmd = new OracleCommand("deletemember", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //set values for parameters of store procedure
                            cmd.Parameters.Add("id", Convert.ToInt32(txtMemberID.Text));
                            cmd.ExecuteNonQuery();

                            // calling the method
                            ShowMember();
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

        private void FormMember_Load(object sender, EventArgs e)
        {
            ShowMember();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchMember", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name",  txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dgvMember.DataSource = ds.Tables["search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
    }
}







