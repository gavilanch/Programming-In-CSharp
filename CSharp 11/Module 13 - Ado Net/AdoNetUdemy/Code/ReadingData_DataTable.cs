using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetUdemy.Code
{
    internal class ReadingData_DataTable
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

                    var query = @"SELECT *
                    FROM People";

                    using (var command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                Console.WriteLine($"{row["Id"]} | {row["Name"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The end");

            await host.RunAsync();
        }
    }
}
