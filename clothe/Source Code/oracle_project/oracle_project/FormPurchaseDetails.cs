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
    public partial class FormPurchaseDetails : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormPurchaseDetails()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext fr = new cleartext();
            fr.ClearText(this);
            dgvDetails.ClearSelection();
        }
        private void ShowPurchaseDetails()
        {
            OracleCommand cmd = new OracleCommand("ShowPurchaseDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "show");
            dgvDetails.DataSource = ds.Tables["show"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void ShowPurchase()
        {
            OracleCommand cmd = new OracleCommand("ShowPurchases", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ShowPurchase");
            comboPurchase.DataSource = ds.Tables["ShowPurchase"];
            comboPurchase.DisplayMember = "PurchaseID";
            comboPurchase.ValueMember = "PurchaseID";
            cboItemNamePurchase.DataSource = ds.Tables["ShowPurchase"];
            cboItemNamePurchase.DisplayMember = "ItemName";
            cboItemNamePurchase.ValueMember = "PurchaseID";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void ShowProduct()
        {
            OracleCommand cmd = new OracleCommand("ShowProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "product");
            comboProduct.DataSource = ds.Tables["product"];
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductID";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void FormPurchaseDetails_Load(object sender, EventArgs e)
        {
            ShowPurchaseDetails();
            ShowPurchase();
            ShowProduct();
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
                if (string.IsNullOrEmpty(comboPurchase.Text))
                {
                    MessageBox.Show("Please Select Purchase Name!", "Required Purchase Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboPurchase.Focus();

                }
                else if (string.IsNullOrEmpty(comboProduct.Text))
                {
                    MessageBox.Show("Please Select Product Name!", "Required Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboProduct.Focus();
                }
                else if (string.IsNullOrEmpty(txtQtyPurchase.Text))
                {
                    MessageBox.Show("Please enter Quantity!", "Required Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQtyPurchase.Focus();
                }

                else
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd_insert = new OracleCommand("AddPurchaseDetails", conn);
                        cmd_insert.CommandType = CommandType.StoredProcedure;
                        // set values for parameter
                        cmd_insert.Parameters.Add("id", comboPurchase.SelectedValue);
                        cmd_insert.Parameters.Add("pid", comboProduct.SelectedValue);
                        cmd_insert.Parameters.Add("qty", Convert.ToInt32(txtQtyPurchase.Text));
                        cmd_insert.Parameters.Add("cby", UserLogin.getUsername());

                        cmd_insert.ExecuteNonQuery();
                        ShowPurchaseDetails();
                        // change text of button
                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        //enable button update
                        btnUpdate.Enabled = true;
                        //calling the method
                        clear();
                        MessageBox.Show("One record has been added. ", "Purchase Details Added",
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
            if (string.IsNullOrEmpty(comboPurchase.Text))
            {
                MessageBox.Show("Please Select Purchase Name!", "Required Purchase Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboPurchase.Focus();

            }
            else if (string.IsNullOrEmpty(comboProduct.Text))
            {
                MessageBox.Show("Please Select Product Name!", "Required Product",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboProduct.Focus();
            }
            else if (string.IsNullOrEmpty(txtQtyPurchase.Text))
            {
                MessageBox.Show("Please enter Quantity!", "Required Quantity",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtyPurchase.Focus();
            }
            else
            {
                try

                {
                    //open the connection
                    conn.Open();
                    OracleCommand cmd_update = new OracleCommand("UpdatePurchaseDetails", conn);
                    cmd_update.CommandType = CommandType.StoredProcedure;
                    cmd_update.Parameters.Add("id", comboPurchase.SelectedValue);
                    cmd_update.Parameters.Add("pid", comboProduct.SelectedValue);
                    cmd_update.Parameters.Add("qty", Convert.ToInt32(txtQtyPurchase.Text));
                    cmd_update.Parameters.Add("uby", UserLogin.getUsername());
                    cmd_update.ExecuteNonQuery();
                    ShowPurchaseDetails();
                    clear();
                    comboPurchase.Enabled = true;
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

        private void DgvDetails_Click(object sender, EventArgs e)
        {

            comboPurchase.Text = dgvDetails.CurrentRow.Cells[0].Value.ToString();
            comboProduct.Text = dgvDetails.CurrentRow.Cells[1].Value.ToString();
            txtQtyPurchase.Text = dgvDetails.CurrentRow.Cells[2].Value.ToString();
            comboPurchase.Enabled = false;
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
                if (string.IsNullOrEmpty(comboPurchase.Text))
                {
                    MessageBox.Show("Please select a Member that you want to delete!", "No purchase Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete'" + comboPurchase.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            // create command object
                            // set values for parameter of store procedure
                            OracleCommand cmd = new OracleCommand("deletepurchasedetails", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //set values for parameters of store procedure
                            cmd.Parameters.Add("id", comboPurchase.SelectedValue);
                            cmd.ExecuteNonQuery();

                            // calling the method
                            ShowPurchaseDetails();
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchPurchaseDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dgvDetails.DataSource = ds.Tables["search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
    }
}
