using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class InversionOfControlContainer
    {
        internal interface IFileStorage
        {
            string Save(string file);
            void Delete(string fileURL);
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
        }

        internal class MoviesController
        {
            private readonly IFileStorage fileStorage;

            public MoviesController(IFileStorage fileStorage)
            {
                this.fileStorage = fileStorage;
            }


            internal void SavePoster(string poster)
            {
                // reuse...
                fileStorage.Save(poster);
                // reuse...
            }

            internal void DeletePoster(string posterURL)
            {
                // reuse...
                fileStorage.Delete(posterURL);
                // reuse...
            }
        }

        internal class AnotherPlace
        {
            private readonly MoviesController moviesController;

            public AnotherPlace(MoviesController moviesController)
            {
                this.moviesController = moviesController;
            }


            public void Process()
            {
                moviesController.SavePoster("another.jpg");
            }
        }

        public void TheCode(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder = hostBuilder.ConfigureServices(CustomConfigureServices);
            using var host = hostBuilder.Build();

            var moviesController = host.Services.GetRequiredService<MoviesController>();

            moviesController.SavePoster("the poster.jpg");
            moviesController.DeletePoster("the poster.jpg");

            var anotherPlace = host.Services.GetRequiredService<AnotherPlace>();
            Console.WriteLine("--Using the AnotherPlace class--");
            anotherPlace.Process();

            Console.WriteLine("The end");

            void CustomConfigureServices(IServiceCollection services)
            {
                services.AddTransient<IFileStorage, AWSFileStorage>();
                services.AddTransient<MoviesController>();
                services.AddTransient<AnotherPlace>();
            }
        }
    }
}
