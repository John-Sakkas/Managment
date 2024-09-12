using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Managment
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=John_S-PC;Initial Catalog=MANAGMENTDB;Integrated Security=True;Trust Server Certificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName, password;
            userName = usernameText.Text;
            password = passwordText.Text;

            try
            {

                string sqlQuerry = "SELECT * FROM USERS WHERE username='" + userName + "'AND userPassword='" + password + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conn);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show(dt.Rows[0]["username"].ToString() + " Login Succes");
                }
                else
                {
                    MessageBox.Show("Wrong Passowrd");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void usernameText_Enter(object sender, EventArgs e)
        {
            if (usernameText.Text == "Username")
            {
                usernameText.Text = "";
                usernameText.ForeColor = Color.Black;
            }
        }

        private void usernameText_Leave(object sender, EventArgs e)
        {
            if (usernameText.Text == "")
            {
                usernameText.Text = "Username";
                usernameText.ForeColor = Color.LightGray;

            }
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "Password")
            {
                passwordText.Text = "";
                passwordText.PasswordChar = '*';
                passwordText.ForeColor = Color.Black;
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                passwordText.Text = "Password";
                passwordText.PasswordChar = '\0';
                passwordText.ForeColor = Color.LightGray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
