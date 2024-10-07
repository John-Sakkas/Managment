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

namespace Managment
{
    public partial class NewItemForm : Form
    {
        private string tableName;
        SqlConnection conn = new SqlConnection(StaticVariables.connectionString);
        private int tableRows = 0;

        public NewItemForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                tableName = (comboBox1.SelectedIndex == 0) ? "BASEDB" : "MATTRESSDB";
                basePanel.Visible = true;
                fabricPanel.Visible = false;
            }
            else
            {
                tableName = "FABRICDB";
                basePanel.Visible = false;
                fabricPanel.Visible = true;
            }
            tableRows = GetTableRows(tableName).Result;
        }

        private async void sumbitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "";
                tableRows++;
                if (tableName == "BASEDB")
                    sqlQuery = $"INSERT INTO {tableName} (ID, BASENAME, DIMENSIONX, DIMENSIONY, QUANTITY) " +
                          "VALUES (@newId, @newName, @newX, @newy, @newQuantity)";
                else if (tableName == "MATTRESSDB")
                    sqlQuery = $"INSERT INTO {tableName} (ID, MATTRESSNAME, DIMENSIONX, DIMENSIONY, QUANTITY) " +
                          "VALUES (@newId, @newName, @newX, @newy, @newQuantity)";
                else
                    sqlQuery = $"INSERT INTO {tableName} (ID, FABRICNAME, METERS) VALUES (@newId, @newName, @newMeters)";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync(); // Open the connection asynchronously
                    if (tableName == "BASEDB" || tableName == "MATTRESSDB")
                    {
                        cmd.Parameters.AddWithValue("@newId", tableRows);
                        cmd.Parameters.AddWithValue("@newName", itemName.Text);
                        cmd.Parameters.AddWithValue("@newX", itemDimensionX.Text);
                        cmd.Parameters.AddWithValue("@newy", itemDimensionY.Text);
                        cmd.Parameters.AddWithValue("@newQuantity", itemQuantity.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@newId", tableRows);
                        cmd.Parameters.AddWithValue("@newName", fabricName.Text);
                        cmd.Parameters.AddWithValue("@newMeters", fabricMeter.Text);
                    }

                    cmd.ExecuteNonQuery();
                }

                this.Close();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<int> GetTableRows(string db_TableName)
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
                    tableRows = dt.Rows.Count;
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
            return tableRows;
        }
    }
}
