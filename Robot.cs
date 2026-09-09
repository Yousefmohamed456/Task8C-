using System;
using System.Collections.Generic;
using System.Text;
using task8.Interface;

namespace task8
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot's normal Walk method");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking through IWalkable");
        }
    }
}
