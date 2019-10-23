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
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public Movie(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }

        public Movie(string title, int releaseYear, string director)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
        }

        public Movie(string title, int releaseYear, string director, int length)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
        }

        public Movie(string title, int releaseYear, string director, int length, string genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + ReleaseYear + "\n\r" + "Director is " + Director + "\n\r" + "Length is " + Length + "\n\r" + "Genre is " + Genre);
        }
    }
}