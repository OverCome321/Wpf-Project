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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        public static int[][] MainFunction(int[][] arr)//метод
        {
            int[][] result = arr;
            for (int i = 0; i < arr.Length; i++)//проходимся по элементам матрицы и смотрим их индекс и чётность,если проходит по условию то меняем на 1
                for (int j = 0; j < arr.Length; j++)
                    if ((i % 2 == 0 || j % 2 == 0) && result[i][j] < 0)
                        result[i][j] = 1;
            return result;//возвращаем результат
        }

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[][] array = Textbox_start.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToInt32(y)).ToArray()).ToArray();//создаём массив
            int[][] result = MainFunction(array);//считаем результат
            Label_end.Content = (string.Join("\n", result.Select(x => string.Join("\t", x))));//выводим ответ
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
