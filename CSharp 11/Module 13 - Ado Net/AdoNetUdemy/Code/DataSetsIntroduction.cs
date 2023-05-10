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
    internal class DataSetsIntroduction
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

                    var query = @"PeopleAndProducts";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            var ds = new DataSet();
                            adapter.Fill(ds);

                            var tablePeople = ds.Tables[0];
                            var tableProducts = ds.Tables[1];

                            Console.WriteLine("--People Table--");
                            foreach (DataRow row in tablePeople.Rows)
                            {
                                Console.WriteLine($"{row["Id"]} | {row["Name"]}");
                            }

                            Console.WriteLine();

                            Console.WriteLine("--Product Table--");
                            foreach (DataRow row in tableProducts.Rows)
                            {
                                Console.WriteLine($"{row["Id"]} | {row["Name"]} | {row["Price"]}");
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
