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
    /// Логика взаимодействия для task4.xaml
    /// </summary>
    public partial class task4 : Window
    {
        public task4()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        const string password = "password";
        string attempt;
        string message = "send me your CVV digits";
        private void Check(object sender, RoutedEventArgs e)
        {
            attempt = PW_input.Text;
            try
            {
                if (attempt == password)
                {
                    For_viewer.Text = "Пароль верный!";
                    Message.Text = message;
                }
                else
                {
                    Message.Text = "Пароль не подходит.";
                }
            }
            catch
            {
                Message.Text = "Ошибка";
            }
        }
    }
}
