using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2016";
        public string Make { get; set; } = "Default make";
        public string Model { get; set; } = "Default model";
        public abstract void DriveAbstract(); //Stubbed out method.
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Virtually driving");
        }
    }


}
 