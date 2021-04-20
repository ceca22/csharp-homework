using ClassLibrary1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities.Models
{
    public class Person
    {

        //●Create a class Person with the following properties: Id, FirstName, LastName, Age,
        //FavoriteMusicType(Genre enum) and FavoriteSongs

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Genres FavoriteMusictype { get; set; }

        public List<Song> FavoriteSongs { get; set; } = new List<Song>(); 

        public Person()
        {

        }

        public Person(int id, string firstName, string lastName, int age, Genres favoriteMusicType )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusictype = favoriteMusicType;
            
        }
            
        public void GetFavSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} hates music!");
            } else if (FavoriteSongs.Count == 1)
            {
                foreach (Song song in FavoriteSongs)
                {

                    Console.WriteLine($"{FirstName}'s favorite song is { song.Title}");
                }
            } else if (FavoriteSongs.Count > 1)
            {
                string favSongs = $"{FirstName}'s favorite song is: ";

                for (int i=0; i<FavoriteSongs.Count; i++)
                {
                    if (i == FavoriteSongs.Count - 1)
                    {
                        favSongs += $"{FavoriteSongs[i].Title}.";
                        break;
                    }

                    favSongs += $"{FavoriteSongs[i].Title} and ";
                        
                }
                Console.WriteLine(favSongs);
            }



        }

    }
}
