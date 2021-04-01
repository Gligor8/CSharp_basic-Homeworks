using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            #region Task 2
            Console.WriteLine("Task 2");


            Console.WriteLine("Enter the First number:");
            bool Number1 = int.TryParse(Console.ReadLine(), out int Nummer1);

            Console.WriteLine("Enter the Second number:");
            bool Number2 = int.TryParse(Console.ReadLine(), out int Nummer2);

            Console.WriteLine("Enter the Third number:");
            bool Number3 = int.TryParse(Console.ReadLine(), out int Nummer3);

            Console.WriteLine("Enter the Forth number:");
            bool Number4 = int.TryParse(Console.ReadLine(), out int Nummer4);

            int result = (Nummer1 + Nummer2 + Nummer3 + Nummer4) / 4;
            Console.WriteLine(result);
            Console.ReadLine();
            #endregion
        }
    }
}
