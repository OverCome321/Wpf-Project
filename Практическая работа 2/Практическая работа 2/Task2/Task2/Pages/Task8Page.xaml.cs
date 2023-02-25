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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        public static int MainFunction(int[][] arr)//метод
        {

            int sum = 0;//сумма
            foreach (int[] el in arr)//проходимся по матрице и ищем минимальный элемент каждой строки и добавляем в сумму
                sum += el.Min();
            return sum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[][] array = Textbox_start.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToInt32(y)).ToArray()).ToArray();//задаём массив
            Label_end.Content = ($"Сумма минимальных элементов строк равна {MainFunction(array)}");//выводим ответ
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
