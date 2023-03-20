using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace oracle_project
{
    public partial class frmCategory : Form
    {
        OracleConnection conn = DbConnection.connect();
        public frmCategory()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext clear = new cleartext();
            clear.ClearText(this);
        }
        public void showCategory()
        {
            OracleCommand cmd = new OracleCommand("showCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"category");
            dataGridView1.DataSource = ds.Tables["category"];
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
                
               txtCategoryID.Clear();
                txtCategoryName.Clear();
                txtDescription.Clear();
                txtCategoryName.Focus();
              
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Please Enter Category Name", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoryName.Focus();
                    return;
                }
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("AddCategory", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("VCATENAME", txtCategoryName.Text);
                    cmd.Parameters.Add("VDESC", txtDescription.Text);
                    cmd.Parameters.Add("VCREATEBY", "Sakavy");
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    btnAddNew.Text = "Add New";
                    btnDelete.Text = "Delete";
                    txtCategoryID.Clear();
                    txtCategoryName.Clear();
                    txtDescription.Clear();
                    txtCategoryName.Focus();
                    btnUpdate.Enabled = true;
                    showCategory();
                    MessageBox.Show("One Record Has Been Add", "Record Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Errors.....",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
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
                if (string.IsNullOrEmpty(txtCategoryID.Text))
                {
                    MessageBox.Show("Please select a Category that you want to delete!", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delte'" + txtCategoryName.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();

                            OracleCommand cmd = new OracleCommand("DeleteCategory", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("ID", Convert.ToInt32(txtCategoryID.Text));

                            cmd.ExecuteNonQuery();

                            // calling the method
                            showCategory();
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

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            showCategory();
            dataGridView1.ClearSelection();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Category Name cannot be null !", "Category Name Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Focus();

            }
            else
            {
                try
                {
         
                    OracleCommand cmd = new OracleCommand("UpdateCategory", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("DID", Convert.ToInt32(txtCategoryID.Text));
                    cmd.Parameters.Add("VCATENAME", txtCategoryName.Text);
                 
                    cmd.Parameters.Add("VDESC", txtDescription.Text);

                    cmd.Parameters.Add("UPDATEDBY", "Sakavy");
          

                    //open the connection
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    // Calling the method

                    showCategory();
                    dataGridView1.ClearSelection();
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

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
           OracleCommand cmd = new OracleCommand("SearchCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dataGridView1.DataSource = ds.Tables["search"];
            ds.Dispose();
            adapter.Dispose();
        }
    }
}

