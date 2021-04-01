using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Task 1");


            Console.WriteLine("Type a number, and then press Enter:");
            bool firstNumInput = int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Type an operator, and then press Enter:");
            bool operat = char.TryParse(Console.ReadLine(), out char operand);

            Console.WriteLine("Type another number, and then press Enter:");
            bool secondNumInput = int.TryParse(Console.ReadLine(), out int num2);


            int result = 0;


            if (operand == '+')
            {
                Console.WriteLine(result = num1 + num2);
            }
            else if (operand == '-')
            {
                Console.WriteLine(result = num1 - num2);
            }
            else if (operand == '*')
            {
                Console.WriteLine(result = num1 * num2);
            }
            else if (operand == '/')
            {
                Console.WriteLine(result = num1 / num2);
            }

            Console.ReadLine();
            #endregion
        }
    }
}
