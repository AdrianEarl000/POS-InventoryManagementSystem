using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;  

namespace POS_InventoryManagementSystem
{
    internal class UsersData
    {
       
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        
        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

            try
            {
                connect.Open();

                
                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                   
                    while (reader.Read())  
                    {
                        UsersData uData = new UsersData
                        {
                            ID = (int)reader["id"],  
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        listData.Add(uData);
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
