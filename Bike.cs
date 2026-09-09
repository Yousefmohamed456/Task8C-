using System;
using System.Collections.Generic;
using System.Text;
using task8.Interface;

namespace task8
{
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}
