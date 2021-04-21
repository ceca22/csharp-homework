using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    //    Create class Movie that will have the following properties

   

    public class Movie
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }

        public Enums.MovieGenres Genre { get; set; }

        private int Price { get; set; }

        public bool Rented { get; set; }

        public Movie()
        {

        }

        
        public Movie(string title, string descripiton, int year, MovieGenres genre, bool rented )
        {
            Title = title;
            Description = descripiton;
            Year = year;
            Genre = genre;
            Rented = rented;
            
        }

        public int setPrice()
        {
            System.Random random = new System.Random();
            Price = 0;
            if(Year < 2000)
            {
                Price = random.Next(100, 200);
                return Price;

            } else if(Year > 200 && Year < 2010)
            {
                Price = random.Next(200, 300);
                return Price;
            } else if (Year > 2010)
            {
                Price = random.Next(300, 500);
                return Price;
            } else
            {
                return 0;
            }

        }

    }
}
