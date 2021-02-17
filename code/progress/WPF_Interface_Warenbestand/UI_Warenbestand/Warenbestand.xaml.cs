using LiveCharts;
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
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace UI_Warenbestand
{
    public partial class Window1 : Window
    {
        private ICollectionView collectionView;

        private FahrradladenEntities entities = new FahrradladenEntities();

        public SeriesCollection series { get; set; }

        public Window1()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            entities.Produkt.Load();
            entities.ProduktKategorie.Load();
            collectionView = CollectionViewSource.GetDefaultView(entities.Produkt.Local);
            stkpnl_Warenbestand.DataContext = collectionView;

            int raeder = 20;
            int ersatz = 40;
            int zubeh = 20;

            foreach (var produkt in entities.Produkt)
            {
                switch (produkt.ID_ProduktKategorie)
                {
                    case 1:
                        raeder+=(int)(produkt.Preis*produkt.Anzahl);
                        break;
                    case 2:
                        ersatz+=(int)(produkt.Preis * produkt.Anzahl);
                        break;
                    case 3:
                        zubeh+=(int)(produkt.Preis * produkt.Anzahl);
                        break;
                }
            }

            series = new SeriesCollection
            {
                new PieSeries
                {
                    Title="Fahrräder",
                    Values= new ChartValues<int>{raeder},
                    DataLabels=true
                },
                new PieSeries
                {
                    Title="Ersatzteile",
                    Values= new ChartValues<int>{ersatz},
                    DataLabels=true
                },
                new PieSeries
                {
                    Title="Zubehör",
                    Values= new ChartValues<int>{zubeh},
                    DataLabels=true
                },
            };

            foreach (PieSeries ps in series)
            {
                pie.Series.Add(ps);
            }
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Window home = new MainWindow();
            home.Show();
            this.Close();
        }
        
        private void warenbestand_Click(object sender, RoutedEventArgs e)
        {
            Window warenbestand = new UI_Warenbestand.Window1();
            warenbestand.Show();
            this.Close();
        }

        private void bestellungen_Click(object sender, RoutedEventArgs e)
        {
            Window bestellungen = new UI_Warenbestand.Bestellungen();
            bestellungen.Show();
            this.Close();
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_WarenHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Window Hinzufügen = new UI_Warenbestand.Hinzufügen();
            Hinzufügen.Show();          
        }

        private void btn_WarenLoeschen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Produkt produkt = (Produkt)collectionView.CurrentItem;
                entities.Produkt.Remove(produkt);
                entities.SaveChanges();
                Window1 window = new Window1();
                window.Show();
                this.Close();
            }
            catch (Exception)
            {
                Fehlermeldung fehlermeldung = new Fehlermeldung();
                fehlermeldung.Show();
                this.Close();
            }
        }

        private void btn_WarenAendern_Click(object sender, RoutedEventArgs e)
        {
            entities.SaveChanges();
        }

        private void top_panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


    }
}

