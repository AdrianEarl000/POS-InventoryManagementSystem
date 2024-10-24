using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_InventoryManagementSystem
{
    public partial class AdminDashboard : UserControl
    {
        // Connection string for your SQL Server database
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminDashboard()
        {
            InitializeComponent();

            // Load initial data when the dashboard is created
            displayTodaysCustomers();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
           
        }

        // Method to refresh displayed data
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            // Refresh various dashboard components
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
           
        }
        

        // Method to display today's customers
        public void displayTodaysCustomers()
        {
            CustomersData cData = new CustomersData();
            List<CustomersData> listData = cData.allTodayCustomers();
            
        }

        // Method to check if the database connection is closed
        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        // Method to display the count of active users
        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM users WHERE status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AU.Text = count.ToString();
                        }
                        reader.Close(); // Always close the reader after use
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close(); // Ensure the connection is closed in the finally block
                }
            }
        }

        // Method to display the count of all customers
        public void displayAllCustomers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AC.Text = count.ToString();
                        }
                        reader.Close(); // Close the reader after use
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close(); // Ensure the connection is closed
                }
            }
        }

        // Method to display today's income
        public void displayTodaysIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM orders WHERE CAST(order_date AS DATE) = @date"; // Adjusted query for orders

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object value = reader[0];

                                if (value != DBNull.Value)
                                {
                                    decimal income = Convert.ToDecimal(value);
                                    dashboard_TI.Text = "$" + income.ToString("0.00");
                                }
                                else
                                {
                                    dashboard_TI.Text = "$0.00"; // Handle case where there are no sales today
                                }
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
                    connect.Close(); // Ensure the connection is closed
                }
            }
        }
        // Method to display total income
        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object value = reader[0];

                                if (value != DBNull.Value)
                                {
                                    decimal income = Convert.ToDecimal(value);
                                    dashboard_totalIncome.Text = "$" + income.ToString("0.00");
                                }
                                else
                                {
                                    dashboard_totalIncome.Text = "$0.00"; // Handle case where there are no sales
                                }
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
                    connect.Close(); // Ensure the connection is closed
                }
            }
        }

        // Event handlers for UI components (left unchanged)
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void AdminDashboard_Load(object sender, EventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { displayAllCustomers(); }
        private void label8_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void dashboard_TI_Click(object sender, EventArgs e) { }

        private void cashierCustomersForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
