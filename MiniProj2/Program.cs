using Microsoft.Data.SqlClient;
using System;

namespace MiniProj2
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateToDatabase();
            ReadFromDatabase();
            /*using (var context = new MiniProj2context())
             {
                 var lap = new Laptop()
                 {
                     Name = "Macbook",
                     Model = "Air",
                     PurchaseDate = 2020 - 05 - 13

                 };
                 context.laptops.Add(lap);
                 context.SaveChanges();

                
            }*/

            Console.ReadLine();
            
        }

         private static void CreateToDatabase()
        {
            Console.WriteLine("Create data in MiniProj2 database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniProj2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Laptop(Name, Model, PurchaseDate) VALUES(@name, @model, @purchaseDate)", connection))
                {
                    command.Parameters.AddWithValue("@name", "Macbook");
                    command.Parameters.AddWithValue("@model", "Air");
                    command.Parameters.AddWithValue("@purchaseDate", 2020-05-19);
                    command.ExecuteNonQuery();
                }
            }

        }

        private static void ReadFromDatabase()
        {
            Console.WriteLine("Read data from MiniProj2 database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniProj2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM MiniProj2", connection))
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                    }
                    
                }
            }

        }

        private static void UpdateInDatabase()
        {
            Console.WriteLine("Update data in MiniProj2 database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniProj2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand("Update MiniProj2 SET Model = @model WHERE Name = @name", connection))
                {
                    command.Parameters.AddWithValue("@name", "Macbook");
                    command.Parameters.AddWithValue("@model", "Pro");
                    command.ExecuteReader();
                }
            }

        }

        private static void DeleteFromDatabase()
        {
            Console.WriteLine("Delete data from MiniProj2 database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniProj2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM MiniProj2 WHERE Name = @name", connection))
                {
                    command.Parameters.AddWithValue("@name", "Macbook");
                    command.ExecuteReader();
                }
            }

        }
    }

   
    
}
