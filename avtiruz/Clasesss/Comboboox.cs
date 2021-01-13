using avtiruz.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace avtiruz.Clasesss
{
    class Comboboox
    {
        public static void LoadLanguageInCombo(ComboBox comboBox)
        {
            var query = dbCotecs.db.Tovars.Select(item => new
            {
                title = item.Nazvanie
            });
            var collectionSelectedItem = from selectedItem in query select selectedItem.title;
            comboBox.ItemsSource = collectionSelectedItem.ToList();
        }
        public static void LoadLanguageInCombo2(ComboBox comboBox)
        {
            var query = dbCotecs.db.Postavshiki.Select(item => new
            {
                title = item.FIO
            });
            var collectionSelectedItem = from selectedItem in query select selectedItem.title;
            comboBox.ItemsSource = collectionSelectedItem.ToList();
        }
        public static void LoadLanguageInCombo3(ComboBox comboBox)
        {
            var query = dbCotecs.db.Postavshiki.Select(item => new
            {
                title = item.FIO
            });
            var collectionSelectedItem = from selectedItem in query select selectedItem.title;
            comboBox.ItemsSource = collectionSelectedItem.ToList();
        }
    }
}
