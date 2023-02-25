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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }
        private static bool True(ulong number)//метод
        {

            if (number <= 1) return false;//проверяем является ли число простым
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (ulong)Math.Floor(Math.Sqrt(number));

            for (ulong i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static StringBuilder MainFunction(ulong a, ulong del, StringBuilder res)//метод
        {

            if (del <= a)//если делитель меньше числа мы вызываем рекурсию
            {
                if (a % del == 0 && True(del))//если делитель делится на число и является простым числом то мы его добавляем в ответ
                    res.Append($"{del}; ");
                MainFunction(a, del + 1, res);
            }
            return res;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder res = new StringBuilder(); //Объявляем стринг билдер
            Label_end.Content = (MainFunction(Convert.ToUInt64(Textbox_start.Text), 1u, res).ToString());//выводим ответ
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
