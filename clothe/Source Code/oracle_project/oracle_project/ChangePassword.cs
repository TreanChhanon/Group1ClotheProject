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
    public partial class ChangePassword : Form
    {
        OracleConnection conn = DbConnection.connect();
        public ChangePassword()
        {
            InitializeComponent();
        }

 
        private void btnOldPassword_Click(object sender, EventArgs e)
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

        private void btnNewPassword_Click(object sender, EventArgs e)
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

        private void btnConfirmedPassword_Click(object sender, EventArgs e)
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

        private void btnChangePassword_Click(object sender, EventArgs e)
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
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("ChangePasswordEmployee", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("uname", UserLogin.getUsername());
                            cmd.Parameters.Add("pass", txtNewPassword.Text);
                            cmd.ExecuteNonQuery();
                            txtNewPassword.Clear();
                            txtOldPassword.Clear();
                            txtConfirmedNewPassword.Clear();
                            MessageBox.Show("Change Password Successful!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
