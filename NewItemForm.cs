﻿using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Managment
{
    public partial class NewItemForm : Form
    {
        SqlConnection conn = new SqlConnection(StaticVariables.connectionString);
        private DataGridViewRow values;
        private string tableName;

        private int rowId;
        private int tableRows = 0;
        private int formCategoryId;

        public NewItemForm(int formCategory, DataGridViewRow rowValues = null, string tableId = "")
        {
            InitializeComponent();
            formCategoryId = formCategory;
            formMethod.Text = "New Item";
            if (rowValues != null)
            {
                comboBox1.Enabled = false;
                formMethod.Text = "Item Edit";
                tableName = tableId;
                values = rowValues;
                FillTextBoxFields();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                tableName = (comboBox1.SelectedIndex == 0) ? StaticVariables.baseDB : StaticVariables.mattressDB;
                basePanel.Visible = true;
                basePanel.Enabled = true;

                fabricPanel.Visible = false;
                fabricPanel.Enabled = false;
            }
            else
            {
                tableName = StaticVariables.fabricDB;
                basePanel.Visible = false;
                basePanel.Enabled = false;

                fabricPanel.Visible = true;
                fabricPanel.Enabled = true;
            }
        }

        private void sumbitButton_Click(object sender, EventArgs e)
        {
            if (formCategoryId == 0) //New Item Form
                NewItemDBCommand();
            else // Edit Item
                EditItemDBCommand();
        }

        private async void NewItemDBCommand()
        {
            try
            {
                string sqlQuery = "";
                if (tableName == StaticVariables.baseDB)
                    sqlQuery = $"INSERT INTO {tableName} (BASENAME, DIMENSIONX, DIMENSIONY, QUANTITY) " +
                          "VALUES (@newName, @newX, @newy, @newQuantity)";
                else if (tableName == StaticVariables.mattressDB)
                    sqlQuery = $"INSERT INTO {tableName} (MATTRESSNAME, DIMENSIONX, DIMENSIONY, QUANTITY) " +
                          "VALUES (@newName, @newX, @newy, @newQuantity)";
                else
                    sqlQuery = $"INSERT INTO {tableName} (FABRICNAME, METERS) VALUES (@newName, @newMeters)";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync();
                    if (tableName == StaticVariables.baseDB || tableName == StaticVariables.mattressDB)
                    {
                        cmd.Parameters.AddWithValue("@newName", itemName.Text);
                        cmd.Parameters.AddWithValue("@newX", itemDimensionX.Text);
                        cmd.Parameters.AddWithValue("@newy", itemDimensionY.Text);
                        cmd.Parameters.AddWithValue("@newQuantity", itemQuantity.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@newName", fabricName.Text);
                        cmd.Parameters.AddWithValue("@newMeters", fabricMeter.Text);
                    }

                    cmd.ExecuteNonQuery();
                }

                tableRows++;
                this.Close();
                CostumMessageBox customMessageBox = new CostumMessageBox(true);
                customMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CostumMessageBox customMessageBox = new CostumMessageBox(false, ex.Message);
                customMessageBox.ShowDialog();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }

        private async void EditItemDBCommand()
        {
            try
            {
                string sqlQuery = "";

                if (tableName == StaticVariables.baseDB)
                    sqlQuery = $"UPDATE {tableName} SET BASENAME = @newName, DIMENSIONX = @newX, DIMENSIONy = @newy" +
                        ", QUANTITY = @newQuantity WHERE Id = @id";
                else if (tableName == StaticVariables.mattressDB)
                    sqlQuery = $"UPDATE {tableName} SET MATTRESSNAME = @newName, DIMENSIONX = @newX, DIMENSIONy = @newy" +
                        ", QUANTITY = @newQuantity WHERE Id = @id";
                else
                    sqlQuery = $"UPDATE {tableName} SET FABRICNAME = @newName, METERS = @newMeters WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync();
                    if (tableName == StaticVariables.baseDB || tableName == StaticVariables.mattressDB)
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

                this.Close();
                CostumMessageBox customMessageBox = new CostumMessageBox(true);
                customMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CostumMessageBox customMessageBox = new CostumMessageBox(false, ex.Message);
                customMessageBox.ShowDialog();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }

        private void FillTextBoxFields()
        {
            if (tableName == StaticVariables.baseDB || tableName == StaticVariables.mattressDB)
            {
                basePanel.Visible = true;
                basePanel.Enabled = true;
                fabricPanel.Visible = false;

                rowId = (int)values.Cells[0].Value;
                itemName.Text = values.Cells[1].Value.ToString();
                itemDimensionX.Text = values.Cells[2].Value.ToString();
                itemDimensionY.Text = values.Cells[3].Value.ToString();
                itemQuantity.Text = values.Cells[4].Value.ToString();
            }
            else
            {
                basePanel.Visible = false;
                fabricPanel.Visible = true;
                fabricPanel.Enabled = true;

                rowId = (int)values.Cells[0].Value;
                fabricName.Text = values.Cells[1].Value.ToString();
                fabricMeter.Text = values.Cells[2].Value.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            { 
                e.Handled = true;
            }
        }
    }
}
