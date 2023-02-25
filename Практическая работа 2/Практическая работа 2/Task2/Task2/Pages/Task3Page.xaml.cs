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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        void MainFunction()
        {
            try
            {
                MainInfoLb.Content = "";
                string stroka = LenghtTb.Text;
                stroka = stroka.Replace("*", "");
                for (int i = 0; i < stroka.Length; i++)
                {
                    stroka = stroka.Insert(i + 1, stroka[i++].ToString());
                }
                MainInfoLb.Content = stroka;
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
