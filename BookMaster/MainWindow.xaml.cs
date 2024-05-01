using BookMaster.Pages;
using BookMaster.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Navigate(new PageMain());
            Logout.Visibility = Visibility.Collapsed;
            Library.Visibility = Visibility.Hidden;
            App.isOpen = false;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OknoLogin();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                Logout.Visibility = Visibility.Visible;
                Library.Visibility = Visibility.Visible;
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            App.isOpen = false;
            Logout.Visibility = Visibility.Collapsed;
            Library.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(new PageMain());
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PageMain());
        }

        private void ManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PageCustomers());
        }

        private void Circulation_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PageCirculation());
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PageReports());
        }
    }
}
