using System;

namespace Task1
{
    class Program
    {
        static void FunWithStrings (string inp)
        {
            
           Console.WriteLine("Type a sentence:");
            inp = Console.ReadLine();
            Console.WriteLine(inp);

            string reverseString = string.Empty;
            foreach (char c in inp)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");

        }
    }
}
