using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycles : Vehicles
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override string Year { get; set; }

        public bool HasSidecart { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("It drives... Very fast.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Vroom");
        }
    }
}
