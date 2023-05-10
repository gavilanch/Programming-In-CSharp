using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class CreatingFilesWithStreamWriter
    {
        public void TheCode()
        {
            var sw =
    new StreamWriter(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\custom.txt",
    append: true);

            sw.WriteLine("Good morning");
            sw.Write("In this letter ");
            sw.WriteLine($"I inform you that the time is {DateTime.Now.ToString("hh:mm:sss")}");
            sw.Write("bye");
            sw.Dispose();
        }
    }
}
