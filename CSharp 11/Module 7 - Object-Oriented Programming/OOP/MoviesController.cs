using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
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
}
