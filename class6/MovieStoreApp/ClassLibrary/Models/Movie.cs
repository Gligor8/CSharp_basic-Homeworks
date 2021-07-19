using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Movie
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genres Genre { get; set; }
        public bool isRented { get; set; }
        public string Owner { get; set; }

        

        private int Price { get; set; }

        //public Movie(int number, string title, string description, int year, Genres genre, bool isrented, string owner)
        //{
        //    Number = number;
        //    Title = title;
        //    Description = description;
        //    Year = year;
        //    Genre = genre;
        //    isRented = isrented;
        //    Owner = owner;

        //}


        public void SetPrice(int v)
        {
            if (Year < 2000)
            {
                Price = 180;
            }
            else if (Year > 2000 && Year < 2010)
            {
                Price = 240;
            }
            else if (Year > 2010)
            {
                Price = 320;
            }
        }

        public bool ValidateTitle(string titleVal)
        {
            return this.Title == titleVal;
        }

        public void DisplayInfoMovies()
        {
            Console.WriteLine($"Number: {Number}, Title: {Title}, Description: {Description}, Year: {Year}, Genre: {Genre}, Price: {Price}");
        }
    }
}
