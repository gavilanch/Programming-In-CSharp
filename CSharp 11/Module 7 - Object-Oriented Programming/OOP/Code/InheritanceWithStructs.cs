using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class InheritanceWithStructs
    {
        internal struct Point2D
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        // Error: You can't do this.
        //internal struct Point3D: Point2D
        //{
        //    public int Z { get; set; }
        //}
    }
}
