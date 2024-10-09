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

namespace _8oct2024
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
        private void B1_click(object sender, RoutedEventArgs e)
        {
            Window t1 = new task1();
            t1.Show();
        }
        private void B2_click(object sender, RoutedEventArgs e)
        {
            Window t2 = new task2();
            t2.Show();
        }
        private void B3_click(object sender, RoutedEventArgs e)
        {
            Window t3 = new task3();
            t3.Show();
        }
        private void B4_click(object sender, RoutedEventArgs e)
        {
            Window t4 = new task4();
            t4.Show();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}