using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

namespace UI_Warenbestand
{
    /// <summary>
    /// Interaktionslogik für Bestellungen.xaml
    /// </summary>
    /// 
    public partial class Bestellungen : Window
    {
        private ICollectionView collectionView;
        private ICollectionView collectionView2;

        private FahrradladenEntities entities = new FahrradladenEntities();

        public Bestellungen()
        {
            InitializeComponent();
        }

        private void warenbestand_Click(object sender, RoutedEventArgs e)
        {
            Window warenbestand = new UI_Warenbestand.Window1();
            warenbestand.Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Window home = new MainWindow();
            home.Show();
            this.Close();
        }

        private void bestellungen_Click(object sender, RoutedEventArgs e)
        {
            Window bestellungen = new UI_Warenbestand.Bestellungen();
            bestellungen.Show();
            this.Close();
        }

        private void warenbestand_Click_1(object sender, RoutedEventArgs e)
        {
            Window warenbestand = new UI_Warenbestand.Window1();
            warenbestand.Show();
            this.Close();
        }

        // Exit Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            entities.Bestellung.Load();
            entities.Produkt.Load();
            entities.Posten.Load();
            collectionView = CollectionViewSource.GetDefaultView(entities.Bestellung.Local);
            stkpnl_Bestellungen.DataContext = collectionView;
            collectionView2 = CollectionViewSource.GetDefaultView(entities.Posten.Local);
            stkpnl_BestDetails.DataContext = collectionView2;
        }

        private void top_panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_BestellungHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Window BestellungAufgeben = new UI_Warenbestand.BestellungenAufgeben();
            BestellungAufgeben.Show();
        }

        private void dtg_Bestellungen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lb_details.Items.Clear();
            string detail = "";
            if (dtg_Bestellungen.SelectedItem != null)
            {
                Bestellung Bestellung = (Bestellung)dtg_Bestellungen.SelectedItem;
                foreach (var posten in Bestellung.Posten)
                {
                    detail += posten.Produkt.Bezeichnung+"("+posten.Anzahl+"): "+posten.Produkt.Preis*posten.Anzahl+"\n";
                }
                lb_details.Items.Add(detail);
            }
            Window bestellungen = new UI_Warenbestand.Bestellungen();
            bestellungen.Show();
            this.Close();
        }
    }
}
