﻿using System;
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
    /// Interaction logic for Final.xaml
    /// </summary>
    public partial class Final : Window
    {
        public Final()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)

        {

            listBox1.Items.Add(textBox1.Text);

        }
    }
}
