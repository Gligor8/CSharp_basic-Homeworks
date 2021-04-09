using System;

namespace CSharp_basic_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to register or to login? (Write \"login\" to signIn & \"register\")");
            string login = Console.ReadLine();
            string register = Console.ReadLine();

            if (login == "login")
            {

            }
            
            else if (register == "register")
            {

            }
            

            else Console.WriteLine("Invalid choice!");

            Console.WriteLine("ID number:");

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Username:");
            string usern = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();

            Console.WriteLine("Type a Message:");
            string message = Console.ReadLine();

        }

        string[] registeredUsers;

        public class User
        {
            public User ()
            {

            }

            public string ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            
            public void Message ()
            {
                Console.WriteLine();
            }

        }

    }
}
