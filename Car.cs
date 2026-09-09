using System;
using System.Collections.Generic;
using System.Text;
using task8.Interface;

namespace task8
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
