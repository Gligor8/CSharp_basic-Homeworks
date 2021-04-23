using System;

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

        public int DateOfRegistration { get; set; }
        public Enums.MemberRole Role { get; set; }

        public Member()
        {

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}, User Name: {UserName}, Password: {Password}, Phone Number: {PhoneNumber}, Date of Registration: {DateOfRegistration}, Role: {Role}");
        }
    }
}
