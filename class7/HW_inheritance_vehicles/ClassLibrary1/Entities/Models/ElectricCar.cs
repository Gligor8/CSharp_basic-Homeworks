using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class ElectricCar
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

        public ElectricCar()
        {

        }

        ElectricCar() : base("electricCar")
        {

        }

        public void Recharge()
        {
            if (BatteryPercentage <= 10)
            {
                Console.WriteLine("1 hour till fully charged");
            }
            else if (BatteryPercentage <= 50)
            {
                Console.WriteLine("30 minutes till fully charged");
            }
            else if (BatteryPercentage <= 80)
            {
                Console.WriteLine("15 minutes till fully charged");
            }
        }

        public void MaxSpeedWhenOnBattery()
        {
            if (BatteryCapacity >= 40)
            {
                Console.WriteLine("The max speed is 200km/h in 9 sec");
            }
            else if (BatteryCapacity >= 30)
            {
                Console.WriteLine("The max speed is 150km/h in 7 sec");
            }
            else if (BatteryPercentage <= 25)
            {
                Console.WriteLine("The max speed is 120km/h in 6.5 sec");
            }
        }
       
    }
}
