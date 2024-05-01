using BookMaster.Models;
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

namespace BookMaster.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCirculation.xaml
    /// </summary>
    public partial class PageCirculation : Page
    {
        Customer contextCustomer;
        Book contextBook;
        public PageCirculation()
        {
            InitializeComponent();
        }

        private void Circulation_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = App.DB.Customer.FirstOrDefault(x => x.IdC == PoiskCustomer.Text);
            if (customer != null)
            {
                contextCustomer = customer;
                Edit.IsEnabled = true;
                Refresh();
            }
            else
            {
                MessageBox.Show("Такой посетитель не найден!");
            }
        }

        private void Refresh()
        {
            DataContext = contextCustomer;
            if (contextCustomer != null)
            {
                var historyNoReturn = App.DB.HistoryBook.Where(x => x.CustomerId == contextCustomer.Id && x.IsReturned == false).ToList();
                DataIssues.ItemsSource = historyNoReturn;
                var historyes = App.DB.HistoryBook.Where(x => x.CustomerId == contextCustomer.Id && x.IsReturned == true).ToList();
                DataHistory.ItemsSource = historyes;
            }

            if (contextBook != null)
            {
                var bookReturned = App.DB.HistoryBook.FirstOrDefault(x => x.BookId == contextBook.Id && x.CustomerId == contextCustomer.Id && x.IsReturned == false);
                if (bookReturned != null)
                {
                    IssueBtn.IsEnabled = false;
                    ReturnBtn.IsEnabled = true;
                    return;
                }
                IssueBtn.IsEnabled = true;
                ReturnBtn.IsEnabled = false;
            }
        }

        private void IssueBtn_Click(object sender, RoutedEventArgs e)
        {
            HistoryBook historyBook = new HistoryBook();
            historyBook.CustomerId = contextCustomer.Id;
            historyBook.DateOfIssue = DateTime.Now;
            historyBook.ReturnDate = DateTime.Now.AddMonths(1);
            historyBook.IsReturned = false;
            historyBook.Book = contextBook;

            App.DB.HistoryBook.Add(historyBook);
            App.DB.SaveChanges();
            Refresh();
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            HistoryBook historyBook = App.DB.HistoryBook.FirstOrDefault(x => x.BookId == contextBook.Id && x.CustomerId == contextCustomer.Id && x.IsReturned == false);
            historyBook.CustomerId = contextCustomer.Id;
            historyBook.ReturnDate = DateTime.Now;
            historyBook.IsReturned = true;

            App.DB.SaveChanges();
            Refresh();
        }

        private void RenewBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCustomet(contextCustomer));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void PoiskBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            Book book = App.DB.Book.FirstOrDefault(x => x.Id.ToString().Contains(PoiskBook.Text.ToLower()));
            if (book != null)
            {
                contextBook = book;
                SearchBook.Text = "Title: " + contextBook.Title;
            }
            else
            {
                IssueBtn.IsEnabled = false;
                ReturnBtn.IsEnabled = false;
                RenewBtn.IsEnabled = false;
                SearchBook.Text = "Книга не найдена!";
                contextBook = null;
            }
            Refresh();
        }
    }
}
