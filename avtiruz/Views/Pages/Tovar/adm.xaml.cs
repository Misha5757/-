using avtiruz.Clasesss;
using avtiruz.Context;
using avtiruz.Model2;
using avtiruz.Views.Pages.Tovar.Edit;
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

namespace avtiruz.Views.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для adm.xaml
    /// </summary>
    public partial class adm : Page
    {

        public adm()
        {
            InitializeComponent();
            Comboboox.LoadLanguageInCombo3(Post22);
        }

        private void uploder_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                dbCotecs.db.SaveChanges();
                MessageBox.Show("Данные сохранены!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void uploder_Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addTovars());
        }
        private void uploder_Add_Copy2_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new addPostavchik());
        }
        private void uploder_Add_Copy3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addVse());
        }
        private void uploder_Delete_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tovars removeTovars = (Tovars)dataView2.SelectedItem;

                Postavshic removePostavshic = (Postavshic)dataView.SelectedItem;
                Postavshiki removePostavshiki = (Postavshiki)dataView1.SelectedItem;
                if (MessageBox.Show("Вы действительно хотите далить выбранный элемент? Данные будут удалены навсегда!",
                    "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (removeTovars != null)
                    {
                        dbCotecs.db.Tovars.Remove(removeTovars);
                        dbCotecs.db.SaveChanges();
                        Page_Loaded(null, null);
                    }




                    if (removePostavshic != null)
                    {

                        dbCotecs.db.Postavshic.Remove(removePostavshic);
                        dbCotecs.db.SaveChanges();
                        Page_Loaded(null, null);
                    }





                    if (removePostavshiki != null)
                    {

                        dbCotecs.db.Postavshiki.Remove(removePostavshiki);
                        dbCotecs.db.SaveChanges();
                        Page_Loaded(null, null);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = dbCotecs.db.Postavshic.ToList();
            dataView2.ItemsSource = dbCotecs.db.Tovars.ToList();
            dataView1.ItemsSource = dbCotecs.db.Postavshiki.ToList();
        }

      

     

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Viborka_ID.Viborka());

        }

        private void Cena_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Viborka_ID.viborka2());
        }

        private void Cena_Cop2y_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Viborka_ID.Viborka3());
        }

        private void ff_Checked(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
     
