using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
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
    /// Логика взаимодействия для task1.xaml
    /// </summary>
    public partial class task1 : Window
    {
        public task1()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        string word = "";
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            {"погода", "weather"},
            {"солнечно", "sunny"},
            {"дождь", "rain"},
            {"ветрено", "windy"},
            {"штиль", "calm"},
            {"гроза", "thunderstorm"},
            {"снег", "snowy"},
            {"ураган", "storm"},
            {"туман", "fog"},
            {"облачно", "cloudy"},
        };
        private void Translate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string low = word.ToLower();
                word_eng.Text = words[low];
            }
            catch
            {
                word_eng.Text = "Неверное слово";
            }
        }
        private void Text_Changed(object sender, TextChangedEventArgs e)
        {
            word = word_rus.Text;
        }
    }
}
