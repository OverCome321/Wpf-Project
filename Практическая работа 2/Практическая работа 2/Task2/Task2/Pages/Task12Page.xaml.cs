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
    /// Логика взаимодействия для Task12Page.xaml
    /// </summary>
    public partial class Task12Page : Page
    {
        public Task12Page()
        {
            InitializeComponent();
        }
        public sealed class Team//класс команд
        {
            public Team(int identificator, int[] gameScores)
            {
                Identificator = identificator;
                GameScores = gameScores;
            }
            /// <summary>
            /// Номер команды
            /// </summary>
            public int Identificator { get; set; }
            /// <summary>
            /// Очки за игры
            /// </summary>
            public int[] GameScores { get; set; }
            /// <returns>Итоговое количество очков за все игры</returns>
            public int GetFinalScore()
            {
                return GameScores.Sum();
            }
        }
        public static string MainFunction(int[][] scores)//метод
        {
            List<Team> teams = new List<Team>();//проходимся по матрице и добавляем команды в соответсвии с конструктором класса
            for (int i = 0; i < scores.Length; i++)
                teams.Add(new Team(i + 1, scores[i]));
            teams = teams.OrderBy(x => x.GetFinalScore()).Reverse().ToList();//сортируем по очкам
            StringBuilder result = new StringBuilder();//проходимся по командам и добавляем их в ответ
            for (int i = 0; i < teams.Count; i++)
                result.Append($"Команда {teams[i].Identificator} заняла {i + 1} место с {teams[i].GetFinalScore()} очками\n");
            return result.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[][] scores = Textbox_start.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToInt32(y)).ToArray()).ToArray();//добавляем очки
            Label_end.Content = MainFunction(scores);//выводим ответ
        }

        private void BackBt_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }
    }
}
