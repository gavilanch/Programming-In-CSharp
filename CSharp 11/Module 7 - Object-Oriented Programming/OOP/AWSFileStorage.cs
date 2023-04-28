using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class AWSFileStorage: IFileStorage
    {
        public void Delete(string fileURL)
        {
            Console.WriteLine("deleting the file from aws...");
        }

        public string Save(string file)
        {
            Console.WriteLine("Saving the file to aws...");
            return "AWS's file url";
        }

        public string Edit(string fileURL, string file)
        {
            Console.WriteLine("New implementation of edit");
            return "";
        }
    }
}
