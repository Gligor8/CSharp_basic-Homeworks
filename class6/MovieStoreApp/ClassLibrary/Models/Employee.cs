using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    class Employee : Member
    {
        private int Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public int Bonus { get; set; }

        public Employee()
        {

        }

        public Employee(int salary, int hoursProM, int bonus)
        {
            Salary = salary;
            HoursPerMonth = hoursProM;
            Bonus = bonus;
        }

        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = (Salary / 30) * 100;
            }
            else if (HoursPerMonth < 160)
            {
                Bonus = 0;
            }
        }

        public void SetSalary()
        {
            Salary = HoursPerMonth * Bonus;
        }

    }
}
