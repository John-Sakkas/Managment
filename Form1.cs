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
            string userName , password;
            userName = userNameText.Text;
            password = passwordText.Text;

            try
            {

                string sqlQuerry = "SELECT * FROM USERS WHERE username='" + userName + "'AND userPassword='" + password + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conn);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Succes");
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
    }
}
