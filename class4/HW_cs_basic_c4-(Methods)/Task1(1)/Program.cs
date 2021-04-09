using System;

namespace Task1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //static void FunWithStrings(string inp)
            //{

                Console.WriteLine("Type a sentence:");
                string inp = Console.ReadLine();
                

                string reverseString = string.Empty;
                foreach (char c in inp)
                {
                    reverseString = c + reverseString;
                }
            Console.WriteLine("----------------------------------");
            Console.Write($"Reverse String :" + ' ' + reverseString + ' ');
            Console.WriteLine("----------------------------------");
                // -----------------------------------
                // Vowels count

               int vowel = 0;
               
               int len = inp.Length;

                for (int i = 0; i < len; i++)
                {

                    if (inp[i] == 'a' || inp[i] == 'e' || inp[i] == 'i' || inp[i] == 'o' || inp[i] == 'u' || inp[i] == 'A' || inp[i] == 'E' || inp[i] == 'I' || inp[i] == 'O' || inp[i] == 'U')
                    {
                        vowel++;
                    }
                   
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("The total number of vowels is:" + ' ' + vowel);

                // -------------------------------
                // Largest Word

                string[] words = inp.Split(new[] { " " }, StringSplitOptions.None);

                string word = "";
                int count = 0;
                foreach (string item in words)
                {
                    if(item.Length >= count ){
                        word = item;
                        count = item.Length;
                    }
                }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The longest word of the sentence is:"+ ' ' + word);

                // -------------------------------
                // Word Count

                
                int counter = 0;

                for (int index = 0; index <= inp.Length - 1;)
                {
                    if (inp[index] == ' ' || inp[index] == '\n' || inp[index] == '\t')
                    {
                        counter++;
                    }

                    index++;
                }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The word count totals:" + ' ' + count);
                Console.ReadLine();
           // }
        }
    }
}
