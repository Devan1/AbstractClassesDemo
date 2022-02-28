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
             * Done- Create an abstract class called Vehicle                                                                                                            
             * Done- The vehicle class shall have three string properties Year, Make, and Model                                                    
             * Done- Set the defaults to something generic in the Vehicle class
             * Done- Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done- Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done- Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Done- Provide the implementations for the abstract methods
             * Done- Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car firstCar = new Car { hasTrunk = false, Year = "2016", Make = "Toyota", Model = "Tundra" };
            Motorcycle firstMotorcycle = new Motorcycle { hasSidecar = true, Year = "2019", Make = "Hondra", Model = "CBR1000" };
            Car secondCar = new Car { hasTrunk = true, Year = "2020", Make = "Chevy", Model = "Impala" };
            Motorcycle secondMotorcycle = new Motorcycle { hasSidecar = false, Year = "2020", Make = "Kawasaki", Model = "Ninja" };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(firstCar);
            vehicles.Add(secondCar);
            vehicles.Add(firstMotorcycle);
            vehicles.Add(secondMotorcycle);
            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Year: {veh.Year}\nMake: {veh.Make}\nModel: {veh.Model}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine();
                
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
