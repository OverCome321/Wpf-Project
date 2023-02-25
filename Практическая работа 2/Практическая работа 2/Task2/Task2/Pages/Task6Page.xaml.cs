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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }
        void MainFunction()
        {
            try
            {
                int[,] a = new int[5, 5];
                string start_matrix = "";
                string last_matrix = "";
                Random random = new Random();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        a[i, j] = random.Next(100);
                    }
                }
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        start_matrix += a[i, j] + " ";
                    start_matrix += "\n";
                }
                for (int i = 0; i < Math.Min(a.GetLength(0), a.GetLength(1)); i++)
                    a[i, i] = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        last_matrix += a[i, j] + " ";
                    last_matrix += "\n";
                }
                MainInfoLb.Content = "Изначальная матрица:" + "\n" + start_matrix;
                MainInfoLb2.Content = "Измененная матрица:" + "\n" + last_matrix;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFunction();
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
