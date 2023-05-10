using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class WhatIsParallelFor
    {
        public void TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            Console.WriteLine("--Let's count from 1 to 10 sequentially--");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--Let's count from 1 to 10 in parallel--");

            Parallel.For(1, 11, i => Console.WriteLine(i));

            loadingGif.Visible = false;
        }
    }
}
