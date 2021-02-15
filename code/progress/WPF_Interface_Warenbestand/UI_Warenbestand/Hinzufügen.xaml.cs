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
    /// Interaktionslogik für Hinzufügen.xaml
    /// </summary>
    public partial class Hinzufügen : Window
    {
        private FahrradladenEntities entities = new FahrradladenEntities();

        public Hinzufügen()
        {
            InitializeComponent();
        }

        private void btn_absenden_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Produkt produkt = new Produkt
                {
                    Bezeichnung = Name.Text,
                    Preis = Convert.ToDecimal(Preis.Text),
                    ID_ProduktKategorie = Convert.ToInt32(Kategorie.Text)
                };
                entities.Produkt.Add(produkt);
                entities.SaveChanges();
            }
            catch (Exception)
            {

            }
        }
    }
}
