using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetUdemy.Code
{
    internal class ConnectingToTheDB
    {
        public void TheCode()
        {
            // You must use your own connection string. I leave mine here as a reference.
            var connectionString = "Data Source=LAPTOP-4KBFRF57;Database=AdoNetDemo;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Connection opened");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not open the connection");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The end");
        }
    }
}
