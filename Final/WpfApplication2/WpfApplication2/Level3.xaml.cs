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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Level3.xaml
    /// </summary>
    public partial class Level3 : Window
    {
        public Level3()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Final final = new Final();
            final.Show();
            this.Hide();

            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1m10ymqIVfdBrKHKGF9Yej585bO85V8Jx/view?usp=sharing");

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1KWNxEWAVfKHUJwGV8BrRPGJVI7KDfPOY/view?usp=sharing");
            this.Hide();
        }
    }
}
