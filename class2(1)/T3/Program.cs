using System;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task3
            Console.WriteLine("Task 3");


            Console.WriteLine("Enter the First number:");
            bool Numb1 = int.TryParse(Console.ReadLine(), out int Nummer1);

            Console.WriteLine("Enter the Second number:");
            bool Numb2 = int.TryParse(Console.ReadLine(), out int Nummer2);

            Nummer1 = Nummer2;
            Nummer2 = Nummer1;


            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + Nummer1);
            Console.Write("\nSecond Number : " + Nummer2);
            Console.ReadLine();
            #endregion
        }
    }
}
