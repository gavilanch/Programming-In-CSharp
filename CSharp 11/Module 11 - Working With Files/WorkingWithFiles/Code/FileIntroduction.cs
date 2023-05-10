using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class FileIntroduction
    {
        public void TheCode()
        {
            // Note: In your machine, the routes will be different.

            // Example 1: Reading the content of a file
            var content = File.ReadAllText(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\example.txt");
            Console.WriteLine(content);

            // Example 2: Reading a file line by line
            var lines = File.ReadAllLines(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\example lines.txt");

            // Example 3: You will get an error when trying to access a non-existent file.
            // To avoid this, use File.Exists (as shown below)
            File.ReadAllLines(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\example lines 2.txt");
           
            var fileThatExists = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\example.txt";

            if (File.Exists(fileThatExists))
            {
                var lines2 = File.ReadAllLines(fileThatExists);
                var destinationCopy = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\example copy.txt";
                File.Copy(fileThatExists, destinationCopy, overwrite: true);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }


            Console.WriteLine("The end");
        }
    }
}
