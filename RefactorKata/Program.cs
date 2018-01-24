using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RefactorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Add connection string to config once config is taught
            using (var conn = new SqlConnection("Server=.;Database=myDataBase;User Id=myUsername;Password = myPassword;"))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Products";

                var reader = cmd.ExecuteReader();
                var products = new List<Product>();

                //TODO: Replace with Dapper once Dapper is taught
                while (reader.Read())
                {
                    var prod = new Product { name = reader["Name"].ToString() };
                    products.Add(prod);
                }

                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }
            }
        }
    }
}
