using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Trainer : User
    {
        public int WeeklyClasses { get; set; }
        public int NumberOfSubjects { get; set; }
        protected int Salary { get; set; }

        public Trainer()
        {

        }

        public Trainer(int id, string username, string password) : base()
        {
            Console.WriteLine();
        }
    }
}
