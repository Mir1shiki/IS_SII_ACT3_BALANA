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
    public partial class add_item : Form
    {
        public add_item()
        {
            InitializeComponent();
        }

        private void add_item_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string item_name = iName.Text;
            string item_category = iCategory.Text;
            int quantity = (int)quantityAdd.Value;
            decimal unit_price = (decimal)addUp.Value; 
            int reorder_lvl = (int)reorLvl.Value;

            if (quantity <= 0 || unit_price <= 0 || item_name == "" || item_category == "")
            {
                MessageBox.Show("Please fill in all fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            try
            {
                using (OleDbConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO products (product_name, category, quantity, unit_price, reorder_level) VALUES (?,?,?,?,?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = item_name;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = item_category;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = unit_price;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = reorder_lvl;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully added!", "Success!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        iName.Clear();
                        iCategory.Clear();
                        quantityAdd.Value = 0;
                        addUp.Value = 0;
                        reorLvl.Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
        }
    }
}
