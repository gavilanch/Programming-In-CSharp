using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class LockIntroduction
    {
        public void TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            Console.WriteLine("Start");

            //int value1 = 0;
            //int value2 = 0;

            //Parallel.For(0, 10_000, _ =>
            //{
            //    Interlocked.Increment(ref value1);
            //    Interlocked.Add(ref value2, value1);
            //});

            //Console.WriteLine($"Value1: {value1}");
            //Console.WriteLine($"Value2: {value2}");

            var valueIncremented = 0;
            var valueSum = 0;

            // mutex = mutually exclusive
            var mutex = new object();

            Parallel.For(0, 10_000, _ =>
            {
                // do several operations in parallel...

                // will be executed sequentially
                lock (mutex)
                {
                    valueIncremented++;
                    valueSum += valueIncremented;
                }

                // do several operations in parallel...
            });

            Console.WriteLine($"valueIncremented: {valueIncremented}");
            Console.WriteLine($"valueSum: {valueSum}");

            Console.WriteLine("The end");

            loadingGif.Visible = false;
        }
    }
}
