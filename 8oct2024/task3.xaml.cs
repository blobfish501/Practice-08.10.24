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

namespace _8oct2024
{
    /// <summary>
    /// Логика взаимодействия для task3.xaml
    /// </summary>
    public partial class task3 : Window
    {
        public task3()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Num_changed(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(Num_input.Text);
                if (0 <= num && num <= 14)
                {
                    Answer.Text = "[0 - 14]";
                }
                else if (15 <= num && num <= 35)
                {
                    Answer.Text = "[15 - 35]";
                }
                else if (36 <= num && num <= 50)
                {
                    Answer.Text = "[36 - 50]";
                }
                else if (50 <= num && num <= 100)
                {
                    Answer.Text = "[50 - 100]";
                }
                else
                {
                    Answer.Text = "Не подходит";
                }
            }
            catch
            {
                Answer.Text = "Ошибка";
            }
        }
    }
}
