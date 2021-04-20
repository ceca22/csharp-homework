using ClassLibrary1.Entities.Enums;
using ClassLibrary1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            


            #region PEOPLE
            Person person1 = new Person(12, "Jerry", "Channel", 44, Genres.Rock);
            Person person2 = new Person(12, "Jane", "Rocky", 24, Genres.HipHop);
            Person person3 = new Person(12, "Maria", "Red", 35, Genres.Classical);
            Person person4 = new Person(12, "Stefan", "Doll", 18, Genres.Techno);
            Person person5 = new Person(12, "Lisa", "Lisabon", 27, Genres.None);

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            #endregion

            #region SONGS
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





            List<Song> songs = new List<Song>();
            songs.Add(song01);
            songs.Add(song02);
            songs.Add(song03);
            songs.Add(song04);
            songs.Add(song05);
            songs.Add(song06);
            songs.Add(song07);
            songs.Add(song08);
            songs.Add(song09);
            songs.Add(song10);
            #endregion


            //Select the person Jerry and add all the songs which start with the letter B
            Console.WriteLine("----------------------------starts with B--------------------");


            Person jerryPerson = people
                                .Where(x => x.FirstName == "Jerry")
                                .First();

            List<Song> targetSongsStartingWithB = songs
                                                .Where(x => x.Title.StartsWith("B"))
                                                .ToList();

            Console.WriteLine($"Before adding the songs: { jerryPerson.FavoriteSongs.Count}" ); 


            for (int i=0; i < targetSongsStartingWithB.Count; i++)
            {
                jerryPerson.FavoriteSongs.Add(targetSongsStartingWithB[i]);

            }
            
            jerryPerson.FavoriteSongs.ForEach(x => Console.WriteLine(x.Title));
            Console.WriteLine($"After adding the songs: { jerryPerson.FavoriteSongs.Count}");



            //    ●Select the person Maria and add all the songs with length longer than 6 mins
            Console.WriteLine("----------------------------longer than 6 mins--------------------");

            Person mariaPerson = people
                                .Where(x => x.FirstName == "Maria")
                                .First();

            List <Song> songsLongerThan6Mins = songs
                                                .Where(x => x.Length > 6)
                                                .ToList();

           

            Console.WriteLine($"Before adding the songs: { mariaPerson.FavoriteSongs.Count}");

            for (int i=0; i<songsLongerThan6Mins.Count; i++)
            {
                mariaPerson.FavoriteSongs.Add(songsLongerThan6Mins[i]);
            }
            
            Console.WriteLine($"After adding the songs: { mariaPerson.FavoriteSongs.Count}");
            mariaPerson.FavoriteSongs.ForEach(x => Console.WriteLine($"{x.Title} | Length: {x.Length}"));




            //    ●Select the person Jane and add all the songs that are of genre Rock
            Console.WriteLine("------------------the genre rock songs------------------------------");

            Person janePerson = people
                                .Where(x => x.FirstName == "Jane")
                                .First();

            List<Song> songsGenreRock = songs
                                    .Where(x => x.Genre == Genres.Rock)
                                    .ToList();
                                

            for (int i=0; i<songsGenreRock.Count; i++)
            {
                janePerson.FavoriteSongs.Add(songsGenreRock[i]);
            }

            janePerson.FavoriteSongs.ForEach(x => Console.WriteLine($"{x.Title} | Genre: {x.Genre}"));

            //    ●Select the person Stefan and add all songs shorter than 3 mins and of genre Hip - Hop
            Console.WriteLine("------------------songs shorter than 3 mins------------------------------");

            Person stefanPerson = people
                                .Where(x => x.FirstName == "Stefan")
                                .First();

            List<Song> songsShorterThan3Mins = songs
                                            .Where(x => x.Length < 3)
                                            .ToList();

            for(int i=0; i<songsShorterThan3Mins.Count; i++)
            {
                stefanPerson.FavoriteSongs.Add(songsShorterThan3Mins[i]);
            }

            stefanPerson.FavoriteSongs.ForEach(x => Console.WriteLine($"{x.Title} | length: {x.Length}"));




            //    ●Select all persons from the persons array that have 4 or more songs
            Console.WriteLine("------------------people with 4 or more songs------------------------------");

            List <Person> peopleWithMoreThan4FavoriteSongs = people
                                                            .Where(x => x.FavoriteSongs.Count >= 4)
                                                            .ToList();

            peopleWithMoreThan4FavoriteSongs.ForEach(x => Console.WriteLine($"{x.FirstName} has {x.FavoriteSongs.Count} favorite songs"));

            if (peopleWithMoreThan4FavoriteSongs.Count == 0)
                Console.WriteLine("No one has 4 or more than 4 favorite songs");




            Console.ReadLine();

        }
    }
}
