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
    public partial class FormProduct : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormProduct()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cleartext clear = new cleartext();
            clear.ClearText(this);
            pbProductImage.Image = Properties.Resources.No_Image_Available;
            dgvProduct.ClearSelection();
          
        }
        private void ShowProduct()
        {
            OracleCommand cmd = new OracleCommand("ShowProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Product");
            dgvProduct.RowTemplate.Height = 40;
            dgvProduct.DataSource = ds.Tables["Product"];
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dgvProduct.Columns[12];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvProduct.Columns[2].Visible = false;
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[7].Visible = false;
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }
        private void ShowCategory()
        {
            OracleCommand cmd = new OracleCommand("ShowCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            //create dataset object
            DataSet ds = new DataSet();
            //fill data into dataset object: d
            adapter.Fill(ds, "Category");
            // put categories into combobox
            comboCategory.DataSource = ds.Tables["Category"];
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "CategoryID";
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();

        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            ShowProduct();
            clear();
            dgvProduct.ClearSelection();
            ShowCategory();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnUpdate.Enabled = false;
                btnAddNew.Text = "Save";
               
                btnDelete.Text = "Cancel";
                clear();
                pbProductImage.Image = Properties.Resources.No_Image_Available;

            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.Focus();

                }
                else if (string.IsNullOrEmpty(txtProductQty.Text))
                {
                    MessageBox.Show("Please enter ProductQty Name!", "Required ProductQty Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductQty.Focus();
                }
                else if (string.IsNullOrEmpty(txtUnitPriceIn.Text))
                {
                    MessageBox.Show("Please enter UnitPriceIn Name!", "Required UnitPriceIN Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitPriceIn.Focus();
                }
                else if (string.IsNullOrEmpty(txtUnitPriceOut.Text))
                {
                    MessageBox.Show("Please enter UnitPriceOut Name!", "Required Priceout Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitPriceOut.Focus();
                }
                else if (string.IsNullOrEmpty(comboCategory.Text))
                {
                    MessageBox.Show("Please enter Select Category Name!", "Required Select Category Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboCategory.Focus();
                }
                else
                {
                    try
                    {
                        // open the connection
                        conn.Open();

                        MemoryStream ms = new MemoryStream();
                        pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);
                        //create command object
                        OracleCommand cmd_insert = new OracleCommand("AddProduct", conn);
                        cmd_insert.CommandType = CommandType.StoredProcedure;
                        // set values for parameter

                        cmd_insert.Parameters.Add("namne", txtProductName.Text);
                        cmd_insert.Parameters.Add("descript", txtDescription.Text);
                     
                        cmd_insert.Parameters.Add("bcode", txtBarcode.Text);
                   
                        cmd_insert.Parameters.Add("q", Convert.ToInt32(txtProductQty.Text));
                        cmd_insert.Parameters.Add("priceIn", Convert.ToDecimal(txtUnitPriceIn.Text));
                        cmd_insert.Parameters.Add("priceOut", Convert.ToDecimal(txtUnitPriceOut.Text));
                        cmd_insert.Parameters.Add("IMG", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.Parameters.Add("cby", UserLogin.getUsername());
                        cmd_insert.Parameters.Add("catID", comboCategory.SelectedValue);

                        cmd_insert.ExecuteNonQuery();

                        // change text of button
                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        //enable button update
                        btnUpdate.Enabled = true;
                        //calling the method
                        ShowProduct();
                        clear();
                        MessageBox.Show("One record has been added. ", "Product Added",
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

        private void DgvProduct_Click(object sender, EventArgs e)
        {
            byte[] data = (byte[])dgvProduct.CurrentRow.Cells[12].Value;
            MemoryStream ms = new MemoryStream(data);
            pbProductImage.Image = Image.FromStream(ms);
            txtProductID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            comboCategory.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtProductQty.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            txtBarcode.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
            txtUnitPriceIn.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
            txtUnitPriceOut.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
           
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image| *.png; *.jpg; * .png; * .bmp; ";
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Product Name cannot be null !", "Product Name Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductName.Focus();

            }
            else
            {
                try

                {
                    //open the connection
                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);

                    // create command object
                    OracleCommand cmd_update = new OracleCommand("UpdateProduct", conn);
                    cmd_update.CommandType = CommandType.StoredProcedure;
                    //set values for parameters of store procedure

                    cmd_update.Parameters.Add("ID", Convert.ToInt32(txtProductID.Text));
                    cmd_update.Parameters.Add("namne", txtProductName.Text);
                    cmd_update.Parameters.Add("descript", txtDescription.Text);
                    cmd_update.Parameters.Add("catID", comboCategory.SelectedValue);
                    cmd_update.Parameters.Add("bcode", txtBarcode.Text);
           
                    cmd_update.Parameters.Add("q", Convert.ToInt32(txtProductQty.Text));
                    cmd_update.Parameters.Add("priceIn", Convert.ToDecimal(txtUnitPriceIn.Text));
                    cmd_update.Parameters.Add("priceOut", Convert.ToDecimal(txtUnitPriceOut.Text));
                    cmd_update.Parameters.Add("IMG", OracleDbType.Blob).Value = ms.ToArray();
                    cmd_update.Parameters.Add("uby", UserLogin.getUsername());
                    cmd_update.ExecuteNonQuery();

                    ShowProduct();
                    clear();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (btnDelete.Text == "Cancel")
            {
                btnUpdate.Enabled = true;
                btnAddNew.Text = "Add New";
               
                btnDelete.Text = "Delete";
            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("Please select a Product that you want to delete!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete'" + txtProductName.Text + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try

                        {
                            conn.Open();
                            // create command object
                            // set values for parameter of store procedure
                            OracleCommand cmd = new OracleCommand("DeleteProduct", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //set values for parameters of store procedure

                            cmd.Parameters.Add("ID", Convert.ToInt32(txtProductID.Text));
                           
                            cmd.ExecuteNonQuery();
                            // calling the method
                            ShowProduct();
                            clear();
                            pbProductImage.Image = Properties.Resources.No_Image_Available;
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

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            FormRestoreProduct myForm = new FormRestoreProduct();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
            /*   FormRestoreProduct frm = new FormRestoreProduct();
               frm.MdiParent = this.MdiParent;
               frm.Show();
               */
        }

 

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SearchProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", txtSearch.Text.Trim());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "search");
            dgvProduct.DataSource = ds.Tables["search"];
            cmd.Dispose();
            adapter.Dispose();
            ds.Dispose();
        }
    }
}
