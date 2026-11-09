using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IS_SII_ACT3_BALANA
{
    public partial class edit_page : Form
    {
        public edit_page()
        {
            InitializeComponent();
        }

        private int selectedProductId;

        public edit_page(int product_id)
        {
            InitializeComponent();

            selectedProductId = product_id;
        }

        private void loadProductDetails()
        {
            try
            {
                using (OleDbConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM products WHERE product_id = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductId;

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                prodName.Text = reader["product_name"].ToString();
                                prodCategory.Text = reader["category"].ToString();

                                edQty.Value = Convert.ToDecimal(reader["quantity"]);
                                editUp.Value = Convert.ToDecimal(reader["unit_price"]);
                                edReor.Value = Convert.ToDecimal(reader["reorder_level"]);

                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product " + ex.Message);
            }
        }

        private void edit_page_Load(object sender, EventArgs e)
        {
            loadProductDetails();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE products
                                     SET product_name = ?,
                                         category = ?,
                                         quantity = ?,
                                         unit_price = ?,
                                         reorder_level = ?
                                     WHERE product_id = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = prodName.Text;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = prodCategory.Text;

                        cmd.Parameters.Add("?", OleDbType.Integer).Value = (int)edQty.Value;
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = editUp.Value;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = (int)edReor.Value;

                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product successfully uddated!", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("An error occur please try again. ", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product " + ex.Message);
            }
        }


    }
}
