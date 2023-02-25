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

namespace Task2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task11Page.xaml
    /// </summary>
    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
        }
        public static bool MainFunction(string s, int l, int r)//метод
        {
            if (l > r) return true; //проверяем на номер элемента и возвращаем значение
            return s.ToCharArray()[l] != s.ToCharArray()[r] ? false : MainFunction(s, l + 1, r - 1); //проверяем каждый символ с начала и конца с помощью рекурсии
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label_end.Content = (MainFunction(Textbox_start.Text, 0, Textbox_start.Text.Length - 1) ? "YES" : "NO");
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
