using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicleList = new List<Vehicles>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Cars accord = new Cars() { HasTrunk = true, Make = "Honda", Model = "Accord", Year = "2006" };
            Motorcycles motorcycles = new Motorcycles() { HasSidecart = true, Year = "2021", Model = "Ural", Make = "CT" };
            Vehicles tc = new Cars() { Make = "Scion", Model = "TC", Year = "2013", HasTrunk = true };
            Vehicles crf = new Motorcycles() { Year = "2022", Model = "CRF125F", Make = "Honda", HasSidecart = false };
            vehicleList.Add(accord);
            vehicleList.Add(motorcycles);
            vehicleList.Add(tc);
            vehicleList.Add(crf);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach (var v in vehicleList)
            {
                Console.WriteLine($"Make: {v.Make} \n" +
                                  $"Model: {v.Model}\n" +
                                  $"Year: {v.Year}");
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            accord.DriveAbstract();
            accord.DriveVirtual();
            
            crf.DriveAbstract();
            crf.DriveVirtual();


            #endregion
            Console.ReadLine();
        }
    }
}
