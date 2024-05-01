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
#if DEBUG
            MyFrame.Navigate(new PageCirculation());
#else

            MyFrame.Navigate(new PageMain());
            FileBtn.ItemsSource = new string[] { "File", "Open", "Close" };
            FileBtn.SelectedIndex = 0;
            LibraryBtn.ItemsSource = new string[] { "Library", "Manage Customers", "Circulation", "Reports", "Main" };
            LibraryBtn.SelectedIndex = 0;
            LibraryBtn.Visibility = Visibility.Hidden;
            App.isOpen = false;
#endif
            }

        private void LibraryBtn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LibraryBtn.SelectedIndex == 1)
            {
                MyFrame.Navigate(new PageCustomers());
            }
            if (LibraryBtn.SelectedIndex == 2)
                MyFrame.Navigate(new PageCirculation());

            if (LibraryBtn.SelectedIndex == 3)
            {
                MyFrame.Navigate(new PageReports());
            }
            if (LibraryBtn.SelectedIndex == 4)
            {
                MyFrame.Navigate(new PageMain());
            }
            LibraryBtn.SelectedIndex = 0;
        }

        private void FileBtn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FileBtn.SelectedIndex == 1)
            {
                var dialog = new OknoLogin();
                if (dialog.ShowDialog().GetValueOrDefault())
                {
                    FileBtn.ItemsSource = new string[] { "File", "Open", "Close", "Logout" };
                    LibraryBtn.Visibility = Visibility.Visible;
                }
            }
            if (FileBtn.SelectedIndex == 3)
            {
                App.isOpen = false;
                FileBtn.ItemsSource = new string[] { "File", "Open", "Close" };
                LibraryBtn.Visibility = Visibility.Hidden;
                MyFrame.Navigate(new PageMain());
            }
            if (FileBtn.SelectedIndex == 2)
            {
                App.Current.Shutdown();
            }
            FileBtn.SelectedIndex = 0;
        }
    }
}
