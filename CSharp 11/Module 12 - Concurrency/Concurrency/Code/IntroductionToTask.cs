using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class IntroductionToTask
    {
        public async Task TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            // Some processing...
            //Thread.Sleep(5000); // Synchronous
            await DoSomeLongProcessing();
            var name = await GetName();
            MessageBox.Show($"Hello, {name}");

            loadingGif.Visible = false;
        }

        private async Task DoSomeLongProcessing()
        {
            await Task.Delay(5000); // Asynchronous
        }

        private async Task<string> GetName()
        {
            await Task.Delay(100);
            return "Felipe";
        }
    }
}

