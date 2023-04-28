using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
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
}
