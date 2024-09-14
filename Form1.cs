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
            userName = usernameText.CustomText;
            password = passwordText.CustomText;

            try
            {

                string sqlQuerry = "SELECT * FROM USERS WHERE username='" + userName + "'AND userPassword='" + password + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conn);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0]["username"].ToString() + " Login Succes");
                    errorMessage.Text = "";
                }
                else
                {
                    errorMessage.Text = "Incorrect values";
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
            if (usernameText.CustomText == "Username")
            {
                usernameText.CustomText = "";
                usernameText.CustomTextColor = Color.Black;
            }
            errorMessage.Text = "";
        }
        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.CustomText == "Password")
            {
                passwordText.CustomText = "";
                passwordText.CustomPasswordChar = '*';
                passwordText.CustomTextColor = Color.Black;
            }
            errorMessage.Text = "";
        }
        private void usernameText_Leave(object sender, EventArgs e)
        {
            if (usernameText.CustomText == "")
            {
                usernameText.CustomText = "Username";
                usernameText.CustomTextColor = Color.LightGray;
            }
        }
        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.CustomText == "")
            {
                passwordText.CustomText = "Password";
                passwordText.CustomPasswordChar = '\0';
                passwordText.CustomTextColor = Color.LightGray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customToolbox1_MouseDown(object sender, MouseEventArgs e)
        {
            customToolbox1.DefaultColor = ColorTranslator.FromHtml("#1C77C3");
        }
        private void customToolbox1_MouseEnter(object sender, EventArgs e)
        {
            customToolbox1.DefaultColor = ColorTranslator.FromHtml("#63B7FF");
        }
        private void customToolbox1_MouseLeave(object sender, EventArgs e)
        {
            customToolbox1.DefaultColor = ColorTranslator.FromHtml("#1E90FF");
        }
    }
}
