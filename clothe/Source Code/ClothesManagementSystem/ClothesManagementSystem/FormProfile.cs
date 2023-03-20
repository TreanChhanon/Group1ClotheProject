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
    public partial class FormProfile : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormProfile()
        {
            InitializeComponent();
        }

        private void BtnOldPassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.UseSystemPasswordChar == true)
            {

                txtOldPassword.UseSystemPasswordChar = false;
                btnOldPassword.Image = Properties.Resources.eye_icon;
            }
            else
            {
                txtOldPassword.UseSystemPasswordChar = true;
                btnOldPassword.Image = Properties.Resources.eye_icon_close;
            }
        }

        private void BtnNewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == true)
            {

                txtNewPassword.UseSystemPasswordChar = false;
                btnNewPassword.Image = Properties.Resources.eye_icon;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                btnNewPassword.Image = Properties.Resources.eye_icon_close;
            }
        }

        private void BtnConfirmedPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmedNewPassword.UseSystemPasswordChar == true)
            {

                txtConfirmedNewPassword.UseSystemPasswordChar = false;
                btnConfirmedPassword.Image = Properties.Resources.eye_icon;
            }
            else
            {
                txtConfirmedNewPassword.UseSystemPasswordChar = true;
                btnConfirmedPassword.Image = Properties.Resources.eye_icon_close;
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Please input your old password!", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Focus();
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please input your new password!", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
            }
            else if (txtConfirmedNewPassword.Text == "")
            {
                MessageBox.Show("Please input your new confirmed password!", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmedNewPassword.Focus();
            }
            else
            {
                if (txtOldPassword.Text == UserLogin.getUserPassword())
                {
                    if (txtOldPassword.Text != txtNewPassword.Text)
                    {
                        if (txtNewPassword.Text == txtConfirmedNewPassword.Text)
                        {
                            try
                            {
                                conn.Open();
                                OracleCommand cmd = new OracleCommand("ChangePassword", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("uname", UserLogin.getUserEmail());
                                cmd.Parameters.Add("pass", txtNewPassword.Text);
                                cmd.ExecuteNonQuery();
                                txtNewPassword.Clear();
                                txtOldPassword.Clear();
                                txtConfirmedNewPassword.Clear();
                                cmd.Dispose();
                                MessageBox.Show("Change Password Successful! Please Logout First !", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Change Password Error" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Sorry New Password Is not Correct", "NewPassword Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry New Password Cannot Be the Same as Old Password !", "Change Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry Old Password Is not Correct !", "Change Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
           
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            txtName.Text = Convert.ToString(UserLogin.getUsername());
            txtEmail.Text = Convert.ToString(UserLogin.getUserEmail());
            txtPhone.Text = Convert.ToString(UserLogin.getUserPhone());
        }

        private void BtnChangeProfile_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please input your new name", "Name is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please input your new email", "Email is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Please input your new phone", "Phone number is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
            }
            else if(txtName.Text == Convert.ToString(UserLogin.getUsername()) && txtEmail.Text == Convert.ToString(UserLogin.getUserEmail()) && txtPhone.Text == Convert.ToString(UserLogin.getUserPhone()))
            {
                MessageBox.Show("Please input your new name email and phone", "New information is need", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }

            else
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("changeprofile", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("id", UserLogin.getUserID());
                    cmd.Parameters.Add("name", txtName.Text);
                    cmd.Parameters.Add("em", txtEmail.Text);
                    cmd.Parameters.Add("ph", txtPhone.Text);
                    cmd.Parameters.Add("uby", UserLogin.getUsername());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your profile has Been Updated. Please Log Out First !", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Change Profile Error" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
