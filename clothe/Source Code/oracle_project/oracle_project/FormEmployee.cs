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
using System.IO;

namespace oracle_project
{
    public partial class FormEmployee : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormEmployee()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext clear = new cleartext();
            clear.ClearText(this);
            empProductImage.Image = Properties.Resources.No_Image_Available;
        }
        private void ShowEmployee()
        {
            OracleCommand cmd = new OracleCommand("ShowEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Employee");
            datagridEmployee.RowTemplate.Height = 75;
            datagridEmployee.DataSource = ds.Tables["Employee"];
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)datagridEmployee.Columns[14];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            datagridEmployee.Columns[15].Visible = false;
            datagridEmployee.Columns[3].Visible= false;
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            ShowEmployee();
            datagridEmployee.ClearSelection();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnUpdate.Enabled = false;
                btnAddNew.Text = "Save";
         
                btnDelete.Text = "Cancel";
                clear();

                empProductImage.Image = Properties.Resources.No_Image_Available;
                datagridEmployee.ClearSelection();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtEmployeeName.Text))
                {
                    MessageBox.Show("Please enter Employee Name!", "Required Employee Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeName.Focus();

                }
                else if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Please enter Username!", "Required User Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter password Name!", "Required Password ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else if (string.IsNullOrEmpty(txtUserType.Text))
                {
                    MessageBox.Show("Please enter user type!", "Required user type",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserType.Focus();
                }
                else if (string.IsNullOrEmpty(txtRole.Text))
                {
                    MessageBox.Show("Please enter Phone Role Name!", "Required Phone",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRole.Focus();
                }
                else if (string.IsNullOrEmpty(txtJobTitle.Text))
                {
                    MessageBox.Show("Please enter JobTitle Name!", "Required JobTitle Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtJobTitle.Focus();
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Please enter Email!", "Required Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Please enter Phone!", "Required Phone",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please enter HomePhone!", "Required HomePhone",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                }
           
       

                else
                {
                    try
                    {
                        // open the connection
                        conn.Open();

                        MemoryStream ms = new MemoryStream();
                        empProductImage.Image.Save(ms, empProductImage.Image.RawFormat);

                        //create command object
                        OracleCommand cmd = new OracleCommand("AddEmployees", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        // set values for parameter
                        cmd.Parameters.Add("ENAME", txtEmployeeName.Text);
                        cmd.Parameters.Add("UNAME", txtUserName.Text);
                        cmd.Parameters.Add("PASSWORD", txtPassword.Text);
                        cmd.Parameters.Add("utype", txtUserType.Text);
                        cmd.Parameters.Add("role", txtRole.Text);
                        cmd.Parameters.Add("title", txtJobTitle.Text);
                        cmd.Parameters.Add("email", txtEmail.Text);
                        cmd.Parameters.Add("phone", txtPhone.Text);
                   
                        cmd.Parameters.Add("address", txtAddress.Text);
                  
                        cmd.Parameters.Add("CREATEBY", UserLogin.getUsername());
                        cmd.Parameters.Add("IMG", OracleDbType.Blob).Value = ms.ToArray();

                        cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        ShowEmployee();
                        // change text of button
                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        //enable button update
                        btnUpdate.Enabled = true;
                        //calling the method
                        clear();
                        MessageBox.Show("One record has been added. ", "Employee Added",
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
            else
            {
                if (MessageBox.Show("Are you sure you want to delete'" + txtEmployeeName.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        // create command object
                        // set values for parameter of store procedure
                        OracleCommand cmd = new OracleCommand("DeleteEmployee", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //set values for parameters of store procedure
                        cmd.Parameters.Add("ID", Convert.ToInt32(txtEmployeeID.Text));
                        cmd.ExecuteNonQuery();

                        // calling the method
                        ShowEmployee();
                        MessageBox.Show("One Reccord has Been Deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();

                        datagridEmployee.ClearSelection();
                       
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

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image| *.png; *.jpg; * .png; * .bmp; ";
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                empProductImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void DatagridEmployee_Click(object sender, EventArgs e)
        {

            byte[] data = (byte[])datagridEmployee.CurrentRow.Cells[14].Value;
            MemoryStream ms = new MemoryStream(data);
            empProductImage.Image = Image.FromStream(ms);
            txtEmployeeID.Text = datagridEmployee.CurrentRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = datagridEmployee.CurrentRow.Cells[1].Value.ToString();
            txtUserName.Text = datagridEmployee.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = datagridEmployee.CurrentRow.Cells[3].Value.ToString();
            txtUserType.Text = datagridEmployee.CurrentRow.Cells[4].Value.ToString();
            txtRole.Text = datagridEmployee.CurrentRow.Cells[5].Value.ToString();
            txtJobTitle.Text = datagridEmployee.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = datagridEmployee.CurrentRow.Cells[7].Value.ToString();
            txtPhone.Text = datagridEmployee.CurrentRow.Cells[8].Value.ToString();
      
            txtAddress.Text = datagridEmployee.CurrentRow.Cells[9].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                MessageBox.Show("Employee Name cannot be null !", "Employee Name Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeName.Focus();

            }
            else if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("User Name cannot be null !", "UserName Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();

            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be null !", "Password Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();

            }
            else if (string.IsNullOrEmpty(txtUserType.Text))
            {
                MessageBox.Show("UserType cannot be null !", "UserType Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserType.Focus();

            }
            else if (string.IsNullOrEmpty(txtRole.Text))
            {
                MessageBox.Show("Role cannot be null !", "Role Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRole.Focus();

            }
            else if (string.IsNullOrEmpty(txtJobTitle.Text))
            {
                MessageBox.Show("JobTitle cannot be null !", "JobTitle Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJobTitle.Focus();

            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email cannot be null !", "Email Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();

            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be null !", "Phone Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();

            }
          
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("address cannot be null !", "address Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();

            }
         
            else
            {
                try

                {
                    //open the connection
                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    empProductImage.Image.Save(ms, empProductImage.Image.RawFormat);

                    //create command object
                    OracleCommand cmd = new OracleCommand("UpdateEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // set values for parameter
                    cmd.Parameters.Add("ID", int.Parse(txtEmployeeID.Text));
                    cmd.Parameters.Add("ENAME", txtEmployeeName.Text);
                    cmd.Parameters.Add("UNAME", txtUserName.Text);
                    cmd.Parameters.Add("PASSWORD", txtPassword.Text);
                    cmd.Parameters.Add("utype", txtUserType.Text);
                    cmd.Parameters.Add("role", txtRole.Text);
                    cmd.Parameters.Add("title", txtJobTitle.Text);
                    cmd.Parameters.Add("email", txtEmail.Text);
                    cmd.Parameters.Add("phone", txtPhone.Text);
       
                    cmd.Parameters.Add("address", txtAddress.Text);
                 
                    cmd.Parameters.Add("UPDATEBY", UserLogin.getUsername());
                    cmd.Parameters.Add("IMG", OracleDbType.Blob).Value = ms.ToArray();

                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    ShowEmployee();
                    // change text of button
                    btnAddNew.Text = "Add New";
                    btnDelete.Text = "Delete";
                    //enable button update
                    btnUpdate.Enabled = true;
                    //calling the method
                    clear();
                    MessageBox.Show("One record has been added. ", "Employee Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchEMployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            datagridEmployee.DataSource = ds.Tables["search"];
            ds.Dispose();
            adapter.Dispose();
          /*  
            OracleCommand cmd = new OracleCommand("search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
    
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            datagridEmployee.DataSource = ds.Tables["search"];
            adapter.Dispose();
            cmd.Dispose();
            ds.Dispose();
          */
           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtJobTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
