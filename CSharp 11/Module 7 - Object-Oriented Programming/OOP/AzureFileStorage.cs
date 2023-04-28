using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class AzureFileStorage: IFileStorage
    {
        public void Delete(string fileURL)
        {
            Console.WriteLine("deleting the file from azure...");
        }

        public string Save(string file)
        {
            Console.WriteLine("Saving the file to azure...");
            return "Azure's file url";
        }
    }
}
