using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }

        public Bicycle()
        {

        }

        Bicycle() : base("bicycle")
        {

        }

        public void Ride()
        {
            Console.WriteLine("The bike is being ridden");
        }

        public override void Repair()
        {
            Console.WriteLine("The chain of a bike should be oiled on a regular basis!");
        }
    }
}
