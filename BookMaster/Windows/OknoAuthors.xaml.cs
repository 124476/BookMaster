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
using System.Windows.Shapes;

namespace BookMaster.Windows
{
    /// <summary>
    /// Логика взаимодействия для OknoAuthors.xaml
    /// </summary>
    public partial class OknoAuthors : Window
    {
        public OknoAuthors(Book book)
        {
            InitializeComponent();
            var authors = App.DB.Bookauthor.Where(x => x.BookId == book.Id).ToList().Select(x => x.Author).ToList();
            ComboAuthors.ItemsSource = authors;
            ComboAuthors.SelectedIndex = 0;
        }

        private void ComboAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataContext = ComboAuthors.SelectedItem as Author;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Author author = ComboAuthors.SelectedItem as Author;
            if (author != null)
                System.Diagnostics.Process.Start(author.Wikipedia);
        }
    }
}
