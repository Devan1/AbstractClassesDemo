using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool hasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"the car is driving. ");
        }
    }
}
