using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class InterlockedIntroduction
    {
        public void TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            Console.WriteLine("Start");
            var valueWithoutIntelocked = 0;

            Parallel.For(0, 1_000_000, _ => valueWithoutIntelocked++);

            Console.WriteLine($"Sum without interlocked: {valueWithoutIntelocked}");

            var valueWithInterlocked = 0;

            Parallel.For(0, 1_000_000, _ => Interlocked.Increment(ref valueWithInterlocked));

            Console.WriteLine($"Sum with interlocked: {valueWithInterlocked}");

            Console.WriteLine("The end");

            loadingGif.Visible = false;
        }
    }
}
