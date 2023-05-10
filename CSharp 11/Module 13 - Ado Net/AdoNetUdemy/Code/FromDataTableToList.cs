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
    internal class FromDataTableToList
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

                    var query = @"People_Read";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            var people = dt.AsEnumerable().Select(row => new Person
                            {
                                Id = row.Field<int>("Id"),
                                Name = row.Field<string>("Name")!
                            }).ToList();

                            foreach (var person in people)
                            {
                                Console.WriteLine($"Id: {person.Id}; Name: {person.Name}");
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
