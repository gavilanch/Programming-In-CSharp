using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class SharingCodeWithInterfaces
    {
        internal interface IFileStorage
        {
            string Save(string file);
        }

        internal class AWSFileStorage : IFileStorage
        {
            public string Save(string file)
            {
                Console.WriteLine("Saving the file to aws...");
                return "AWS's file url";
            }
        }

        internal class AzureFileStorage : IFileStorage
        {
            public string Save(string file)
            {
                Console.WriteLine("Saving the file to azure...");
                return "Azure's file url";
            }
        }

        internal class MoviesController
        {
            internal void SavePoster(string poster, IFileStorage fileStorage)
            {
                // reuse...
                fileStorage.Save(poster);
                // reuse...
            }
        }

        public void TheCode()
        {
            var moviesController = new MoviesController();

            var azureFileStorage = new AzureFileStorage();
            var awsFileStorage = new AWSFileStorage();

            moviesController.SavePoster("the poster.jpg", awsFileStorage);
        }
    }
}
