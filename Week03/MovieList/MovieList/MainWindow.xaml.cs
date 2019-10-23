using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
     ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            lvMovies.ItemsSource = Movies;
            
            
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                movie.ShowDetails();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie item in Movies)
            {
                if (item.Title == TitleInput.Text)
                {
                    MessageBox.Show("This title was already added.");
                    return;
                }
            }
            if ( String.IsNullOrEmpty( TitleInput.Text ))
            {
                MessageBox.Show("You did not add a title.");
                return;
            }
            if (String.IsNullOrEmpty(ReleaseYearInput.Text))
            {
                MessageBox.Show("You did not add a release year.");
                return;
            }
            string title = TitleInput.Text;
            string director = directorInput.Text;
            int releaseYear = Convert.ToInt32(ReleaseYearInput.Text);
            int length = Convert.ToInt32(lengthInput.Text);
            string genre = genreInput.Text;


            Movie movie = new Movie(title, releaseYear, director, length, genre);
            Movies.Add(movie);
            MessageBox.Show("Movie was added");
           
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }
    }
}
