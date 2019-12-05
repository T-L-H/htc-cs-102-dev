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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1DorRQg8gExHJ7PCjdQFBaJ9oXTMrH6A3/view?usp=sharing");
            Level2 level2 = new Level2();
            level2.Show();
            this.Hide();
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1KWNxEWAVfKHUJwGV8BrRPGJVI7KDfPOY/view?usp=sharing");
        }
    }
}
