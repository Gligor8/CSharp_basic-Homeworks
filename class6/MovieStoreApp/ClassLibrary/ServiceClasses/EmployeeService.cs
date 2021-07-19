using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ServiceClasses
{
    public class EmployeeService : Employee 
    {

        static public void showAllUsers(List<User> allUsers)
        {
            Console.WriteLine("List of All Users:");

            for (int i = 0; i < allUsers.Count; i++)
            {
                Console.Write($"{i + 1} ");
                allUsers[i].DisplayInfo();
            }

        }

        static public void showAllMovies(List<Movie> allMovies)
        {
            Console.WriteLine("List of All Users:");

            for (int i = 0; i < allMovies.Count; i++)
            {
                Console.Write($"{i + 1}. {allMovies[i].Title} ({allMovies[i].Year}) ");
                Console.WriteLine(allMovies[i].isRented == true ? "*" : "");
            }

        }
    }
}
