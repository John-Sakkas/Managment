using Microsoft.Data.SqlClient;
using System;
using System.Buffers.Text;
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
        SqlConnection conn = new SqlConnection(StaticVariables.connectionString);
        Form1 loginForm;
        private int rowIndex = 0;
        string tableName;
        private int tableRows = 0;
        bool fromLogout = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String username, Form1 loginF)
        {
            InitializeComponent();
            label2.Text = username;
            loginForm = loginF;
        }

        private void itemMenuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                itemPanel.Visible = true;

                itemMenu.Height += 10;
                if (itemMenu.Height >= 232)
                {
                    itemMenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                ClearValues();
                itemPanel.Visible = false;

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
            ClearValues();
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
                    tableRows = dt.Rows.Count;
                }
                tableName = db_TableName;
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
            FillDataGrid(StaticVariables.baseDB);
        }

        private void mattressSubOption_Click(object sender, EventArgs e)
        {
            FillDataGrid(StaticVariables.mattressDB);
        }

        private void fabricsSubOption_Click(object sender, EventArgs e)
        {
            FillDataGrid(StaticVariables.fabricDB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromLogout = true;
            Close();
            loginForm.Show();
            loginForm.ClearValues();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!fromLogout)
                loginForm.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is within the grid and not on header cells
            if (e.RowIndex >= 0)
            {
                    rowIndex = e.RowIndex;
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                    newItem.Enabled = false;
            }
        }

        private void clearSelection_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void ClearValues()
        {
            rowIndex = 0;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            newItem.Enabled = true;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0) return;

            int rowId = (int)dataGridView1.Rows[rowIndex].Cells[0].Value;
            try
            {
                string sqlQuery = $"DELETE FROM {tableName} WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync(); // Open the connection asynchronously
                    cmd.Parameters.AddWithValue("@id", rowId); // Assuming rowIndex + 1 corresponds to the ID to be deleted

                    cmd.ExecuteNonQuery();
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
                FillDataGrid(tableName);
                ClearValues();
            }
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            NewItemForm newItemForm = new NewItemForm(0);
            newItemForm.ShowDialog();
            if(dataGridView1.DataSource != null)
                FillDataGrid(tableName);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            NewItemForm newItemForm = new NewItemForm(1, row, tableName);
            newItemForm.ShowDialog();
            FillDataGrid(tableName);
        }
    }
} 
