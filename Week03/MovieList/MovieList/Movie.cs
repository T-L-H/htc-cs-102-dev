using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
       

        public string Title { get; set; }
        public int DateTime { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public double Rotten { get; set; }
        public Movie(string title, int releaseYear)
        {
            Title = title;
            DateTime = releaseYear;
        }

        public Movie(string title, int releaseYear, string director)
        {
            Title = title;
            DateTime = releaseYear;
            Director = director;
        }

        public Movie(string title, int releaseYear, string director, int length)
        {
            Title = title;
            DateTime = releaseYear;
            Director = director;
            Length = length;
        }

        public Movie(string title, int releaseYear, string director, int length, string genre)
        {
            Title = title;
            DateTime = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
        }
        public Movie(string title, int releaseYear, string director, int length, string genre, double rotten)

        {

            Title = title;

            DateTime = releaseYear;

            Director = director;

            Length = length;

            Genre = genre;

            Rotten = rotten;

        }

        public Movie(string title, int releaseYear, string director, int length, string genre, int rotten)
        {
            Title = title;
            DateTime = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
            Rotten = rotten;
        }

        public void ShowDetails()

        {

            MessageBox.Show(Title + " was released in " + DateTime + "\n\r" + "Director is " + Director + "\n\r" + "Length is " + Length + "\n\r" + "Genre is " + Genre + "\n\r" + "Rotten Tomatoes Score is " + Rotten);

        }

    }

}