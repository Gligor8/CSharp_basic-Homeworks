using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Enums.Genres Genre { get; set; }

        private int Price { get; set; }

        public Movie()
        {

        }

        public void SetPrice()
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
    }
}
