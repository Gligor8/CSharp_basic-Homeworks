using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Car : WheeledVehicle
    {
        public EngineType Engine { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public Car()
        {

        }

        public Car(EngineType engine)
        {
            Engine = engine;
        }

        Car() : base("car")
        {

        }

        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public override void Repair()
        {
            Console.WriteLine("Cars need a special treatment");
        }
    }
}
