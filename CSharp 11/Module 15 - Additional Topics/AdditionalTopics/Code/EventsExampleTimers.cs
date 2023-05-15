using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class EventsExampleTimers
    {
        public void TheCode()
        {
            var myTimer = new System.Timers.Timer(1000);
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_ElapsedPrintMyName;
            myTimer.Start();
            Console.ReadLine();

            Console.WriteLine("We are not going to print my name anymore");
            myTimer.Elapsed -= MyTimer_ElapsedPrintMyName;

            Console.ReadLine();

            Console.WriteLine("The end");
        }

        void MyTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }

        void MyTimer_ElapsedPrintMyName(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Felipe");
        }
    }
}
