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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }
        public static StringBuilder MainFunction(ulong a, StringBuilder res)//метод
        {
            if (a > 0)//пока чило будет больше 0, то метод будет вызывать сам себя
            {
                res.Append($"{a % 10} ");//если условие субледено, то число итерации добавляется в res и вызывается рекурсия
                MainFunction(a / 10, res);
            }
            return res;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder res = new StringBuilder();
            Label_end.Content = MainFunction(Convert.ToUInt64(Textbox_start.Text), res).ToString();//конвертируем цифру;//выводим ответ
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
