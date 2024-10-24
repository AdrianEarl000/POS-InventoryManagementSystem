﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS_InventoryManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text ==""|| register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all empty blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string CheckUsername = "SELECT * FROM users WHERE username =@usern";

                        using(SqlCommand cmd = new SqlCommand(CheckUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern",register_username.Text.Trim());


                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() 
                                    + "is  already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 characters are needed"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else if(register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Password does not match."
                                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } 
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date) " +
                          "VALUES(@usern,@pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Registered Succesfully!"
                                   , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex
                                 , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' :'0' ;
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
