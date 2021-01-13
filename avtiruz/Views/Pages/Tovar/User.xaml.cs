using avtiruz.Context;
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

namespace avtiruz.Views.Pages.Tovar
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Page
    {
        public User()
        {
            InitializeComponent();
            dataView.ItemsSource = dbCotecs.db.Postavshic.ToList();
            dataView2.ItemsSource = dbCotecs.db.Tovars.ToList();
            dataView1.ItemsSource = dbCotecs.db.Postavshiki.ToList();
        }
    }
}
