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
    /// Логика взаимодействия для OknoLogin.xaml
    /// </summary>
    public partial class OknoLogin : Window
    {
        public OknoLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "admin" && Password.Text == "admin123")
            {
                DialogResult = true;
                App.isOpen = true;
            }
            else
                MessageBox.Show("Ошибка входа!");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
