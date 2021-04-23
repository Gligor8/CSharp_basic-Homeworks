using ClassLibrary1;
using System;

namespace AcademyManagementApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your role: \n1) Admin \n2) Trainer \n3 Student");
            bool pickedNum = int.TryParse(Console.ReadLine(), out int chosenNum);
            if (!pickedNum)
            {
                Console.WriteLine("Only a number is accepted!");
               
            }
            switch (chosenNum)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    //Login(users, username, password);
                    
                break;    
                default:
                    Console.WriteLine("Please enter a number from 1-3!");
                    break;

            
                    
            }
            Admin[] admin = new Admin[]
            {
                new Admin(34, "Toto44", "angufert55"),
                new Admin(353, "Funer43", "zeder55734"),
                new Admin(2, "Blumenthal3", "aufwand554")
            };

            Trainer[] trainer = new Trainer[]
            {
            new Trainer(38, "Tlto44", "angufert545"),
            new Trainer(67, "Fugger43", "zeder534"),
            new Trainer(9, "Zedermann3", "aufwand854")
            };

            Student[] student = new Student[]
            {
            new Student(38, "glocner55", "angst55"),
            new Student(325, "Funder63", "zz55734"),
            new Student(64, "Ehrenstein53", "ausser554")
            };
        }
    }
}
