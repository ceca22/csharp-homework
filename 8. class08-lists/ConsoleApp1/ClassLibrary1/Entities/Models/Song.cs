using ClassLibrary1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities.Models
{
    public class Song
    {
        //Create a class Song with the following properties: Title, Length and, Genre

        public string Title { get; set; }
        public double Length { get; set; }
        public Genres Genre { get; set; }

        public Song()
        {

        }

        public Song(string title, double length, Genres genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
