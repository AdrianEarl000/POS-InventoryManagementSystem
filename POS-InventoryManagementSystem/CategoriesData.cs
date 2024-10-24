using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POS_InventoryManagementSystem
{
    internal class CategoriesData
    {
        
        public int ID { get; set; }         
        public string Category { get; set; } 
        public string Date { get; set; }     

        
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

           
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

            try
            {
                
                connect.Open();

               
                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                   
                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData
                        {
                            ID = (int)reader["id"],          
                            Category = reader["category"].ToString(), 
                            Date = reader["date"].ToString()  
                        };

                        listData.Add(cData);
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
