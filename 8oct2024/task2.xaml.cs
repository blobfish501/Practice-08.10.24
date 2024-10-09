using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Логика взаимодействия для task2.xaml
    /// </summary>
    public partial class task2 : Window
    {
        public task2()
        {
            InitializeComponent();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
        double operand1;
        double operand2;
        Random R = new Random();
        string str_digit;
        private void Input_changed(object sender, TextChangedEventArgs e)
        {
            str_digit = input.Text;
        }
        private void Numbers(object sender, RoutedEventArgs e)
        {
            digit_1.Text = Convert.ToString(R.Next(-100000, 100000));
            operand1 = Convert.ToDouble(digit_1.Text);
            digit_2.Text = Convert.ToString(R.Next(-100000, 100000));
            operand2 = Convert.ToDouble(digit_2.Text);
        }
        private void Execute(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (str_digit)
                {
                    case ("+"):
                        result_output.Text = Convert.ToString(operand1 + operand2);
                        break;
                    case ("-"):
                        result_output.Text = Convert.ToString(operand1 - operand2);
                        break;
                    case ("*"):
                        result_output.Text = Convert.ToString(operand1 * operand2);
                        break;
                    case ("/"):
                        result_output.Text = Convert.ToString(operand1 / operand2);
                        break;
                    default:
                        result_output.Text = "Введен неверный знак";
                        break;
                }
            }
            catch
            {
                result_output.Text = "Ошибка";
            }
        }
    }
}
