using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class StreamReaderIntroduction
    {
        public void TheCode()
        {
            var route = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\people.csv";
            var routeBigFile = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\people big.csv";

            //using (var sw = new StreamWriter(routeBigFile, append: false))
            //{
            //    for (int i = 1; i <= 10_000_000; i++)
            //    {
            //        sw.WriteLine($"{i},Person {i}, {i}.00");
            //    }
            //}

            //using (var sr = new StreamReader(route))
            //{
            //    var line = sr.ReadLine();
            //    while (line is not null)
            //    {
            //        Console.WriteLine(line);
            //        line = sr.ReadLine();
            //    }
            //}

            var watch = new Stopwatch();

            watch.Start();

            var firstLine = File.ReadAllLines(routeBigFile)[0];

            watch.Stop();

            Console.WriteLine(firstLine);
            Console.WriteLine($"Duration for File.ReadAllLines: {watch.ElapsedMilliseconds / 1000.0} seconds");

            watch.Restart();

            string firstLine_V2;

            using (var sr = new StreamReader(routeBigFile))
            {
                firstLine_V2 = sr.ReadLine()!;
                watch.Stop();
            }

            Console.WriteLine(firstLine_V2);
            Console.WriteLine($"Duration for StreamReader: {watch.ElapsedMilliseconds / 1000.0} seconds");

        }
    }
}
