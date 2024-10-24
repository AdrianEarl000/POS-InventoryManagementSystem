using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_InventoryManagementSystem

{
    public partial class AdminAddUsers : Form
    {
        // SQL connection string to the database
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public AdminAddUsers()
        {
            InitializeComponent();
            
        }

        // Event handler for the "Add" button click
        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            // Validate empty fields before proceeding
            if (string.IsNullOrWhiteSpace(addUsers_username.Text) ||
                string.IsNullOrWhiteSpace(addUsers_password.Text) ||
                addUsers_role.SelectedIndex == -1 ||
                addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the connection is properly opened
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    // SQL query to check if the username already exists in the database
                    string checkUsername = "SELECT * FROM users WHERE username = @usern";

                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // If username exists, show an error message
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(addUsers_username.Text.Trim() + " is already taken.",
                                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // SQL query to insert a new user into the database
                            string insertData = "INSERT INTO users (username, password, role, status, date) " +
                                                "VALUES (@usern, @pass, @role, @status, @date)";

                            using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                            {
                                // Add parameters for the new user
                                insertCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                insertCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                                // Add the current date for the new record
                                DateTime today = DateTime.Today;
                                insertCmd.Parameters.AddWithValue("@date", today);

                                // Execute the insert command
                                insertCmd.ExecuteNonQuery();

                                // Show success message after adding user
                                MessageBox.Show("User added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during connection or SQL execution
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure the connection is closed after the operation
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Connection is already open.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Update" button click
        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            // Validate empty fields before proceeding
            if (string.IsNullOrWhiteSpace(addUsers_username.Text) ||
                string.IsNullOrWhiteSpace(addUsers_password.Text) ||
                addUsers_role.SelectedIndex == -1 ||
                addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the connection is properly opened
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    // SQL query to update an existing user in the database
                    string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";

                    using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                    {
                        // Add parameters for updating the user
                        updateCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                        updateCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                        // Execute the update command
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show success message after updating user
                            MessageBox.Show("User updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Show error if no rows were affected (user not found)
                            MessageBox.Show("No user found to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during connection or SQL execution
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure the connection is closed after the operation
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Connection is already open.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}