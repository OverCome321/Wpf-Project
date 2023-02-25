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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        void functionMassiv()
        {
            try
            {
                //Обновляем текст в метке
                MainInfoLb.Content = "";
                //Разделяем строку на цифры
                string[] mystring = DigitsTb.Text.Split(' ');
                //Создаем массив цифр размером 10 символов и добавляем в него цифры
                int[] numbers = new int[10];
                int n = Convert.ToInt32(DigitTb.Text);
                int count = 0;
                int countOfDigits = 0;
                foreach (string str in mystring)
                {
                    numbers[count] = Convert.ToInt32(str);
                    count++;
                }
                //Выводим массив в метку
                foreach (int num in numbers)
                {
                    MainInfoLb.Content += " " + num;
                }
                //Ищем сколько раз встречается цифра в массиве и выводим ее
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[j] == n)
                    {
                        countOfDigits += 1;
                    }
                }
                if (countOfDigits == 0)
                {
                    MainInfoLb.Content += "\n" + "Число: " + n + " не встречается!";
                }
                else
                {
                    MainInfoLb.Content += "\n" + "Число: " + n + " встречается - " + countOfDigits + " раза";
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
