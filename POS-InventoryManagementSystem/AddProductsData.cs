using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POS_InventoryManagementSystem
{
    internal class AddProductsData
    {
        public int ID { get; set; }
        public string ProdID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddProductsData apData = new AddProductsData
                            {
                                ID = (int)reader["id"],
                                ProdID = reader["prod_id"].ToString(),
                                ProdName = reader["prod_name"].ToString(),
                                Category = reader["category"].ToString(),
                                Price = reader["price"].ToString(),
                                Stock = reader["stock"].ToString(),
                                ImagePath = reader["image_path"].ToString(),
                                Status = reader["status"].ToString(),
                                Date = reader["date_insert"].ToString()
                            };

                            listData.Add(apData);
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
            }

            return listData;
        }

        public List<AddProductsData> allAvailableProducts()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddProductsData apData = new AddProductsData
                            {
                                ID = (int)reader["id"],
                                ProdID = reader["prod_id"].ToString(),
                                ProdName = reader["prod_name"].ToString(),
                                Category = reader["category"].ToString(),
                                Price = reader["price"].ToString(),
                                Stock = reader["stock"].ToString(),
                                ImagePath = reader["image_path"].ToString(),
                                Status = reader["status"].ToString(),
                                Date = reader["date_insert"].ToString()
                            };

                            listData.Add(apData);
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
            }

            return listData;
        }
    }
}
