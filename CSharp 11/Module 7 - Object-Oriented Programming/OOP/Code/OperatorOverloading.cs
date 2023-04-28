using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class OperatorOverloading
    {
        internal class Vector2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public static Vector2D operator +(Vector2D v1, Vector2D v2)
            {
                return new Vector2D { X = v1.X + v2.X, Y = v1.Y + v2.Y };
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        public void TheCode()
        {
            var v1 = new Vector2D { X = 1, Y = 2 };
            var v2 = new Vector2D { X = 3, Y = 4 };
            var v3 = v1 + v2;

            Console.WriteLine($"{v1} + {v2} = {v3}");
        }
    }
}
