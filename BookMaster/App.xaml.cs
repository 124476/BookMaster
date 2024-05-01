using BookMaster.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static BookMasterDatabaseEntities DB = new BookMasterDatabaseEntities();
        public static bool isOpen;
        public static int IndexPhoto;
    }
}
