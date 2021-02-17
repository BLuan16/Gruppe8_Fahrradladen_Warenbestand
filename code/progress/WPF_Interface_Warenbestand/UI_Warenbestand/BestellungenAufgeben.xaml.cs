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
    /// Interaktionslogik für BestellungenAufgeben.xaml
    /// </summary>
    public partial class BestellungenAufgeben : Window
    {
        FahrradladenEntities entities = new FahrradladenEntities();

        private decimal preisBestellung;

        private List<Produkt> ausgewaehlteProdukte = new List<Produkt>();

        private Bestellung Bestellung = new Bestellung();
        
        public BestellungenAufgeben()
        {
            InitializeComponent();

            DbSet<Produkt> produkte = entities.Produkt;
            foreach (var pro in produkte)
            {
                lv_produkte.Items.Add(pro);
            }
        }

        private void Absenden_Click(object sender, RoutedEventArgs e)
        {
            Bestellung.Datum = DateTime.Now;
            Bestellung.Summe = preisBestellung;
            entities.Bestellung.Add(Bestellung);
            entities.SaveChanges();
            this.Close();
        }

        private void Abbruch_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lv_produkte_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Produkt produkt = (Produkt)lv_produkte.SelectedItem;
            if (!ausgewaehlteProdukte.Contains(produkt))
            {
                Posten posten = new Posten();
                ausgewaehlteProdukte.Add(produkt);
                posten.Produkt = produkt;
                posten.Anzahl = 1;
                posten.Preis = produkt.Preis;
                Bestellung.Posten.Add(posten);
            }
            else
            {
                foreach (Posten p in Bestellung.Posten)
                {
                    if (p.Produkt == produkt)
                    {
                        p.Preis += produkt.Preis;
                        p.Anzahl++;
                    }
                }
            }
            lb_korb.Items.Clear();
            foreach (var posten in Bestellung.Posten)
            {
                lb_korb.Items.Add(posten);
            }

            preisBestellung += Convert.ToDecimal(produkt.Preis);

            tb_preis.Text = preisBestellung.ToString();
        }
    }
}
