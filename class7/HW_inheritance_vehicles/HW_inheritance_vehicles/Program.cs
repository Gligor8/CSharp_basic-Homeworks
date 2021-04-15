using System;


namespace HW_inheritance_vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car jaguar_X = new Car()
            {
                Manufacturer = "Jaguar",
                Model = "X-Type",
                NumberOfWheels = 4,
                Engine = 1,
                FuelConsumption = 4,
                MaxSpeed = 220,
            };
            jaguar_X.drive();

            ElectricCar tesla_3 = new ElectricCar()
            {
                Manufacturer = "Tesla",
                Model = "T3",
                NumberOfWheels = 4,
                Engine = 3,
                MaxSpeed = 190,
                BatteryCapacity = 36,
                BatteryPercentage = 70,
            };
            tesla_3.Recharge();
            tesla_3.MaxSpeedWhenOnBattery();

            Bicycle mountBike = new Bicycle()
            {
                Manufacturer = "Mount Bike",
                Model = "AG-6",
                NumberOfWheels = 2,
                NumberOfSpeedLevels = 24,
                IsElectric = false,

            };
            mountBike.Repair();
            mountBike.Ride();
        }

        
    }
}
