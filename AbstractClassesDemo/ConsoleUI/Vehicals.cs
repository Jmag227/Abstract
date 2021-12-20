using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract string Year { get; set; }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("I don't know how to use .base!");
        }
    }
}
