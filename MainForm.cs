using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Managment
{
    public partial class MainForm : Form
    {
        bool menuExpand = false;
        bool sideBarExpand = true;
        SqlConnection conn = new SqlConnection("Data Source=John_S-PC;Initial Catalog=MANAGMENTDB;Integrated Security=True;Trust Server Certificate=True");

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String username)
        {
            InitializeComponent();
            label2.Text = username;
        }
        
        private void itemMenuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                itemMenu.Height += 10;
                if (itemMenu.Height >= 232)
                {
                    itemMenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                itemMenu.Height -= 10;
                if (itemMenu.Height <= 50)
                {
                    itemMenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarMenu.Width -= 10;
                if (sideBarMenu.Width <= 55)
                {
                    sideBar.Stop();
                    sideBarExpand = false;
                }
            }
            else
            {
                sideBarMenu.Width += 10;
                if (sideBarMenu.Width >= 191)
                {
                    sideBar.Stop();
                    sideBarExpand = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemMenuTransition.Start();
        }

        private void sideBarToggle_Click(object sender, EventArgs e)
        {
            sideBar.Start();
        }

        private async void FillDataGrid(string db_TableName)
        {
            try
            {
                string sqlQuery = $"SELECT * FROM {db_TableName}";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync(); // Open the connection asynchronously
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
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

        private void basesSubOption_Click(object sender, EventArgs e)
        {
            FillDataGrid("BASEDB");
        }

        private void mattressSubOption_Click(object sender, EventArgs e)
        {
            FillDataGrid("MATTRESSDB");
        }

        private void fabricsSubOption_Click(object sender, EventArgs e)
        {
            FillDataGrid("FABRICDB");
        }
    }
}
