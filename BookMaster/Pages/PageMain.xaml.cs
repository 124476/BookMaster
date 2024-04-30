using BookMaster.Models;
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

namespace BookMaster.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        int contextRow;
        Book contextBook;

        public PageMain()
        {
            InitializeComponent();
            UpBtn.Content = "<";
            LastBtn.Content = "<";
            contextRow = 1;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var books = App.DB.Book.ToList().Skip(50 * (contextRow - 1)).ToList().Take(50).ToList();

            books = books.Where(x => x.Title.ToLower().Contains(PoiskTitle.Text.ToLower())).ToList();

            books = books.Where(x => x.Authors.ToLower().Contains(PoiskAuthor.Text.ToLower())).ToList();

            books = books.Where(x => x.Subjects.ToLower().Contains(PoiskSubject.Text.ToLower())).ToList();

            DataBooks.ItemsSource = books;
            DataContext = contextBook;
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            if (contextRow != 1)
                contextRow--;
            SearchText.Text = contextRow.ToString();
            Refresh();
        }

        private void DownBtn_Click(object sender, RoutedEventArgs e)
        {
            contextRow++;
            SearchText.Text = contextRow.ToString();
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void LastBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataBooks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Book book = DataBooks.SelectedItem as Book;
            if (book != null)
            {
                contextBook = book;
                Refresh();
                var dialog = new OknoAuthors(book);
                dialog.Show();
            }
        }
    }
}
