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
        SqlConnection conn = new SqlConnection("Data Source=John_S-PC;Initial Catalog=MANAGMENTDB;Integrated Security=True;Trust Server Certificate=True");
        Form1 loginForm;
        private int rowIndex = 0;
        private int rowId = 0;
        string tableName;


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
            base_mattressPanel.Visible = true;
            fabricPanel.Visible = false;
            FillDataGrid("BASEDB");
        }

        private void mattressSubOption_Click(object sender, EventArgs e)
        {
            base_mattressPanel.Visible = true;
            fabricPanel.Visible = false;
            FillDataGrid("MATTRESSDB");
        }

        private void fabricsSubOption_Click(object sender, EventArgs e)
        {
            base_mattressPanel.Visible = false;
            fabricPanel.Visible = true;
            FillDataGrid("FABRICDB");
        }

        bool fromLogout = false;

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
                // Get the entire row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (tableName == "BASEDB" || tableName == "MATTRESSDB")
                {
                    rowIndex = e.RowIndex;
                    rowId = (int)row.Cells[0].Value;
                    itemName.Text = row.Cells[1].Value.ToString();
                    itemDimensionX.Text = row.Cells[2].Value.ToString();
                    itemDimensionY.Text = row.Cells[3].Value.ToString();
                    itemQuantity.Text = row.Cells[4].Value.ToString();
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
                else
                {
                    rowIndex = e.RowIndex;
                    rowId = (int)row.Cells[0].Value;
                    fabricName.Text = row.Cells[1].Value.ToString();
                    fabricMeter.Text = row.Cells[2].Value.ToString();
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
            }
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0) return;
            try
            {
                string sqlQuery = "";

                if (tableName == "BASEDB")
                    sqlQuery = $"UPDATE {tableName} SET BASENAME = @newName, DIMENSIONX = @newX, DIMENSIONy = @newy" +
                        ", QUANTITY = @newQuantity WHERE Id = @id";
                else if(tableName == "MATTRESSDB")
                    sqlQuery = $"UPDATE {tableName} SET MATTRESSNAME = @newName, DIMENSIONX = @newX, DIMENSIONy = @newy" +
                        ", QUANTITY = @newQuantity WHERE Id = @id";
                else
                    sqlQuery = $"UPDATE {tableName} SET FABRICNAME = @newName, METERS = @newMeters WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync(); // Open the connection asynchronously
                    if (tableName == "BASEDB" || tableName == "MATTRESSDB")
                    {

                        cmd.Parameters.AddWithValue("@newName", itemName.Text);
                        cmd.Parameters.AddWithValue("@newX", itemDimensionX.Text);
                        cmd.Parameters.AddWithValue("@newy", itemDimensionY.Text);
                        cmd.Parameters.AddWithValue("@newQuantity", itemQuantity.Text);
                        cmd.Parameters.AddWithValue("@id", rowId);
                    }
                    else 
                    {
                        cmd.Parameters.AddWithValue("@newName", fabricName.Text);
                        cmd.Parameters.AddWithValue("@newMeters", fabricMeter.Text);
                        cmd.Parameters.AddWithValue("@id", rowId);
                    }

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

        private void clearSelection_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void ClearValues()
        {
            rowIndex = 0;
            rowId = 0;
            itemName.Text = "";
            itemDimensionX.Text = "";
            itemDimensionY.Text = "";
            itemQuantity.Text = "";
            fabricName.Text = "";
            fabricMeter.Text = "";
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0) return;
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
    }
} 
