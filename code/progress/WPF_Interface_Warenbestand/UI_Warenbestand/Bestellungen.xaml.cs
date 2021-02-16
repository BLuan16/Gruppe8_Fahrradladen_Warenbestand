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


        // Buttons um die Bestellungen zu verwalten noch benoetigt, bin mir nicht sicher was wir alles definitiv brauchen
        // Desweiteren belasse ich den Datagrid mit den normalen 3 Eintraegen also ID, Name und Preis vorerst nur fuer Testzwecke
    }
}
