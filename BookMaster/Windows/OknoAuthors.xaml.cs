﻿using BookMaster.Models;
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
        Book contextBook;
        public OknoAuthors(Book book)
        {
            InitializeComponent();
        }

        private void ComboAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
