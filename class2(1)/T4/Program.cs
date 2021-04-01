using System;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            Console.WriteLine("Task 4");


            Console.WriteLine("Enter the First number:");
            bool Number1 = int.TryParse(Console.ReadLine(), out int Numero1);



            if (Numero1 % 3 == 0)
            {
                Console.WriteLine("Tik");
            }
            else if (Numero1 % 5 == 0)
            {
                Console.WriteLine("Tak");
            }
            else if (Numero1 % 5 == 0 && Numero1 % 3 == 0)
            {
                Console.WriteLine("Tak - Tak");
            }
            else
            {
                Console.WriteLine("Bad Number");
            }

            Console.ReadLine();
            #endregion
        }
    }
}
