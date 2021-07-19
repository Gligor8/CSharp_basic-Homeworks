using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Employee : Member
    {
        public int Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public int Bonus { get; set; }

        public Employee()
        {

        }

        public Employee(string firstname, string lastname, int age, string username, string password, int phonenumber, DateTime dateofregistration, int salary, int hoursProM, int bonus) : base()
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            PhoneNumber = phonenumber;
            DateOfRegistration = dateofregistration;
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
