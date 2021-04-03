using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("SumOfEven");

            
            bool firstInteger = int.TryParse(Console.ReadLine(), out int integerNo1);
            Console.WriteLine("Enter integer no.1:");
            
            bool secondInteger = int.TryParse(Console.ReadLine(), out int integerNo2);
            Console.WriteLine("Enter integer no.2:");
            
            bool thirdInteger = int.TryParse(Console.ReadLine(), out int integerNo3);
            Console.WriteLine("Enter integer no.3:");
            
            bool forthInteger = int.TryParse(Console.ReadLine(), out int integerNo4);
            Console.WriteLine("Enter integer no.4:");
            
            bool fifthInteger = int.TryParse(Console.ReadLine(), out int integerNo5);
            Console.WriteLine("Enter integer no.5:");
            
            bool sixthInteger = int.TryParse(Console.ReadLine(), out int integerNo6);
            Console.WriteLine("Enter integer no.6:");            

            int result = 0;
            

            int[] array = new int[6]; 
            array[0] = integerNo1;
            array[1] = integerNo2;
            array[2] = integerNo3;
            array[3] = integerNo4;
            array[4] = integerNo5;
            array[5] = integerNo6;
        
            
        for(int i = 0; i < array.Length; i++) {
                if ((integerNo1 % 2 == 0) == true)
                {
                    result += array[i];
                }
                else
                    break;
               if ((integerNo2 % 2 == 0) == true)
                {
                    result += array[i];
                }
                else break;
               if ((integerNo3 % 2 == 0) == true)
                {
                    result += array[i];
                }
                else break;
               if ((integerNo4 % 2 == 0) == true)
                {
                    result += array[i];
                }
                else break;
               if ((integerNo5 % 2 == 0) == true)
                {
                    result += array[i];
                }
                else break;
               if ((integerNo6 % 2 == 0) == true)
                {
                    result += array[i];
                }
                else break;
            }
            
            Console.WriteLine("The sum of all even numbers is:" + result);
            
            Console.ReadLine();
            #endregion
        }
    }
}
