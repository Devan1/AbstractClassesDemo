using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool hasSidecar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($"The motorcycle is driving. ");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Doing alot of virtual driving here. ");
        }
    }
}
