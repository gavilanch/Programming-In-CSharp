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
    internal class OutputParameters
    {
        public async Task TheCode(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args).Build();

            var configuration = host.Services.GetService<IConfiguration>()!;

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            Console.Write("Write the name of the person: ");
            var name = Console.ReadLine();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection opened");

                    var query = @"People_Insert";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        var parameterId = new SqlParameter
                        {
                            ParameterName = "@id",
                            Direction = System.Data.ParameterDirection.Output,
                            DbType = System.Data.DbType.Int32
                        };

                        command.Parameters.Add(parameterId);

                        command.Parameters.Add(new SqlParameter("@name", name));
                        var rowsAffected = await command.ExecuteNonQueryAsync();
                        Console.WriteLine("Affected rows: " + rowsAffected);

                        var id = (int)parameterId.Value;
                        Console.WriteLine($"Id of the person: " + id);
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
