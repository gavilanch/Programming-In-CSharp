using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class ConstructorInyection
    {
        internal interface IFileStorage
        {
            string Save(string file);
            void Delete(string fileURL);
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

        public void TheCode()
        {
            var azureFileStorage = new AzureFileStorage();
            var awsFileStorage = new AWSFileStorage();

            var moviesController = new MoviesController(azureFileStorage);

            moviesController.SavePoster("the poster.jpg");
            moviesController.DeletePoster("the poster.jpg");

        }
    }
}
