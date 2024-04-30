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
    /// Логика взаимодействия для PageCustomers.xaml
    /// </summary>
    public partial class PageCustomers : Page
    {
        public PageCustomers()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = DataCustomers.SelectedItem as Customer;
            if (customer != null)
            {
                NavigationService.Navigate(new PageCustomet(customer));
            }
            else
            {
                MessageBox.Show("Выберите customer!");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var customers = App.DB.Customer.ToList();

            customers = customers.Where(x => x.IdC.ToLower().Contains(PoiskCustomer.Text.ToLower())).ToList();

            customers = customers.Where(x => x.Name.ToLower().Contains(PoiskName.Text.ToLower())).ToList();

            DataCustomers.ItemsSource = customers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCustomet(new Customer()));
        }
    }
}
