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
    public partial class FormLogin : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }



        private void BtnShowhidepassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowhidepassword.Image = Properties.Resources.eye_icon;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowhidepassword.Image = Properties.Resources.eye_icon_close;
            }
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("userName is Required!", "Missing UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_select = "SELECT * FROM tblEmployees WHERE UserName='" + txtUsername.Text.Trim() + "' AND Password='" + txtPassword.Text.Trim() + "'";
                    //create data adapter object
                    OracleDataAdapter adapter = new OracleDataAdapter(sql_select, conn);
                    //create data table object
                    DataTable dt = new DataTable();

                    //fill data in dt
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        //show user login info
                        //calling the static method: class_name.static_method_name([parameter_list]);
                        UserLogin.setUserID(dt.Rows[0]["EmployeeID"].ToString());
                        UserLogin.setUsername(dt.Rows[0]["UserName"].ToString());
                        UserLogin.setUserPassword(dt.Rows[0]["Password"].ToString());
                        UserLogin.setUserType(dt.Rows[0]["UserType"].ToString());
                        MainForm frm = new MainForm(); //show main form
                        this.Hide(); // Hide Login Form
                        frm.Show(); // show main form
                    }
                    else
                    {
                        MessageBox.Show("Fail to login the user.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
