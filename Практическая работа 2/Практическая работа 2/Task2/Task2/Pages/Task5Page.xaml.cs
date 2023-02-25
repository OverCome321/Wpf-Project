using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Net.Mime.MediaTypeNames;

namespace Task2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        void MainFunction()
        {
            try
            {
                MainInfoLb.Content = "";
                string[] mystring = LenghtTb.Text.Split(' ');
                int i = 0;
                List<int> maksIndex = new List<int>();
                foreach (string str in mystring)
                {
                    i = 0;
                    foreach (char ch in str)
                    {
                        if(ch == 'а')
                            i++;
                    }
                    maksIndex.Add(i);
                }
                int maxDigit = maksIndex.IndexOf(maksIndex.Max());
                string stroka = mystring[maxDigit];
                MainInfoLb.Content += (maxDigit + " индекс строки " + "\n" + stroka);
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
