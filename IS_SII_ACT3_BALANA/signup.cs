using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IS_SII_ACT3_BALANA
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginRed_Click(object sender, EventArgs e)
        {
            Form1 login_red = new Form1();

            login_red.Show();

            this.Hide();
        }

        private void signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string add_uname = uname.Text;

            string add_pass = passTxt.Text;

            string con_pass = conPass.Text;

            if (add_uname == "" || add_pass == "" || con_pass == "")
            {
                MessageBox.Show("Please fill in all fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (add_pass != con_pass)
            {
                MessageBox.Show("Password does not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            try
            {
                using (OleDbConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO users (username, passwordHash) VALUES(?,?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = add_uname;
                        cmd.Parameters.Add("?", OleDbType.LongVarChar).Value = add_pass;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully signed up!", "Success!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        uname.Clear();
                        passTxt.Clear();
                        conPass.Clear();
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
