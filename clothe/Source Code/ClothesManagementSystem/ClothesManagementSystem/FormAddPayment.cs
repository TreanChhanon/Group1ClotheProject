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
    public partial class FormAddPayment : Form
    {
        OracleConnection conn = DbConnection.connect();
        private static Double totalamount;
        private static Double dis, totalprice;
        private static int totalqty2;
        public FormAddPayment(Double total1, int totalqty)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            totalamount = total1;
            totalqty2 = totalqty;
        }
        private void showdiscount()
        {
            OracleCommand cmd = new OracleCommand("DiscountMember", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "discount");
            cboDiscount.DataSource = ds.Tables["discount"];
            cboDiscount.DisplayMember = "DISCOUNT";
            cboDiscount.ValueMember = "DISCOUNT";
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
            
        }
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (txtPayment.Text == "0.00" || txtPayment.Text == "0")
            {
                MessageBox.Show("Please make a order first", "No Payment",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (Double.Parse(txtPayment.Text) < 1)
            {
                MessageBox.Show("Please make a order first", "No Payment",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to pay now'" + txtPayment.Text + "$" + "'?", "Payment?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                        try
                        {

                            conn.Open();
                            OracleCommand cmd = new OracleCommand("UpdatePaymentForOrder", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("id", UserLogin.getUserID());
                            cmd.Parameters.Add("uby", UserLogin.getUsername());
                            cmd.ExecuteNonQuery();
                            OracleCommand cmd_insert = new OracleCommand("AddPayment", conn);
                            cmd_insert.CommandType = CommandType.StoredProcedure;
                            cmd_insert.Parameters.Add("id", UserLogin.getUserID());
                            cmd_insert.Parameters.Add("total", Convert.ToDecimal(txtPayment.Text));
                            cmd_insert.Parameters.Add("ptype", cboPaymentType.Text);
                            cmd_insert.Parameters.Add("uby", UserLogin.getUsername());
                            cmd_insert.Parameters.Add("qty", totalqty2);
                            cmd_insert.ExecuteNonQuery();
                            cmd.Dispose();
                            cmd_insert.Dispose();
                            MessageBox.Show("Thank You For Your Payment ! Play Come Again ", "Payment Added",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error. " + ex.Message, "Add Payment Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close(); // close the connection
                        }
                    }

                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormInvoice fr = new FormInvoice();
            fr.Show();
        }

        private void FormAddPayment_Load(object sender, EventArgs e)
        {
            this.cboPaymentType.Items.AddRange(new object[] { "Cash", "CreditCard" });
            cboPaymentType.SelectedIndex = 0;
            txtTotalAmount.Text = totalamount.ToString("#,##0.00" + "$");
            showdiscount();
            cboPaymentType.ForeColor = Color.Blue;
            cboDiscount.ForeColor = Color.Blue;
            if (cboDiscount.Text == "")
            {
                textBox1.Visible = false;
                txtDiscountPrice.Visible = false;
                txtPayment.Text = totalamount.ToString("#,##0.00");
                lbldiscount.Visible = false;
                lbldiscountprice.Visible = false;
            }
            else
            {
                textBox1.Text = cboDiscount.Text + "%";
                Double a;
                Double b;
                a = totalamount;
                b = Convert.ToDouble(cboDiscount.Text);
                dis = a * b / 100;
                txtDiscountPrice.Text = dis.ToString("#,##0.00" + "$");
                totalprice = totalamount - (a * b / 100);
                txtPayment.Text = totalprice.ToString("#,##0.00");
            }
            cboDiscount.Visible = false;


            
        }
    }
}
