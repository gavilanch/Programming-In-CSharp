using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class StructsIntro
    {
        internal struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public double Distance(Point b) => Math.Sqrt(Math.Pow(b.X - X, 2) + Math.Pow(b.Y - Y, 2));
        }

        public void TheCode()
        {
            var car = new Car();
            // We can make an instance of a class null because it's a reference type
            car = null;

            var pointA = new Point(3, 5);

            // Error: We can't make an instance of a struct null because it's a value type
            //pointA = null;

            Console.WriteLine(pointA.X);

            var pointB = new Point();

            Console.WriteLine("The distance between (3,5) and (0,0) is " + pointA.Distance(pointB));
        }
    }
}
