using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class EqualityWithStructs
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

            public override bool Equals(object? obj)
            {
                return obj is Point point &&
                       X == point.X &&
                       Y == point.Y;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(X, Y);
            }

            public static bool operator ==(Point p1, Point p2)
            {
                return p1.X == p2.X && p1.Y == p2.Y;
            }

            public static bool operator !=(Point p1, Point p2)
            {
                return !(p1 == p2);
            }

            public void TheCode()
            {
                var pointA = new Point(1, 2);
                var pointB = new Point(1, 2);
                var areEqual = pointA == pointB;

                Console.WriteLine(areEqual);
            }
        }
    }
}
