using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_InventoryManagementSystem
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        private string selectedCategory = ""; // Store the selected category for updating

        public AdminAddCategories()
        {
            InitializeComponent();

            displayCategoriesData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoriesData();
        }


        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();
            dataGridView1.DataSource = listData;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string category = row.Cells["category"].Value.ToString();
                string date = row.Cells["date"].Value.ToString();
                addCategories_category.Text = category;
                selectedCategory = category;


                MessageBox.Show($"You selected: Category: {category}, Date: {date}");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e); // 
        }


        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            string categoryText = addCategories_category.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryText))
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string checkCat = "SELECT COUNT(*) FROM categories WHERE category = @cat"; // Use COUNT for efficiency
                    using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", categoryText);
                        int categoryExists = (int)cmd.ExecuteScalar(); // ExecuteScalar for single value

                        if (categoryExists > 0)
                        {
                            MessageBox.Show("Category: " + categoryText + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO categories (category, date) VALUES(@cat, @date)";
                            using (SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@cat", categoryText);
                                insertD.Parameters.AddWithValue("@date", DateTime.Today);
                                insertD.ExecuteNonQuery();

                                displayCategoriesData(); // Refresh the DataGridView after adding
                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            string newCategoryText = addCategories_category.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCategoryText))
            {
                MessageBox.Show("Please enter a new category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("No category selected to update. Please select a category first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string updateQuery = "UPDATE categories SET category = @newCat WHERE category = @oldCat";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@newCat", newCategoryText);
                        cmd.Parameters.AddWithValue("@oldCat", selectedCategory);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayCategoriesData(); // Refresh the data grid to show the updated data
                        }
                        else
                        {
                            MessageBox.Show("No category was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("No category selected to remove. Please select a category first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string deleteQuery = "DELETE FROM categories WHERE category = @cat";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", selectedCategory);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayCategoriesData();
                            addCategories_category.Clear();
                            selectedCategory = "";
                        }
                        else
                        {
                            MessageBox.Show("No category was removed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }


        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            addCategories_category.Clear(); // Clear the TextBox
            selectedCategory = ""; // Reset selected category
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
