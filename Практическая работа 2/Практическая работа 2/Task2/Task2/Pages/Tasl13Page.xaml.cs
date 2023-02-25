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
    /// Логика взаимодействия для Tasl13Page.xaml
    /// </summary>
    public partial class Tasl13Page : Page
    {
        public Tasl13Page()
        {
            InitializeComponent();
        }
        private static int GetGroupsCount(string s)//метод
        {
            char current = '0';
            int count = 0;

            foreach (char ch in s.ToCharArray())//проходимся по каждому символу и временно храним каждый символ, для сравнения его в итерации и если он равен 1, то мы изменяет символ на 1 и прибавляем количество, если же он равен 0 то мы изменяем хранимый символ на 0
            {
                if (ch != current && ch == '1')
                {
                    current = '1';
                    count++;
                }
                else if (ch != current && ch == '0')
                    current = '0';
            }
            return count;// возвращаем количество
        }

        public static string[] SplitStringByNChars(string s, int count)//метод
        {
            StringBuilder stringBuilder = new StringBuilder();// Проходимся по символам строки и после каждого N символа разделяем строку
            for (int i = 0; i < s.Length; i++)
            {
                stringBuilder.Append(s[i]);
                if ((i + 1) % count == 0) stringBuilder.Append("~");
            }
            return stringBuilder.ToString().Split('~');
        }

        public static int MainFunction(string[] s)//метод
        {
            int count = 0;//считаем количество стендов
            foreach (string el in s)
                count += GetGroupsCount(el);
            return count;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] array = SplitStringByNChars(Textbox_polki.Text, Convert.ToInt32(Textbox_nm.Text.Split('*').Last()));//добавляем полки
            Label_end.Content = ($"{MainFunction(array)}");//выводим ответ
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
