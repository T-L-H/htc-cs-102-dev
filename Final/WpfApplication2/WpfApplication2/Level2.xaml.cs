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
    /// Interaction logic for Level2.xaml
    /// </summary>
    public partial class Level2 : Window
    {
        public Level2()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Level3 level3 = new Level3();
            level3.Show();
            this.Hide();

            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1FnjslBb8puW8WNCDLE3UITpAfBB5JaSZ/view?usp=sharing");
            
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1KWNxEWAVfKHUJwGV8BrRPGJVI7KDfPOY/view?usp=sharing");
            this.Hide();
        }
    }
}
