using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2
            Console.WriteLine("Task2 - Student Group");

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            bool numbro = int.TryParse(Console.ReadLine(), out int groupNum);
            

            string[] Group1 = new string[5];
            Group1[0] = "Nancy";
            Group1[1] = "Steve";
            Group1[2] = "Richard";
            Group1[3] = "Sophie";
            Group1[4] = "Francis";

            string[] Group2 = new string[5];
            Group1[0] = "Michaela";
            Group1[1] = "Britta";
            Group1[2] = "Charles";
            Group1[3] = "George";
            Group1[4] = "Julie";

            if (groupNum == 1)
            {
                foreach (string student in Group1)
                {
                    Console.WriteLine(student);
                }
                Console.ReadLine();
            }
            else if (groupNum == 2)
            {
                foreach (string pupil in Group2)
                {
                    Console.WriteLine(pupil);
                }
                Console.ReadLine();
            }

            else
                Console.WriteLine("Nonexistent group number!");
            

            Console.ReadLine();
            #endregion
        }
    }
}
