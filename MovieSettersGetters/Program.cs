using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MovieSettersGetters
{
    class Program
    {
        class Movie
        {
            string title;
            string director;
            string ratings;
            int userRating;

            public Movie(string _title, string _director, string _ratings, int _userRating)
            {
                title = _title;
                director = _director;
                Ratings = _ratings;
                UserRating = _userRating;
            }

            public string Ratings
            {
                get { return ratings; }
                set
                {
                    if(value == "G" || value == "PG" || value == "PG-13" || value == "R")
                    {
                        ratings = value;
                    } else
                    {
                        ratings = "undefined";
                    }
                }
            }

            public int UserRating
            {
                get { return userRating; }
                set
                {
                    if (value >= 0 && value <= 10)
                    {
                        userRating = value;
                    }
                    else
                    {
                        userRating = 0;
                    }  
                }
            }

            public string Title
            {
                get { return title; }
            }

            public string Director
            {
                get { return director; }
            }


            //G, PG, PG-13, R, undefined
            //userRating not higher than 10 and no lower than 0
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\demo\movies.txt";
            List<string> listFromFile = File.ReadAllLines(filePath).ToList();

            List<Movie> listOfMovies = new List<Movie>();

            foreach(string line in listFromFile)
            {
                string[] tempArray = line.Split('/');
                
                
            }
        }
    }
}
