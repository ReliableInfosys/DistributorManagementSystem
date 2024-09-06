using System;
using System.Data.SqlClient;

namespace ConnectionStringChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace this with your actual connection string
            string connectionString = "Server=localhost;Database=DistributerManagementSystem;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection Successful!");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Connection Failed!");
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
