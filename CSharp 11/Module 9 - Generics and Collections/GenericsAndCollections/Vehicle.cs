using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    internal class Vehicle
    {
    }

    internal class Car: Vehicle
    {

    }

    internal class Truck : Vehicle
    {
        public Truck(string brand)
        {
            Brand = brand;
        }

        public string Brand { get; }
    }
}
