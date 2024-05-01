using BookMaster.Models;
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

namespace BookMaster.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReports.xaml
    /// </summary>
    public partial class PageReports : Page
    {
        List<HistoryBook> historyes;
        Book contextBook;
        public PageReports()
        {
            InitializeComponent();
            historyes = App.DB.HistoryBook.Where(x => x.IsReturned == false).ToList();
            DataReminders.ItemsSource = historyes;
            ComboPoisk.ItemsSource = new string[] { "Customer", "Date of issue", "Return until", "Title"};
            ComboPoisk.SelectedIndex = 0;
            Refresh();
        }

        private void Refresh()
        {
            if (ComboPoisk.SelectedIndex == 0)
                historyes = historyes.OrderBy(x => x.Customer.Name).ToList();
            if (ComboPoisk.SelectedIndex == 1)
                historyes = historyes.OrderBy(x => x.DateOfIssue).ToList();
            if (ComboPoisk.SelectedIndex == 2)
                historyes = historyes.OrderBy(x => x.ReturnDate).ToList();
            if (ComboPoisk.SelectedIndex == 3)
                historyes = historyes.OrderBy(x => x.Book.Title).ToList();
            if (contextBook != null)
                historyes = historyes.Where(x => x.BookId == contextBook.Id).ToList();

            DataReminders.ItemsSource = historyes;
        }

        private void Reminders_Click(object sender, RoutedEventArgs e)
        {
            ComboPoisk.ItemsSource = new string[] { "Customer", "Date of issue", "Return until", "Title" };
            ComboPoisk.SelectedIndex = 3;
            contextBook = null;
            GridPanel.Width = new GridLength(0);
            ColumnTitle.Visibility = Visibility.Visible;
            historyes = App.DB.HistoryBook.Where(x => x.IsReturned == false).ToList();
            Refresh();
        }

        private void BookHistory_Click(object sender, RoutedEventArgs e)
        {
            contextBook = App.DB.Book.FirstOrDefault();
            PoiskText.Text = contextBook.Id.ToString();

            ComboPoisk.ItemsSource = new string[] { "Customer", "Date of issue", "Return until" };
            ComboPoisk.SelectedIndex = 0;
            GridPanel.Width = new GridLength(300);
            ColumnTitle.Visibility = Visibility.Hidden;
            historyes = App.DB.HistoryBook.Where(x => x.IsReturned == true).ToList();
            Refresh();
        }


        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog() { Filter = "*.csv; | *.csv;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var file = File.Create(dialog.FileName);
                file.Close();

                string text;
                if (contextBook == null)
                {
                    text = "Title;Customer;DateOfIssue;ReturnDate";
                    foreach(var item in historyes)
                    {
                        text += "\n" + item.Book.Title + ";" + item.Customer.Name + ";" + item.DateOfIssue.ToString() + ";" + item.ReturnDate.ToString();
                    }
                }
                else
                {
                    text = "Customer;DateOfIssue;ReturnDate";
                    foreach (var item in historyes)
                    {
                        text += "\n" + item.Customer.Name + ";" + item.DateOfIssue.ToString() + ";" + item.ReturnDate.ToString();
                    }
                }
                File.WriteAllText(dialog.FileName, text);
            }
        }

        private void ComboPoisk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void PoiskText_TextChanged(object sender, TextChangedEventArgs e)
        {
            contextBook = App.DB.Book.FirstOrDefault(x => x.Id.ToString().ToLower() == PoiskText.Text.ToLower());
            if (contextBook != null)
            {
                SearchedTitle.Text = contextBook.Title;
                SearchedSubtitle.Text = contextBook.Subtitle;
                Refresh();
            }
            else
            {
                DataReminders.ItemsSource = null;
                SearchedTitle.Text = "";
                SearchedSubtitle.Text = "";
            }
        }
    }
}
