using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public DateTime MembershipPaymentDate { get; set; }
        public TypeSub TypeOfSubscription { get; set; }




        public User(string firstname, string lastname, int age, string username, string password, int phonenumber, int membernumber, DateTime dateofregistration, TypeSub typeofsubscription) : base()
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            PhoneNumber = phonenumber;
            MemberNumber = membernumber;
            DateOfRegistration = dateofregistration;
            RentedMovies = new List<Movie>(0);
            TypeOfSubscription = typeofsubscription;
        }

        public void DisplayRemainingMembership()
        {
            
            switch (TypeOfSubscription)
            {
                case TypeSub.Monthly:
                    Console.WriteLine($"Your account is due {MembershipPaymentDate.AddMonths(1)}");
                    break;
                case TypeSub.Annually:
                    Console.WriteLine($"Your account is due {MembershipPaymentDate.AddYears(1)}");
                    break;
                default:
                    break;
            }
            
        }
        public void RenewMembership()
        {
            MembershipPaymentDate = DateTime.Now;
        }
        public void ShowRentedMovies()
        {
            
            if (RentedMovies.Count == 0) Console.WriteLine("You have not rented movies so far");
            else RentedMovies.ForEach(movie => movie.DisplayInfoMovies());
            
        }
    }
}
