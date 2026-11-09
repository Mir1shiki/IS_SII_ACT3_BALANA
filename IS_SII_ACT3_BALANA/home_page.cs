using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace IS_SII_ACT3_BALANA
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void home_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_item addRedirect = new add_item();

            addRedirect.Show();
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM products";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        dt.Columns.Add("Status", typeof(string));

                        foreach (DataRow dr in dt.Rows)
                        {
                            int quantity = Convert.ToInt32(dr["quantity"]);
                            int reordLvl = Convert.ToInt32(dr["reorder_level"]);

                            if (quantity == 0)
                            {
                                dr["status"] = "Out of Stock";
                            }
                            else if (quantity <= reordLvl)
                            {
                                dr["status"] = "Low Stock";
                            }
                            else
                            {
                                dr["status"] = "In Stock";
                            }
                        }

                        disProd.DataSource = null;
                        disProd.Columns.Clear();
                        disProd.AutoGenerateColumns = true;
                        disProd.DataSource = dt;

                        disProd.Columns["product_id"]?.HeaderText = "Id";
                        disProd.Columns["product_name"]?.HeaderText = "Product Name";
                        disProd.Columns["category"]?.HeaderText = "Category";
                        disProd.Columns["quantity"]?.HeaderText = "Stock Quantity";
                        disProd.Columns["unit_price"]?.HeaderText = "Unit Price";
                        disProd.Columns["reorder_level"]?.HeaderText = "Reorder Level";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void home_page_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void refreshh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (disProd.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first. ");
                return;
            }

            int productId = Convert.ToInt32(
                disProd.CurrentRow.Cells["product_id"].Value);

            using (edit_page updateForm = new edit_page(productId))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (disProd.CurrentRow == null)
            {
                MessageBox.Show("Enter a product first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int productId = Convert.ToInt32(
                disProd.CurrentRow.Cells["product_id"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (OleDbConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM products WHERE product_id = ?";

                    using(OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = productId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Deleted Successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Product not found", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            
        }
    }
}
