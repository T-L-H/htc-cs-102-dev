using System;
using System.Collections.Generic;
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
        List<Movie> Movies = new List<Movie>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                movie.ShowDetails();
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleInput.Text;
            int ReleaseYear = Convert.ToInt32(ReleaseYearInput.Text);
            Movie movie = new Movie(title, ReleaseYear);
            Movies.Add(movie);
            MessageBox.Show("Your Movie was added!");
        }
    }
}
