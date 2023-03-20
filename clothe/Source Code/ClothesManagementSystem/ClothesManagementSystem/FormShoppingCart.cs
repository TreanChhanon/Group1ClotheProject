using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.ManagedDataAccess.Client;
namespace ClothesManagementSystem
{
    public partial class FormShoppingCart : Form
    {
        OracleConnection conn = DbConnection.connect();
        public FormShoppingCart()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
      private static int totalqty;
        private static String count;
        public void showorder()
        {
            OracleCommand cmd = new OracleCommand("showorder", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "all");
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DataSource = ds.Tables["all"];
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].Width = 350;
            this.dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;

            //     for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            //      {
            //        total1 += Double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            //    }
            //   txtTotalPrice.Text = total1.ToString("#,##0.00" + "$");

         //   lblItemCount.Text = "Number Of Items: " + dataGridView1.RowCount.ToString();
          //  lblItemCount.Text = "Number Of Items: " + dataGridView1.RowCount.ToString();
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }
        public void countorderrow()
        {
            OracleCommand cmd = new OracleCommand("countorderrow", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "countorderrow");
         
            cboCountrow.DataSource = ds.Tables["countorderrow"];
            cboCountrow.DisplayMember = "qty";
            cboCountrow.ValueMember = "qty";

            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }
        public void sumtotalpayment()
        {
            OracleCommand cmd = new OracleCommand("sumtotalorderprice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", UserLogin.getUserID());
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "totalpaymentamount");

            cboTotalAmount.DataSource = ds.Tables["totalpaymentamount"];
            cboTotalAmount.DisplayMember = "totalamount";
            cboTotalAmount.ValueMember = "totalamount";

            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showorder();
            dataGridView1.ClearSelection();
            countorderrow();
            sumtotalpayment();

           // txtTotalPrice.Text = Convert.ToString(cboTotalAmount.SelectedValue);
        
           
            String count2;
            count2 = "Number Of Items: ";
            lblItemCount.Text = count2  + cboCountrow.SelectedValue;
            cboCountrow.Visible = false;
            count = Convert.ToString(cboCountrow.SelectedValue);
            if (count != "")
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
           
            else
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            cboTotalAmount.Visible = false;
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Enabled = false;
           if(Convert.ToString(cboTotalAmount.SelectedValue) == "")
            {
                txtTotalPrice.Text = "";
            }
            else
            {
                Double total2 = Convert.ToDouble(cboTotalAmount.SelectedValue);
                txtTotalPrice.Text = total2.ToString("#,##0.00" + "$");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(txtTotalPrice.Text == "")
            {
                MessageBox.Show("Please buy item first!", "No item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to cancel'" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        // create command object
                        // set values for parameter of store procedure
                        OracleCommand cmd = new OracleCommand("DeleteOrder", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //set values for parameters of store procedure
                        cmd.Parameters.Add("id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd.Parameters.Add("name", UserLogin.getUsername());
                        cmd.ExecuteNonQuery();

                        // calling the method
                        showorder();
                        sumtotalpayment();
                        countorderrow();
                        if (Convert.ToString(cboTotalAmount.SelectedValue) == "")
                        {
                            txtTotalPrice.Text = "";
                        }
                        else
                        {
                            Double total2 = Convert.ToDouble(cboTotalAmount.SelectedValue);
                            txtTotalPrice.Text = total2.ToString("#,##0.00" + "$");
                        }
                        String count2;
                        count2 = "Number Of Items: ";
                        lblItemCount.Text = count2 + cboCountrow.SelectedValue;
                        MessageBox.Show("One Item has Been Canceled.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text == "")
            {
                MessageBox.Show("Please buy item first!", "No item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int id,qty;
                String size;
                String color;
                int price;
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                
     
                color = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                size = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                qty = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                this.Close();
                FormUpdateOrder fr = new FormUpdateOrder(id, color, size,qty,price);
                fr.ShowDialog();
                
            }
        }

        private void BtnAddCart_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text == "")
            {
                MessageBox.Show("Please buy item first!", "No Payment Need", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Double total1 = Convert.ToDouble(cboTotalAmount.SelectedValue);
                totalqty = Convert.ToInt32(cboCountrow.SelectedValue);
                FormAddPayment fr = new FormAddPayment(total1, totalqty);
                fr.ShowDialog();
                this.Close();
            }
           
        }
    }
}
