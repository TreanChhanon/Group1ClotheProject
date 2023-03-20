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
	public partial class FormOrder : Form
	{
		OracleConnection conn = DbConnection.connect();
		public FormOrder()
		{
			InitializeComponent();
		}
		private static Double total, qty, price;
		private void clear()
		{
			cleartext fr = new cleartext();
			fr.ClearText(this);
		}
		private void showcombo()
		{
			this.cboColor.Items.AddRange(new object[] { "Black", "White", "Pink", "Blue", "Purple" });
			this.cboSize.Items.AddRange(new object[] { "S", "XL", "XXL", "XS" });

			cboColor.SelectedIndex = 0;
			cboSize.SelectedIndex = 0;

		}
		private void allorderforadmin()
		{
			OracleCommand cmd = new OracleCommand("showorderformadmin", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "all");
			dataGridView1.RowTemplate.Height = 35;
			dataGridView1.DataSource = ds.Tables["all"];
			DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
			imgCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
			imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
			dataGridView1.Columns[10].Visible = false;
			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[12].Visible = false;
			dataGridView1.Columns[13].Visible = false;
			this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
			this.dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
			this.dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
			cmd.Dispose();
			adapter.Dispose();
			ds.Dispose();

		}
		private void showproduct()
		{
			OracleCommand cmd = new OracleCommand("showadminproductcombo", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "product");
			cboProduct.DataSource = ds.Tables["product"];
			cboPrice.DataSource = ds.Tables["product"];
			cboProduct.DisplayMember = "ProductName";
			cboProduct.ValueMember = "ProductID";
			cboPrice.DisplayMember = "unitpriceout";
			cboPrice.ValueMember = "unitpriceout";
			cmd.Dispose();
			adapter.Dispose();
			ds.Dispose();

		}
		private void showcustomer()
		{
			OracleCommand cmd = new OracleCommand("showformodercustomer", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "customer");
			cboCustomer.DataSource = ds.Tables["customer"];

			cboCustomer.DisplayMember = "customername";
			cboCustomer.ValueMember = "customerid";


			cmd.Dispose();
			adapter.Dispose();
			ds.Dispose();


		}


		private void FormOrder_Load(object sender, EventArgs e)
		{
			showcombo();
			allorderforadmin();
			showproduct();
			showcustomer();


		}

		private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtQty.Text = "";
			txtTotalPrice.Text = "";
		}

		private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			if (btnAddNew.Text == "Add New")
			{
				btnUpdate.Enabled = false;
				btnAddNew.Text = "Save";

				btnDelete.Text = "Cancel";
				txtOrderID.Clear();
				txtQty.Clear();
				txtTotalPrice.Clear();

			}
			else if (txtTotalPrice.Text == "" || txtQty.Text == "" || cboColor.Text == "" || cboProduct.Text == "" || cboCustomer.Text == "" || cboSize.Text == "")
			{
				MessageBox.Show("Please fill up the form!", "Column cannot be null",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtQty.Focus();

			}
			else
			{

				try
				{
					// open the connection
					conn.Open();

					OracleCommand cmd_insert = new OracleCommand("addadminorderform", conn);
					cmd_insert.CommandType = CommandType.StoredProcedure;
					// set values for parameter
					cmd_insert.Parameters.Add("cid", cboCustomer.SelectedValue);
					cmd_insert.Parameters.Add("pid", cboProduct.SelectedValue);
					cmd_insert.Parameters.Add("psize", cboSize.Text);
					cmd_insert.Parameters.Add("pcolor", cboColor.Text);
					cmd_insert.Parameters.Add("qty", Convert.ToInt32(txtQty.Text));
					cmd_insert.Parameters.Add("total", Convert.ToDouble(txtTotalPrice.Text));
					cmd_insert.Parameters.Add("cby", UserLogin.getUsername());

					cmd_insert.ExecuteNonQuery();
					allorderforadmin();
					// change text of button
					btnAddNew.Text = "Add New";
					btnDelete.Text = "Delete";
					//enable button update
					btnUpdate.Enabled = true;
					//calling the method
					clear();
					this.Close();
					MessageBox.Show("One Order has been added. ", "Ordered Added",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					FormOrder order = new FormOrder();
					order.Show();

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error. " + ex.Message, "Add Ordered Failed",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					conn.Close(); // close the connection
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtOrderID.Text == "" || txtTotalPrice.Text == "" || txtQty.Text == "" || cboColor.Text == "" || cboProduct.Text == "" || cboCustomer.Text == "" || cboSize.Text == "")
			{
				MessageBox.Show("Please fill up the form Or Select Ordered!", "Column cannot be null",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtQty.Focus();

			}
			else
			{

				try
				{
					// open the connection
					conn.Open();

					OracleCommand cmd_update = new OracleCommand("updateadminorderform", conn);
					cmd_update.CommandType = CommandType.StoredProcedure;
					// set values for parameter
					cmd_update.Parameters.Add("id", Convert.ToInt32(txtOrderID.Text));
					cmd_update.Parameters.Add("cid", cboCustomer.SelectedValue);
					cmd_update.Parameters.Add("pid", cboProduct.SelectedValue);
					cmd_update.Parameters.Add("psize", cboSize.Text);
					cmd_update.Parameters.Add("pcolor", cboColor.Text);
					cmd_update.Parameters.Add("qty", Convert.ToInt32(txtQty.Text));
					cmd_update.Parameters.Add("total", Convert.ToDouble(txtTotalPrice.Text));
					cmd_update.Parameters.Add("uby", UserLogin.getUsername());

					cmd_update.ExecuteNonQuery();
					allorderforadmin();
					cmd_update.Dispose();
					MessageBox.Show("One Order has been updated. ", "Updated Added",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error. " + ex.Message, "Updated Ordered Failed",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					conn.Close(); // close the connection
				}
			}
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			txtOrderID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			cboCustomer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			cboProduct.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			cboSize.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			cboColor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtQty.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			cboPrice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			txtTotalPrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			txtTotalPrice.Enabled = false;

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (btnDelete.Text == "Cancel")
			{
				btnUpdate.Enabled = true;
				btnAddNew.Text = "Add New";

				btnDelete.Text = "Delete";
			}
			else if (btnDelete.Text == "Delete")
			{
				if (string.IsNullOrEmpty(txtOrderID.Text))
				{
					MessageBox.Show("Please select a Product that you want to delete!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					if (MessageBox.Show("Are you sure you want to Cancel'" + cboProduct.Text + "'?", "Cancel Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						try

						{
							conn.Open();
							// create command object
							// set values for parameter of store procedure
							OracleCommand cmd = new OracleCommand("deleteadminorder", conn);
							cmd.CommandType = CommandType.StoredProcedure;
							//set values for parameters of store procedure

							cmd.Parameters.Add("ID", Convert.ToInt32(txtOrderID.Text));
							cmd.Parameters.Add("uby", UserLogin.getUsername());
							cmd.ExecuteNonQuery();
							// calling the method
							allorderforadmin();


							MessageBox.Show("One Reccord has Been Canceled.", "Record Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error." + ex.Message, "Canceled Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						finally
						{
							conn.Close(); // close the connection
						}

					}
				}
			}
		}

		private void btnUndoCancel_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtOrderID.Text))
			{
				MessageBox.Show("Please select a Product that you want to undo!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "Paid" || dataGridView1.CurrentRow.Cells[9].Value.ToString() == "paid" || dataGridView1.CurrentRow.Cells[9].Value.ToString() == "PAID")
			{
				MessageBox.Show("Sorry You Cannot Undo The Paid Payment!", "Failed to undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to Undo '" + cboProduct.Text + "'?", "Undo Order ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try

					{
						conn.Open();
						// create command object
						// set values for parameter of store procedure
						OracleCommand cmd = new OracleCommand("undoadminorder", conn);
						cmd.CommandType = CommandType.StoredProcedure;
						//set values for parameters of store procedure

						cmd.Parameters.Add("ID", Convert.ToInt32(txtOrderID.Text));
						cmd.Parameters.Add("uby", UserLogin.getUsername());
						cmd.ExecuteNonQuery();
						// calling the method
						allorderforadmin();


						MessageBox.Show("Undo Cancel Successful.", "Undo Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error." + ex.Message, "Undo Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					finally
					{
						conn.Close(); // close the connection
					}

				}
			}
		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtOrderID.Text))
			{
				MessageBox.Show("Please select a Product that you want to pay!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "Cancel")
			{
				MessageBox.Show("Please undo Cancel to Not Paid First !", "Fail to add payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to Pay this  '" + cboProduct.Text + "'?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try

					{
						conn.Open();
						// create command object
						// set values for parameter of store procedure
						OracleCommand cmd = new OracleCommand("updateadminpayment", conn);
						cmd.CommandType = CommandType.StoredProcedure;
						//set values for parameters of store procedure

						cmd.Parameters.Add("ID", Convert.ToInt32(txtOrderID.Text));
						cmd.Parameters.Add("uby", UserLogin.getUsername());
						cmd.ExecuteNonQuery();

						OracleCommand cmd_insert = new OracleCommand("AddPaymentAdmin", conn);
						cmd_insert.CommandType = CommandType.StoredProcedure;
						//set values for parameters of store procedure

						cmd_insert.Parameters.Add("ID", Convert.ToInt32(cboCustomer.SelectedValue));
						cmd_insert.Parameters.Add("total", Convert.ToDouble(txtTotalPrice.Text));
						cmd_insert.Parameters.Add("cby", UserLogin.getUsername());
						cmd_insert.Parameters.Add("qty", Convert.ToInt32(txtQty.Text));
						cmd_insert.ExecuteNonQuery();

						cmd.Dispose();
						cmd_insert.Dispose();
						// calling the method
						allorderforadmin();


						MessageBox.Show("Payment has been added.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error." + ex.Message, "Failed to add payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					finally
					{
						conn.Close(); // close the connection
					}

				}
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			OracleCommand cmd = new OracleCommand("SearchAdminOrder", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("name", txtSearch.Text.Trim());
			OracleDataAdapter adapter = new OracleDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "search");
			dataGridView1.DataSource = ds.Tables["search"];
			cmd.Dispose();
			adapter.Dispose();
			ds.Dispose();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtQty_TextChanged(object sender, EventArgs e)
		{
			if (txtQty.Text != "")
			{
				price = Double.Parse(cboPrice.Text);
				qty = Double.Parse(txtQty.Text);
				total = price * qty;
				txtTotalPrice.Text = total.ToString();
			}
			else
			{
				txtTotalPrice.Text = "";
			}


		}

		private void txtTotalPrice_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
