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
    /// Логика взаимодействия для PageCustomet.xaml
    /// </summary>
    public partial class PageCustomet : Page
    {
        Customer contextCustomer;
        public PageCustomet(Customer customer)
        {
            InitializeComponent();
            contextCustomer = customer;
            DataContext = contextCustomer;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (contextCustomer.IdC != null && contextCustomer.Name != null && contextCustomer.Address != null
                && contextCustomer.City != null && contextCustomer.Zip != null && contextCustomer.Email != null
                && contextCustomer.Phone != null)
            {
                if (contextCustomer.Id == 0)
                {
                    App.DB.Customer.Add(contextCustomer);
                }
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
