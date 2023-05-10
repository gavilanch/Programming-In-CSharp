using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetUdemy.Code
{
    internal class Scalars
    {
        public async Task TheCode(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args).Build();

            var configuration = host.Services.GetService<IConfiguration>()!;

            var connectionString = configuration.GetConnectionString("DefaultConnection");


            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection opened");

                    var query = @"SELECT COUNT(*)
                    FROM People";

                    using (var command = new SqlCommand(query, connection))
                    {
                        var amountOfRecords = await command.ExecuteScalarAsync();
                        Console.WriteLine("Amount of records: " + amountOfRecords);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not open the connection");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The end");

            await host.RunAsync();
        }
    }
}
