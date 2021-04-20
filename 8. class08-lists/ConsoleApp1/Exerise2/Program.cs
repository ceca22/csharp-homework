using ClassLibrary1.Entities.Enums;
using ClassLibrary1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exerise2
{
    class Program
    {


        static void Main(string[] args)
        {
            //Create a class Song with the following properties: Title, Length and, Genre
            //●Genre is enum with -Rock, Hip_Hop, Techno and Classical
            //●Create a class Person with the following properties: Id, FirstName, LastName, Age, FavoriteMusicType(Genre enum) and FavoriteSongs
            //●FavoriteSongs is a list of Songs
            //●Create a method called GetFavSongs() that will print out all the titles of their favorite songs or write a message that this person hates music if there are no favorite songs in their list

            Person person1 = new Person(12, "Jerry", "Channel", 44, Genres.Rock);
            Person person2 = new Person(12, "Jane", "Rocky", 24, Genres.HipHop);
            Person person3 = new Person(12, "Maria", "Red",35, Genres.Classical);
            Person person4 = new Person(12, "Stefan", "Doll", 18, Genres.Techno);
            Person person5 = new Person(12, "Lisa", "Lisabon", 27, Genres.None);

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            //List<Song> songs = new List<Song>();

            //songs.Add(new Song() { Title = "AC/DC You Shook Me All Night Long", Length = 3.28, Genre = Genres.Rock });

            Song song01 = new Song("You Shook Me All Night Long", 3.28, Genres.Rock);
            Song song02 = new Song("Back In Black", 4.11, Genres.Rock);
            Song song03 = new Song("Highway to Hell", 4.28, Genres.Rock);
            Song song04 = new Song("Toccata and Fugue in D minor", 6.48, Genres.Classical);
            Song song05 = new Song("Bagatelle No. 25 in A minor", 7.28, Genres.Classical);
            Song song06 = new Song("Piano Sonata No. 14 in C-sharp minor", 3.28, Genres.Classical);
            Song song07 = new Song("DJ Khaled feat. Drake - 'POPSTAR'", 2.50, Genres.HipHop);
            Song song08 = new Song("StaySolidRocky - 'Party Girl'", 3.28, Genres.HipHop);
            Song song09 = new Song("Megan Thee Stallion feat. Beyoncé - Savage Remix", 3.28, Genres.HipHop);
            Song song10 = new Song("Let's get down to business", 2.54, Genres.Techno);
            Song song11 = new Song("In The End", 4.37, Genres.Rock);


            person1.FavoriteSongs.Add(song01);
            person1.FavoriteSongs.Add(song02);
            person1.FavoriteSongs.Add(song03);
            person1.FavoriteSongs.Add(song11);
            person2.FavoriteSongs.Add(song08);
            person3.FavoriteSongs.Add(song06);
            person3.FavoriteSongs.Add(song04);
            person4.FavoriteSongs.Add(song10);


            Console.WriteLine("----------------------------------");
            person1.GetFavSongs();
            Console.WriteLine("----------------------------------");

            person2.GetFavSongs();
            Console.WriteLine("----------------------------------");

            person3.GetFavSongs();
            Console.WriteLine("----------------------------------");

            person4.GetFavSongs();
            Console.WriteLine("----------------------------------");

            person5.GetFavSongs();
            Console.WriteLine("----------------------------------");


           










            Console.ReadLine();
        }
    }
}
