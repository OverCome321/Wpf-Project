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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Task1Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task1Page());
        }

        private void Task2Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task2Page());
        }

        private void Task3Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task3Page());
        }

        private void Task4Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task4Page());
        }

        private void Task6Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task6Page());
        }

        private void Task5Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task5Page());
        }

        private void Task7Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task7Page());
        }

        private void Task8Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task8Page());
        }

        private void Task8Bt_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task9Page());
        }

        private void Task10Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task10Page());
        }

        private void Task11Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task11Page());
        }

        private void Task12Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Task12Page());
        }

        private void Task13Bt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Tasl13Page());
        }
    }
}
