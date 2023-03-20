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

namespace ClothesManagementSystem
{
    public partial class frmLogin : Form
    {
        OracleConnection conn = DbConnection.connect();
        public frmLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        int count = 0;

        private int imageNumber = 1;
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }


        private void BtnShowhidepassword_Click_1(object sender, EventArgs e)

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("User is Required!", "Missing UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is Required", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                if(txtUsername.Text == "admin" || txtUsername.Text == "ADMIN" || txtUsername.Text=="Admin")
                {
                    try
                    {
                        conn.Open();
                        //string sql_select = "SELECT * FROM tblEmployees WHERE UserName='" + txtUsername.Text.Trim() + "' AND Password='" + txtPassword.Text.Trim() + "'";
                        //create data adapter object
                        // OracleDataAdapter adapter = new OracleDataAdapter(sql_select, conn);
                        //create data table object
                        OracleCommand cmd = new OracleCommand("Login", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("name", txtUsername.Text.Trim());
                        cmd.Parameters.Add("pass", txtPassword.Text.Trim());

                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
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
                            count++;
                            MessageBox.Show("Fail to login the user.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (count == 3)
                            {
                                MessageBox.Show("Fail to login the user Please try again later.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
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
                else
                {
                    try
                    {
                        conn.Open();
                        //string sql_select = "SELECT * FROM tblEmployees WHERE UserName='" + txtUsername.Text.Trim() + "' AND Password='" + txtPassword.Text.Trim() + "'";
                        //create data adapter object
                        // OracleDataAdapter adapter = new OracleDataAdapter(sql_select, conn);
                        //create data table object
                        OracleCommand cmd = new OracleCommand("CustomerLogin", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("name", txtUsername.Text.Trim());
                        cmd.Parameters.Add("pass", txtPassword.Text.Trim());
                       

                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        //fill data in dt
                        adapter.Fill(dt);
                        
                        if (dt.Rows.Count == 1)
                        {        
                            //show user login info
                            //calling the static method: class_name.static_method_name([parameter_list]);
                            UserLogin.setUserID(dt.Rows[0]["CustomerID"].ToString());
                            UserLogin.setUserEmail(dt.Rows[0]["Email"].ToString());
                            UserLogin.setUsername(dt.Rows[0]["CustomerName"].ToString());
                            UserLogin.setUserPassword(dt.Rows[0]["Password"].ToString());
                            UserLogin.setUserPhone(dt.Rows[0]["Phone"].ToString());
                            MainForm frm = new MainForm(); //show main form
                            this.Hide(); // Hide Login Form
                            frm.Show(); // show main form
                        }
                        else
                        {
                            count++;
                            MessageBox.Show("Fail to login the user.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (count == 3)
                            {
                                MessageBox.Show("Fail to login the user Please try again later.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
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
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void LoadNextImage()
        {
            if (imageNumber == 8)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister fr = new FormRegister();
            fr.Show();
        }
    }
}
