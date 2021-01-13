using avtiruz.Clasesss;
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
    /// Логика взаимодействия для addVse.xaml
    /// </summary>
    public partial class addVse : Page
    {
        public addVse()
        {
            InitializeComponent();
            Comboboox.LoadLanguageInCombo(cmbTovar);
            Comboboox.LoadLanguageInCombo2(cmbpost);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
             
            Postavshic postt = new Postavshic();
            
            postt.Nomer_cheta = Convert.ToInt32(txb_Number2.Text);
            postt.Data = txb_data.Text;
            postt.Srok_Postavki = txb_srok.Text;
            postt.Kol_tovara = txb_kol2.Text;
            postt.Cena = txb_many.Text;
            var current = dbCotecs.db.Tovars.FirstOrDefault(item => item.Nazvanie.ToString() == cmbTovar.Text);
             postt.Tovar = current.Kod_Tovar;
            var currentpost = dbCotecs.db.Postavshiki.FirstOrDefault(item => item.FIO.ToString() == cmbpost.Text);
            postt.Postavshik = currentpost.Nomer;
            dbCotecs.db.Postavshic.Add(postt);
            dbCotecs.db.SaveChanges();
            MessageBox.Show("Данные сохранены!");
            NavigationService.GoBack();
       
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
