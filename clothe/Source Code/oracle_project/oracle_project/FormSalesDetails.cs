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
    public partial class FormSalesDetails : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormSalesDetails()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext fr = new cleartext();
            fr.ClearText(this);
            dgvSalesDetails.ClearSelection();
        }
        private void ShowSalesDetails()
        {
            OracleCommand cmd = new OracleCommand("ShowSalesDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "details");
            dgvSalesDetails.DataSource = ds.Tables["details"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void ShowSalesID()
        {
            OracleCommand cmd = new OracleCommand("showsaleid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "showsaleid");
            comboSale.DataSource = ds.Tables["showsaleid"];
            comboSale.DisplayMember = "OrderID";
            comboSale.ValueMember = "ORDERID";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
        private void ShowCompboProduct()
        {
            OracleCommand cmd = new OracleCommand("ShowCompboProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ShowCompboProduct");
            comboProduct.DataSource = ds.Tables["ShowCompboProduct"];
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductID"; 
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose(); 
        }

        private void FormSalesDetails_Load(object sender, EventArgs e)
        {
            ShowCompboProduct();
            ShowSalesDetails();
            ShowSalesID();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnUpdate.Enabled = false;
                btnAddNew.Text = "Save";
             
                btnDelete.Text = "Cancel";
                
                comboSale.Enabled = true;
                clear();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(comboSale.Text))
                {
                    MessageBox.Show("Please Select Date!", "Required Employee Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboSale.Focus();

                }
                else if (string.IsNullOrEmpty(comboProduct.Text))
                {
                    MessageBox.Show("Please Select Product name !", "Required Product name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboProduct.Focus();
                }
                else if (string.IsNullOrEmpty(txtQtySale.Text))
                {
                    MessageBox.Show("Please Enter Quantity Sales !", "Required Quantity Sales",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQtySale.Focus();
                }
                else
                {
                    try
                    {
                        
                        conn.Open();
                        OracleCommand cmd_insert = new OracleCommand("addsalesdetails", conn);
                        cmd_insert.CommandType = CommandType.StoredProcedure;
                        // set values for parameter
                        cmd_insert.Parameters.Add("sid", comboSale.SelectedValue);
                        cmd_insert.Parameters.Add("pid", comboProduct.SelectedValue);
                        cmd_insert.Parameters.Add("qty", Convert.ToInt32(txtQtySale.Text));
                        cmd_insert.Parameters.Add("cby", UserLogin.getUsername());

                        cmd_insert.ExecuteNonQuery();
                        ShowSalesDetails();
                        // change text of button
                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        //enable button update
                        btnUpdate.Enabled = true;
                        //calling the method
                        clear();
                       
                        MessageBox.Show("One record has been added. ", "Sales Details Added",
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

        private void DgvSalesDetails_Click(object sender, EventArgs e)
        {
            comboSale.Text = dgvSalesDetails.CurrentRow.Cells[0].Value.ToString();
            comboProduct.Text = dgvSalesDetails.CurrentRow.Cells[1].Value.ToString();
            txtQtySale.Text = dgvSalesDetails.CurrentRow.Cells[2].Value.ToString();
            comboSale.Enabled = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboSale.Text))
            {
                MessageBox.Show("Please Select Sale Date !", "Required Sale Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboSale.Focus();

            }
            else if (string.IsNullOrEmpty(comboProduct.Text))
            {
                MessageBox.Show("Please Select Product Name!", "Required Product name",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboProduct.Focus();
            }
            else if (string.IsNullOrEmpty(txtQtySale.Text))
            {
                MessageBox.Show("Please Enter Sale Quantity!", "Required Sale Quantity",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtySale.Focus();
            }
            else
            {
                try

                { 
                    //open the connection
                    conn.Open();
                    OracleCommand cmd_update = new OracleCommand("updatesalesdetails", conn);
                    cmd_update.CommandType = CommandType.StoredProcedure;
                    cmd_update.Parameters.Add("sid", comboSale.SelectedValue);
                    cmd_update.Parameters.Add("pid", comboProduct.SelectedValue);
                    cmd_update.Parameters.Add("qty", Convert.ToInt32(txtQtySale.Text));
                    cmd_update.Parameters.Add("uby", UserLogin.getUsername());

                    cmd_update.ExecuteNonQuery();
                    ShowSalesDetails();
                    comboSale.Enabled = true;
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
                btnAddNew.Text = "Add New";
              
                btnDelete.Text = "Delete";

            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(comboSale.Text))
                {
                    MessageBox.Show("Please select a sale that you want to delete!", "No sale Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete'" + " This Sale Record  " + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            
                            conn.Open();
                            // create command object
                            // set values for parameter of store procedure
                            OracleCommand cmd = new OracleCommand("DeleteSalesDetails", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //set values for parameters of store procedure
                            cmd.Parameters.Add("id", comboSale.SelectedValue);
                            cmd.ExecuteNonQuery();

                            // calling the method
                            ShowSalesDetails();
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
            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchSalesDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dgvSalesDetails.DataSource = ds.Tables["search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
    }
}
