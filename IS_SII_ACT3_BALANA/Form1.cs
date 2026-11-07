using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IS_SII_ACT3_BALANA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signupRed_Click(object sender, EventArgs e)
        {
            signup Signupage = new signup();

            Signupage.Show();

            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButt_Click(object sender, EventArgs e)
        {
            home_page hmpage = new home_page();
            string uname = unTxt.Text.Trim();
            string pass = pasTxt.Text;

            if (uname == "" || pass == "")
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

                    string query = "SELECT COUNT(*) FROM users WHERE username = ? AND passwordHash = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = uname;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = pass;

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Logged in successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            hmpage.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password! ", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }
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
