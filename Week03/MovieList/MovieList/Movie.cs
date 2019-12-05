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
        public string ReleaseYear { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public double Rotten { get; set; }
        public Movie(string title, string v, string releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }

        public Movie(string title, string v, string releaseYear, string director)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
        }

        public Movie(string title, string releaseYear, string director, int length)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
        }

        public Movie(string title, string releaseYear, string director, int length, string genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
        }
        public Movie(string title, string releaseYear, string director, int length, string genre, double rotten)

        {

            Title = title;

           ReleaseYear = releaseYear;

            Director = director;

            Length = length;

            Genre = genre;

            Rotten = rotten;

        }

        public Movie(string title, string releaseYear, string director, int length, string genre, int rotten)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
            Rotten = rotten;
        }

        public Movie(string title, string director, int length, string genre, int rotten)
        {
            Title = title;
            Director = director;
            Length = length;
            Genre = genre;
            Rotten = rotten;
        }

        public void ShowDetails()

        {

            MessageBox.Show(Title + " was released in 10/10/19 " + "\n\r" + "Director is " + Director + "\n\r" + "Length is " + Length + "\n\r" + "Genre is " + Genre + "\n\r" + "Rotten Tomatoes Score is " + Rotten);

        }

    }

}