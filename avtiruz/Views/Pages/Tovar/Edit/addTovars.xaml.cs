using avtiruz.Context;
using avtiruz.Model2;
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

namespace avtiruz.Views.Pages.Tovar.Edit
{
    /// <summary>
    /// Логика взаимодействия для addTovars.xaml
    /// </summary>
    public partial class addTovars : Page
    {
        public addTovars()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Tovars Tovaris = new Tovars();
                Tovaris.Kod_Tovar = Convert.ToInt32(txb_kod.Text);
                Tovaris.Nazvanie = txb_nazv.Text;
                Tovaris.Edinica_Izmerenia = txb_edin.Text;
                Tovaris.Kl_na_cklade = txb_kol.Text;
                Tovaris.Opisanie = txb_opis.Text;

                dbCotecs.db.Tovars.Add(Tovaris);
                dbCotecs.db.SaveChanges();
                MessageBox.Show("Данные сохранены!");
                NavigationService.GoBack();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
