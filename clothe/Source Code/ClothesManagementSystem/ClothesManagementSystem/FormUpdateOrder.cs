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
    public partial class FormUpdateOrder : Form
    {
        OracleConnection conn = DbConnection.connect();
        int id2, qty2;
        String color2, size2;
        int price2;
    
        private double c;
        private double d;
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id2.ToString()))
            {
                MessageBox.Show("No ID Found!", "No item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(string.IsNullOrEmpty(txtQty.Text))                                                                                                          
            {
                MessageBox.Show("Please Add Qty!", "No item Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtQty.Text =="0")
            {
                MessageBox.Show("Please Add Qty!", "No item Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                    try
                    {
                        conn.Open();
                    // create command object
                    // set values for parameter of store procedure
                    Double total;
                    c = Double.Parse(txtForPrice.Text);
                    d = Double.Parse(txtQty.Text);
                    total = c * d;
                    OracleCommand cmd = new OracleCommand("UpdateOrders", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //set values for parameters of store procedure
                        cmd.Parameters.Add("id", id2);
                        cmd.Parameters.Add("color", colorCombo.Text);
                        cmd.Parameters.Add("siz", sizeCombo.Text); 
                    cmd.Parameters.Add("qty", Convert.ToInt32(txtQty.Text));
                    cmd.Parameters.Add("total", total);
                    cmd.Parameters.Add("uby", UserLogin.getUsername());
                       cmd.ExecuteNonQuery();
					
					MessageBox.Show("One Item has Been Updated.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();



				}
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error." + ex.Message, "Updeted Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        conn.Close(); // close the connection
                    }

                
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {   
            
            qty2 = qty2 + 1;
            txtQty.Text = qty2.ToString();
            c = Double.Parse(txtForPrice.Text);
            d = Double.Parse(txtQty.Text);
            txtTotalPrice.Text = (c * d).ToString("#,##0.00" + "$");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQty.Text) <= 0)
            {
                MessageBox.Show("No Available !", "Fail", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                --qty2;
                txtQty.Text = qty2.ToString();
                c = Double.Parse(txtForPrice.Text);
                d = Double.Parse(txtQty.Text);
                txtTotalPrice.Text = (c * d).ToString("#,##0.00" + "$");
                txtTotalPrice.Visible = true;
                lblTotal.Visible = true;
            }
        }

        private void FormUpdateOrder_Load(object sender, EventArgs e)
        {

            txtQty.Text = qty2.ToString();
            
            txtForPrice.Text = price2.ToString();
            this.colorCombo.Items.AddRange(new object[] {
                color2,
                "Black", 
                "White",
                "Pink",
                "Blue",
                "Purple"
            });
            this.sizeCombo.Items.AddRange(new object[] { size2, "S", "XL", "XXL", "XS" });
            colorCombo.SelectedIndex = 0;
            sizeCombo.SelectedIndex = 0;
            c = Double.Parse(txtForPrice.Text);
            d = Double.Parse(txtQty.Text);
            txtTotalPrice.Text = (c * d).ToString("#,##0.00" + "$");
        }

        public FormUpdateOrder(int id,String color, String size, int qty, int price)
        {
            InitializeComponent();
            id2 = id;
            qty2 = qty;
            color2 = color;
            size2 = size;
            price2 = price;
        }
    }
}
