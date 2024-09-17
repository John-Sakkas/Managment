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

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string userName = usernameText.CustomText;
            string password = passwordText.CustomText;

            try
            {
                string sqlQuery = "SELECT * FROM USERS WHERE username=@username AND userPassword=@password";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Use parameterized queries to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", password);

                    await conn.OpenAsync(); // Open the connection asynchronously

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) // Execute query asynchronously
                    {
                        if (await reader.ReadAsync()) // Check if any rows are returned
                        {
                            MessageBox.Show(reader["username"].ToString() + " Login Success");
                            errorMessage.Text = "";
                            MainForm frm = new MainForm("JOHN");
                            frm.Show();
                        }
                        else
                        {
                            errorMessage.Text = "Incorrect values";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync(); // Close the connection asynchronously
                }
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
    }
}
