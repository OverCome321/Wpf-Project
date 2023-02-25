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
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        void functionMassiv()
        {
            try
            {             
                MainInfoLb.Content = "";
                List<int> DigitsForSum = new List<int>();
                int n = Convert.ToInt32(LenghtTb.Text);
                string[] mystring = DigitsTb.Text.Split(' ');
                int[] numbers = new int[n];
                int count = 0;
                foreach (string str in mystring)
                {
                    numbers[count] = Convert.ToInt32(str);
                    count++;
                }
                //Выводим массив в метку
                foreach (int num in numbers)
                {
                    MainInfoLb.Content += num + " ";
                }
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[j] < 0)
                    {
                        DigitsForSum.Add(numbers[j]);
                    }
                }
                MainInfoLb.Content += "\nСумма отрицательных чисел: " + DigitsForSum.Sum();
                int countOfChet = 0;
                foreach (int num in DigitsForSum)
                {
                    if ( num % 2 == 0)
                    {
                        countOfChet++;
                    }
                }
                if (countOfChet > 0)
                {
                    MainInfoLb.Content += "\nКоличество четных чисел: " + countOfChet;
                }
                else
                {
                    MainInfoLb.Content += "\nЧетные числа не встречаются";
                }
                int countOfModule = 0;
                foreach (int num in DigitsForSum)
                {
                    if (Math.Abs(num) > 5)
                    {
                        countOfModule++;
                    }
                }
                if (countOfModule > 0)
                {
                    MainInfoLb.Content += "\nКоличество чисел по модулю больше 5: " + countOfModule;
                }
                else
                {
                    MainInfoLb.Content += "\nЧисла по модулю больше 5 не встречаются";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            functionMassiv();
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
