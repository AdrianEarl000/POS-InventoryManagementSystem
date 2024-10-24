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
    public partial class AdminAddUser : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AdminAddUser()
        {
            InitializeComponent();
            displayAllUsersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAllUsersData();
        }

        public void displayAllUsersData()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                string query = "SELECT * FROM users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying users: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUsers_username.Text) ||
                string.IsNullOrWhiteSpace(addUsers_password.Text) ||
                addUsers_role.SelectedIndex == -1 ||
                addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                string checkUsername = "SELECT * FROM users WHERE username = @usern";
                using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show(addUsers_username.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password, role, status, date) " +
                                            "VALUES (@usern, @pass, @role, @status, @date)";
                        using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                        {
                            insertCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                            insertCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                            DateTime today = DateTime.Today;
                            insertCmd.Parameters.AddWithValue("@date", today);

                            insertCmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("User added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAllUsersData();
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
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUsers_username.Text) ||
               string.IsNullOrWhiteSpace(addUsers_password.Text) ||
               addUsers_role.SelectedIndex == -1 ||
               addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";
                using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                {
                    updateCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                    updateCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                    updateCmd.ExecuteNonQuery();
                    clearFields();
                    MessageBox.Show("User updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayAllUsersData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(addUsers_username.Text))
            {
                MessageBox.Show("Please enter a username to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

               
                string checkUsername = "SELECT * FROM users WHERE username = @usern";
                using (SqlCommand checkCmd = new SqlCommand(checkUsername, connect))
                {
                    checkCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkCmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("User not found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        string deleteQuery = "DELETE FROM users WHERE username = @usern";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("User removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            displayAllUsersData();
                            clearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Removal failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                {
                    connect.Close();
                }
            }
        }

        private void AdminAddUser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
