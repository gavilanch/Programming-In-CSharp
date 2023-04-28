using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class DefaultImplementationInInterfaces
    {
        internal interface IFileStorage
        {
            string Save(string file);
            void Delete(string fileURL);
            string Edit(string fileURL, string file)
            {
                Delete(fileURL);
                return Save(file);
            }
        }

        internal class AWSFileStorage : IFileStorage
        {
            public void Delete(string fileURL)
            {
                Console.WriteLine("deleting the file from aws...");
            }

            public string Save(string file)
            {
                Console.WriteLine("Saving the file to aws...");
                return "AWS's file url";
            }

            public string Edit(string fileURL, string file)
            {
                Console.WriteLine("New implementation of edit");
                return "";
            }
        }

        internal class AzureFileStorage : IFileStorage
        {
            public void Delete(string fileURL)
            {
                Console.WriteLine("deleting the file from azure...");
            }

            public string Save(string file)
            {
                Console.WriteLine("Saving the file to azure...");
                return "Azure's file url";
            }
        }

        public void TheCode(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder = hostBuilder.ConfigureServices(CustomConfigureServices);
            using var host = hostBuilder.Build();

            var fileStorage = host.Services.GetRequiredService<IFileStorage>();
            fileStorage.Edit("", "");

            Console.WriteLine("The end");

            void CustomConfigureServices(IServiceCollection services)
            {
                services.AddTransient<IFileStorage, AzureFileStorage>();
                services.AddTransient<MoviesController>();
                services.AddTransient<AnotherPlace>();
            }
        }
    }
}
