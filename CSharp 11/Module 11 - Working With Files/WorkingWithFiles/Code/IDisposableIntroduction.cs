using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class IDisposableIntroduction
    {
        public void TheCode()
        {
            // Good for big methods
            using (var sw =
    new StreamWriter(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\custom.txt",
    append: true))
            {
                sw.WriteLine("Good morning");
                sw.Write("In this letter ");
                sw.WriteLine($"I inform you that the time is {DateTime.Now.ToString("hh:mm:sss")}");
                sw.Write("bye");
                //sw.Dispose();
            } // Dispose gets executed

            UseSW();

            Console.WriteLine("The end");

            Console.Read();

            void UseSW()
            {
                // Good for small methods
                using var sw = new StreamWriter(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\custom.txt", append: true);
                sw.WriteLine("Good morning");
                sw.Write("In this letter ");
                sw.WriteLine($"I inform you that the time is {DateTime.Now.ToString("hh:mm:sss")}");
                sw.Write("bye");
                //sw.Dispose();
            }
        }
    }
}
