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
    /// Логика взаимодействия для addPostavchik.xaml
    /// </summary>
    public partial class addPostavchik : Page
    {
        public addPostavchik()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Postavshiki post = new Postavshiki();
                post.Nomer = Convert.ToInt32(txb_Number.Text);
                post.FIO = txb_FIO.Text;
                post.Adres = txb_Adres.Text;
                post.Telefon = txb_tel.Text;
              

                dbCotecs.db.Postavshiki.Add(post);
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
