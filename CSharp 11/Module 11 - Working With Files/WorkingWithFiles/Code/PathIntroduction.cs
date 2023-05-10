using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class PathIntroduction
    {
        public void TheCode()
        {
            // Example 1: Getting the filename and extension
            var routeToEnumerate = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles";

            var routesFiles = Directory.EnumerateFiles(routeToEnumerate, "*",
                    SearchOption.AllDirectories);

            foreach (var item in routesFiles)
            {
                var fileName = Path.GetFileName(item);
                var extension = Path.GetExtension(item);
                 Console.WriteLine($"File name: {fileName} - extension: {extension}");
            }

            // Example 2: Combining routes

            var route1 = @"C:\Users\ASUS";
            var route2 = @"source\OD";

            var combinedRoutes = Path.Combine(route1, route2);
            Console.WriteLine(combinedRoutes);
        }
    }
}
