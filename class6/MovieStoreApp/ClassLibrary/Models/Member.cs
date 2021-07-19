using ClassLibrary.Enums;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }

        public List<Movie> RentedMovies { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }
        //public object RentedMovies { get; set; }

        public Member()
        {

        }
        public Member(string firstname, string lastname, int age, string username, string password, DateTime dateofregistration, int phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            PhoneNumber = phonenumber;
            DateOfRegistration = DateTime.Now;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}, User Name: {UserName}, Password: {Password}, Phone Number: {PhoneNumber}, Date of Registration: {DateOfRegistration}, Role: {Role}");
        }

        public bool ValidateUsername(string usernameValU)
        {
            return this.UserName == usernameValU;
        }
        public bool ValidatePassword(string passU)
        {
            return this.Password == passU;
        }
    }
}
