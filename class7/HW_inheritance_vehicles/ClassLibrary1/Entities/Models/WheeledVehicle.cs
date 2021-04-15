using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Type { get; set; }

        public WheeledVehicle()
        {

        }

        public WheeledVehicle(string type)
        {
            Type = type;
        }

        public void Repair()
        {
            Console.WriteLine("Sending it to a mechanics workshop");
        }
    }
}
