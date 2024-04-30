using BookMaster.Pages;
using BookMaster.Windows;
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
            FileBtn.ItemsSource = new string[] { "File", "Open", "Close"};
            FileBtn.SelectedIndex = 0;
            LibraryBtn.ItemsSource = new string[] { "Library", "Manage Customers", "Circulation", "Reports" };
            LibraryBtn.SelectedIndex = 0;
            LibraryBtn.Visibility = Visibility.Hidden;
            App.isOpen = false;
        }

        private void LibraryBtn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LibraryBtn.SelectedIndex == 1)
            {
                MyFrame.Navigate(new PageCustomers());
            }
            if (LibraryBtn.SelectedIndex == 2)
            {
                MyFrame.Navigate(new PageCirculation());
            }
            if (LibraryBtn.SelectedIndex == 3)
            {
                MyFrame.Navigate(new PageReports());
            }
            LibraryBtn.SelectedIndex = 0;
        }

        private void FileBtn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FileBtn.SelectedIndex == 1)
            {
                var dialog = new OknoLogin();

                FileBtn.ItemsSource = new string[] { "File", "Open", "Close", "Logout" };
                LibraryBtn.Visibility = Visibility.Visible;

                dialog.ShowDialog();
            }
            if (FileBtn.SelectedIndex == 3)
            {
                App.isOpen = false;
                FileBtn.ItemsSource = new string[] { "File", "Open", "Close" };
                LibraryBtn.Visibility = Visibility.Hidden;
            }
            if (FileBtn.SelectedIndex == 2)
            {
                Close();
            }
            FileBtn.SelectedIndex = 0;
        }
    }
}
