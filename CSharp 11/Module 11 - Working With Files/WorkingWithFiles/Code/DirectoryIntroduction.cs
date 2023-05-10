using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class DirectoryIntroduction
    {
        public void TheCode()
        {
            // Note: In your machine, the routes will be different.

            var route = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\My Directory\Sub 1\Sub 2";

            // Creating a new directory
            Directory.CreateDirectory(route);

            var routeToEnumerate = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles";
            
            // We can list the directories in a route
            var routes = Directory.EnumerateDirectories(routeToEnumerate, "*",
                    SearchOption.AllDirectories);

            foreach (var item in routes)
            {
                Console.WriteLine(item);
            }

            // We can list the files in a route
            var routesFiles = Directory.EnumerateFiles(routeToEnumerate, "*.json",
                    SearchOption.AllDirectories);

            foreach (var item in routesFiles)
            {
                Console.WriteLine(item);
            }

            // We can delete directories (they must exist first, for that we can use: Directory.Exists)
            Directory.Delete(@"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\My Directory\Sub 1\Sub 2");
        }
    }
}
