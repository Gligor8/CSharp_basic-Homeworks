using ClassLibrary;
using ClassLibrary.Enums;
using ClassLibrary.Models;
using ClassLibrary.ServiceClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreApp2
{
    public class Program
    {
        

        

        static void Main(string[] args)
        {
            #region Users
            List<User> users = new List<User>
            {
                //new User {FirstName = "gsdg",  LastName = "fasfa", Age = 46, UserName = "asf", Password = "gagasga", PhoneNumber = 2352532, DateOfRegistration = new DateTime(23/05/2015), MemberNumber = 12451  }
            };

            List<Employee> employees = new List<Employee>
            {

            };

            #endregion
            #region Movies
            List<Movie> movies = new List<Movie>
        {
            new Movie{Number = 1, Title = "Career Opportunities", Description = "When night-shift custodian Jim (Frank Whaley) is accidentally locked up alone in the store he cleans, he realizes he has access to the entire building and decides to indulge in the abundance of free food and merchandise at his fingertips. Surprisingly, he bumps into local rich girl Josie (Jennifer Connelly), who is also imprisoned in the store for the night, and they quickly bond. But, just as romantic sparks fly, Josie and Jim are interrupted by two small-time robbers.", Genre = (Genres)9, Year = 1991, isRented = true},
            new Movie{Number = 2, Title = "Casino Royale", Description = "Special Agent James Bond embarks on a mission to prevent Le Chiffre, a mob banker, from winning a high stakes poker game. He is aided by Vesper Lynd, a British Treasury agent.", Genre = (Genres)4, Year = 2006, isRented = false},
            new Movie{Number = 3, Title = "The Breakfast Club", Description = "Five high school students, all with different mindsets, face detainment in their school library on a Saturday morning. As time passes by, their egos fade and they become close buddies.", Genre = (Genres)9, Year = 1985, isRented = true},
            new Movie{Number = 4, Title = "In The Name Of The Father", Description = "Gerry Conlon, a young Irish man living in London, is wrongly sentenced to life in prison with his father after the IRA bombing of 1974. He spends the next 15 years trying to prove his innocence.", Genre = (Genres)5, Year = 1993, isRented = false}
        };


            #endregion

            #region Rented_Movies
            List<User> rentedMovies = new List<User>
            {

            };
            #endregion

            try
            {

                Member user = null;
                User korisnik = null;
                while (true)
                {
                    
                    Console.WriteLine("Press \n1 to access as an employee or \n2 as an user:");
                    int roleChoice = int.Parse(Console.ReadLine());

                    #region Employee

                    
                    if (roleChoice == 1)
                    {
                        Console.WriteLine("Enter your username:");
                        string employeeUsername = Console.ReadLine();
                        
                        users
                            .FirstOrDefault(x => x.UserName == employeeUsername);
                        if (!user.ValidatePassword(employeeUsername))
                        {
                            Console.WriteLine("Invalid username of password!");
                            break;
                        
                        }
                        Console.Clear();
                        Console.WriteLine("Enter your password");
                        string employeePassword = Console.ReadLine();
                        Console.Clear();
                        users
                            .FirstOrDefault(x => x.Password == employeePassword);
                        if (!user.ValidatePassword(employeePassword))
                        {
                            Console.WriteLine("Invalid username or password!");
                            break;
                        }

                        Console.WriteLine($"Welcome admin {user.FirstName + user.LastName}!");
                        

                        Console.WriteLine("Press \n1 to see all registered users or \n2 to see all movies available");
                        int actionChoiceEmployee = int.Parse(Console.ReadLine());

                        if (actionChoiceEmployee == 1)
                        {
                            EmployeeService.showAllUsers(users);
                            Console.WriteLine("Press \n1 to add user or \n2 to remove user:");
                            // add user
                            int addRemoveChoice = int.Parse(Console.ReadLine());

                            if (addRemoveChoice == 1)
                            {
                                
                                
                                Console.WriteLine("Press \n1 to add user or \n2 to add another employee-administrator");
                                int addRemoveChoice02 = int.Parse(Console.ReadLine());

                                switch (addRemoveChoice02)
                                {
                                    case 1:
                                        Console.WriteLine("Add first name:");
                                        string addFirstname = Console.ReadLine();
                                        Console.WriteLine("Add last name:");
                                        string addLastname = Console.ReadLine();
                                        Console.WriteLine("Add age:");
                                        int addAge = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Add username:");
                                        string addUsername = Console.ReadLine();
                                        Console.WriteLine("Add password:");
                                        string addPassword = Console.ReadLine();
                                        Console.WriteLine("Add phone number:");
                                        int addPhonenumber = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Add member number:");
                                        int addMembernumber = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Set the date of registration:");
                                        DateTime addDateofRegistration = DateTime.Parse(Console.ReadLine());

                                        users.Add(new User(addFirstname, addLastname, addAge, addUsername, addPassword, addPhonenumber, addMembernumber, addDateofRegistration));
                                        Console.WriteLine("New user added!");
                                        continue;
                                    case 2:
                                        Console.WriteLine("Add first name:");
                                        string addFirstnameE = Console.ReadLine();
                                        Console.WriteLine("Add last name:");
                                        string addLastnameE = Console.ReadLine();
                                        Console.WriteLine("Add age:");
                                        int addAgeE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Add username:");
                                        string addUsernameE = Console.ReadLine();
                                        Console.WriteLine("Add password:");
                                        string addPasswordE = Console.ReadLine();
                                        Console.WriteLine("Add phone number:");
                                        int addPhonenumberE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Add member number:");
                                        int addMembernumberE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Set the date of registration:");
                                        DateTime addDateofRegistrationE = DateTime.Parse(Console.ReadLine());
                                        Console.WriteLine("Add salary:");
                                        int addSalary = int.Parse(Console.ReadLine());
                                        Console.WriteLine("set hours pro month:");
                                        int addHoursProM = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Set bonus:");
                                        int addBonus = int.Parse(Console.ReadLine());

                                        employees.Add(new Employee(addFirstnameE, addLastnameE, addAgeE, addUsernameE, addPasswordE, addPhonenumberE, addDateofRegistrationE, addSalary, addHoursProM, addBonus));
                                        Console.WriteLine("New employee added!");
                                        continue;
                                    default:
                                        Console.WriteLine("Invalid choice!");
                                        break;
                                }
                            }

                            else if (addRemoveChoice == 2)
                            {
                                Console.WriteLine("You have chosen to remove user");
                                Console.WriteLine("Enter user's username:");
                                string removeUser = Console.ReadLine();

                                if (users.Remove(users.FirstOrDefault(x => x.UserName == removeUser)))
                                {
                                    Console.WriteLine($"The user with the username '{removeUser}' hase been removed!");
                                }
                                else 
                                {
                                    Console.WriteLine("No such username found!");
                                }
                            }
                        }
                        else if (actionChoiceEmployee == 2)
                        {
                            EmployeeService.showAllMovies(movies);
                        }
                        Console.Clear();
                    }


                    #endregion

                    #region User

                    
                    else if (roleChoice == 2)
                    {
                        Console.WriteLine("Press 1 to register, 2 to login:");
                        int register_loginChoice = int.Parse(Console.ReadLine());

                        if (register_loginChoice == 1)
                        {
                         

                            Console.WriteLine("Please, enter your first name:");
                            string firstname = Console.ReadLine();
                            Console.WriteLine("Please, enter your last name:");
                            string lastname = Console.ReadLine();
                            Console.WriteLine("Please, enter your age:");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please, enter your username name:");
                            string username = Console.ReadLine();
                            Console.WriteLine("Please, enter your password name:");
                            string password = Console.ReadLine();
                            Console.WriteLine("Please, enter your phone number:");
                            int phonenumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Add member number:");
                            int addMembernumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Set the date of registration:");
                            DateTime addDateofRegistration = DateTime.Parse(Console.ReadLine());

                            if (firstname == "" || lastname == "" || age == null || username == "" || password == "" || phonenumber == null)
                            {
                                Console.WriteLine("All fields are mandatory!");
                                break;

                            }


                            users.Add(new User(firstname, lastname, age, username, password, phonenumber, addMembernumber, addDateofRegistration));

                            Console.WriteLine($"{firstname + lastname}, you have registered successfully!");

                            continue;

                        }

                        else if (register_loginChoice == 2)
                        {
                            Console.WriteLine("Enter your username:");
                            string userUsername = Console.ReadLine();
                            users
                            .FirstOrDefault(x => x.UserName == userUsername);
                            if (!user.ValidateUsername(userUsername))
                            {
                                Console.WriteLine("Invalid username or password!");
                                break; ;
                            }

                            Console.WriteLine("Enter your password");
                            string userPassword = Console.ReadLine();
                            users
                            .FirstOrDefault(x => x.Password == userPassword);
                            if (!user.ValidatePassword(userPassword))
                            {
                                Console.WriteLine("Invalid username or password!");
                                continue;
                            }

                            
                            if (user.ValidateUsername(userUsername) && user.ValidatePassword(userPassword) == true)
                            {
                                Console.WriteLine($"Welcome {user.FirstName + user.LastName}!");
                                Console.WriteLine("Press 1 to see you account info, 2 to rent a movie or 3 to see all movies you rented");
                                int userInnerOptions = int.Parse(Console.ReadLine());

                                if (userInnerOptions == 1)
                                {
                                    user.DisplayInfo();
                                    Console.WriteLine("Furthermore, if you want to extend your membership press 1:");
                                    int ExtendMemebership = int.Parse(Console.ReadLine());
                                    if (ExtendMemebership == 1)
                                    {
                                        korisnik.RenewMembership();
                                    }
                                }
                                else if (userInnerOptions == 2)
                                {
                                    EmployeeService.showAllMovies(movies);
                                    //movies.ForEach(item => item.DisplayInfoMovies());
                                    Console.WriteLine("Enter the number of a movie you want to rent:");
                                    int movieChoice = int.Parse(Console.ReadLine());

                                    bool isValidNumber = int.TryParse(Console.ReadLine(), out movieChoice);
                                    movieChoice -= 1;

                                    if (isValidNumber && movieChoice < movies.Count && movies[movieChoice].isRented == false)
                                    {
                                        movies[movieChoice].Owner = user.UserName;
                                        movies[movieChoice].isRented = true;
                                        user.RentedMovies.Add(movies[movieChoice]);
                                        Console.WriteLine($"The movie {movies[movieChoice].Title} has been rented and ");
                                    }
                                }
                            }
                        }

                    
                    }
                    #endregion
                }
            }
            catch (Exception)
            {

                throw;
            }
            

            


            


            
        }
    }
}
