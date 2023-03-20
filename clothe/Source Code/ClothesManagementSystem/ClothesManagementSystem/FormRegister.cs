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
    public partial class FormRegister : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormRegister()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

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

        private void BtnShowHide2_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                btnShowHide2.Image = Properties.Resources.eye_icon;

            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                btnShowHide2.Image = Properties.Resources.eye_icon_close;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text=="" || txtEmail.Text=="" || txtNewPassword.Text=="" ||txtPassword.Text=="" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill up the form first", "Null", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtPassword.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("Your new password doesn't match ", "Check Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                }
                else
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("registercustomer", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("name", txtFullName.Text);
                        cmd.Parameters.Add("ph", txtPhone.Text);
                        cmd.Parameters.Add("em", txtEmail.Text);
                        cmd.Parameters.Add("pass", txtPassword.Text);
                        cmd.Parameters.Add("add", txtAddress.Text);
                        cmd.Parameters.Add("cby", txtFullName.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Register Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmLogin fr = new frmLogin();
                        fr.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fail" + ex.Message, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fr = new frmLogin();
            fr.Show();
        }
    }
}
