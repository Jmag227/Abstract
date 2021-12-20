using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Cars : Vehicles
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override string Year { get; set; }
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("It drives.");
        }
    }
}
