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

namespace ClothesManagementSystem
{
    public partial class FormWoman : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormWoman()
        {
            InitializeComponent();
        }
        private double c;
        private double d;
        private static int a= 0;
        private static int qtyauto = 1;
        private void ShowAllProduct()
        {
            OracleCommand cmd = new OracleCommand("ShowAllProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "all");
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.DataSource = ds.Tables["all"];
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }

        private void clearall()
        {
            txtSearch.Clear();
            txtTotalPrice.Clear();
            txtQty.Text = "0";
            a = 0;
            dataGridView1.ClearSelection();
            lblTotal.Visible = false;
            txtTotalPrice.Visible = false;

        }
        private void FormWoman_Load(object sender, EventArgs e)
        {
            ShowAllProduct();
            dataGridView1.ClearSelection();
            lblPrice.Visible = false;
            txtQty.Text = "0";
            lblQuantity.Visible = false;
            txtForPrice.Visible = false;
            lblTotal.Visible = false;
            txtTotalPrice.Visible = false;
            colorCombo.Visible = false;
            sizeCombo.Visible = false;
            lblColor.Visible = false;
            lblSize.Visible = false;
            btnMinus.Visible = false;
            btnPlus.Visible = false;
            txtQty.Visible = false;
            showcombo();
            btnClear.Visible = false;
            if(UserLogin.getUsername() == "admin" || UserLogin.getUsername() == "Admin" || UserLogin.getUsername() == "Admin")
            {
                btnShoppingBasket.Visible = false;
                btnAddCart.Visible = false;
            }
        }

        private void showcombo()
        {
            this.colorCombo.Items.AddRange(new object[] { "Black", "White", "Pink", "Blue", "Purple" });
            this.sizeCombo.Items.AddRange(new object[] { "S", "XL", "XXL", "XS" });
            colorCombo.SelectedIndex = 0;
            sizeCombo.SelectedIndex = 0;

    
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchWomanClothes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pname", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Search");
            dataGridView1.DataSource = ds.Tables["Search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            byte[] data = (byte[])dataGridView1.CurrentRow.Cells[2].Value;
            MemoryStream ms = new MemoryStream(data);
            img.Image = Image.FromStream(ms);
            lblPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString() + "$";
            lblPrice.Visible = true;
            txtForPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            clearall();
           
            btnMinus.Visible = true;
            btnPlus.Visible = true;
            txtQty.Visible = true;
            colorCombo.Visible = true;
            sizeCombo.Visible = true;
            lblColor.Visible = true;
            lblSize.Visible = true;
            btnClear.Visible = true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            
            if(txtForPrice.Text == "")
            {
                MessageBox.Show("Please Click On Item OR Clothe First !", "Fail Add Quantity", MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {        
                    a = a + 1;
                    txtQty.Text = a.ToString();
                    c = Double.Parse(txtForPrice.Text);
                    d = Double.Parse(txtQty.Text);
                    txtTotalPrice.Text = (c * d).ToString("#,##0.00" + "$");
                    txtTotalPrice.Visible = true;
                    lblTotal.Visible = true;
                
            }
            
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (txtForPrice.Text == "")
            {
                MessageBox.Show("Please Click On Item OR Clothe First !", "Fail Add Quantity", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if(int.Parse(txtQty.Text) <= 0)
                {
                    MessageBox.Show("No Available !", "Fail", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    --a;
                    txtQty.Text = a.ToString();
                    c = Double.Parse(txtForPrice.Text);
                    d = Double.Parse(txtQty.Text);
                    txtTotalPrice.Text = (c * d).ToString("#,##0.00" + "$");
                    txtTotalPrice.Visible = true;
                    lblTotal.Visible = true;
                }
                    
            }
      
        }

        private void BtnAddCart_Click(object sender, EventArgs e)
        {
     

            try
            {
                if (lblPrice.Text == "" || lblPrice.Text =="0")
                {
                    MessageBox.Show("Please select the clothe !", "Failed Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(txtQty.Text == "" || txtQty.Text =="0")
                {
                    MessageBox.Show("Please Add Quantity !", "Failed Order",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    double totalcost;
                    c = Double.Parse(txtForPrice.Text);
                    d = Double.Parse(txtQty.Text);

                    totalcost = c * d;


                    OracleCommand cmd = new OracleCommand("AddOrder", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("cid", Convert.ToInt32(UserLogin.getUserID()));
                    cmd.Parameters.Add("pid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.Parameters.Add("siz", sizeCombo.Text);
                    cmd.Parameters.Add("coll", colorCombo.Text);
                    cmd.Parameters.Add("qty", Convert.ToInt32(txtQty.Text));
                    cmd.Parameters.Add("total", totalcost);
                    cmd.Parameters.Add("cby", UserLogin.getUsername());
                    cmd.ExecuteNonQuery();
                    clearall();
                    colorCombo.Visible = false;
                    sizeCombo.Visible = false;
                    lblColor.Visible = false;
                    lblSize.Visible = false;
                    lblPrice.Visible = false;
                    btnMinus.Visible = false;
                    btnPlus.Visible = false;
                    txtQty.Visible = false;
                    a = 0;
                    img.Image = Properties.Resources.Jisoo_Dior;
                    dataGridView1.ClearSelection();
                    btnClear.Visible = false;
                    MessageBox.Show("One Item has been added to Shopping Cart. ", "Order Added",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            colorCombo.Visible = false;
            sizeCombo.Visible = false;
            lblColor.Visible = false;
            lblSize.Visible = false;
            lblPrice.Visible = false;
            btnMinus.Visible = false;
            btnPlus.Visible = false;
            txtQty.Visible = false;
            a = 0;
            img.Image = Properties.Resources.Jisoo_Dior;
            dataGridView1.ClearSelection();
            btnClear.Visible = false;
            txtTotalPrice.Visible = false;
            lblTotal.Visible = false;
        }

        private void BtnShoppingBasket_Click(object sender, EventArgs e)
        {
         
            FormShoppingCart fr = new FormShoppingCart();
            fr.ShowDialog();
        }

        private void PanelCart_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (UserLogin.getUsername() == "admin" || UserLogin.getUsername() == "Admin" || UserLogin.getUsername() == "Admin")
            {
                MessageBox.Show("Sorry Admin Can't Order Here. ", "Go to your Admin Dashboard",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
            colorCombo.Visible = false;
            sizeCombo.Visible = false;
            lblColor.Visible = false;
            lblSize.Visible = false;
            lblPrice.Visible = false;
            btnMinus.Visible = false;
            btnPlus.Visible = false;
            txtQty.Visible = false;
            a = 0;
            img.Image = Properties.Resources.Jisoo_Dior;
            dataGridView1.ClearSelection();
            btnClear.Visible = false;
            lblPrice.Text = "";
            try
            {


                conn.Open();
                double totalcost;
                c = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                d = qtyauto;
                totalcost = c * d;


                OracleCommand cmd = new OracleCommand("AddOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cid", Convert.ToInt32(UserLogin.getUserID()));
                cmd.Parameters.Add("pid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.Add("siz", "S");
                cmd.Parameters.Add("coll", "Black");
                cmd.Parameters.Add("qty", qtyauto);
                cmd.Parameters.Add("total", totalcost);
                cmd.Parameters.Add("cby", UserLogin.getUsername());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("One Item has been added to Shopping Cart. ", "Order Added",
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
}
