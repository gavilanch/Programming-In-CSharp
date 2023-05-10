using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class TaskWhenAllIntroduction
    {
        public async Task TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            var sw = new Stopwatch();
            sw.Start();

            var tasks = new List<Task>
            {
                  DoLongProccessingA(),
                  DoLongProccessingB(),
                  DoLongProccessingC()
            };

            await Task.WhenAll(tasks);

            sw.Stop();

            var message = $"The program took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.";

            Console.WriteLine(message);

            loadingGif.Visible = false;
        }

        private async Task DoLongProccessingA()
        {
            await Task.Delay(1000);
            Console.WriteLine("Process A finished");
        }

        private async Task DoLongProccessingB()
        {
            await Task.Delay(1000);
            Console.WriteLine("Process B finished");
        }

        private async Task DoLongProccessingC()
        {
            await Task.Delay(1000);
            Console.WriteLine("Process C finished");
        }
    }
}
