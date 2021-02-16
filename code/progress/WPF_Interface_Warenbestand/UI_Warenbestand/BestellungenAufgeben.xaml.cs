using System;
using System.Collections.Generic;
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

        }

        private void Abbruch_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lv_produkte_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Produkt produkt = (Produkt)lv_produkte.SelectedItem;
            lb_korb.Items.Add(produkt);
            preisBestellung += Convert.ToDecimal(produkt.Preis);

            tb_preis.Text = preisBestellung.ToString();
        }
    }
}
