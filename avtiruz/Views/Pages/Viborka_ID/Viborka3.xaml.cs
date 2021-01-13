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

namespace avtiruz.Views.Pages.Viborka_ID
{
    /// <summary>
    /// Логика взаимодействия для Viborka3.xaml
    /// </summary>
    public partial class Viborka3 : Page
    {
        public Viborka3()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = dbCotecs.db.Postavshic.ToList();
            var ya = dbCotecs.db.Postavshic.Where(t => t.Tovars.Nazvanie == "инструмент").OrderByDescending(t => t.Data).ToList();
            dataView.ItemsSource = ya;
        }
    }
}
