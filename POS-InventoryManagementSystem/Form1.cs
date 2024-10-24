using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public static string username;

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialization code can go here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Logic for label2 click (if needed)
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Logic for label1 click (if needed)
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                return true;
            }
            return connect.State == ConnectionState.Open;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                          
                            Form1.username = login_username.Text.Trim();

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (userRole == "Admin")
                                {
                                    MainForm mForm = new MainForm();
                                    mForm.Show();
                                    this.Hide(); 
                                }
                                else if (userRole == "Cashier")
                                {
                                    CashierMainForm cmForm = new CashierMainForm();
                                    cmForm.Show();
                                    this.Hide(); // Hide the login form
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password or no Admin approval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Connection is not established.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
