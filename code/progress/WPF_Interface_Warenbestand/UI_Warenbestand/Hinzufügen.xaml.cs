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
            int idProduktKategorie = 0;
            switch (cb_kategorie.SelectedIndex)
            {
                case 0:
                    idProduktKategorie = 1;
                    break;
                case 1:
                    idProduktKategorie = 2;
                    break;
                case 3:
                    idProduktKategorie = 3;
                    break;
            }
            try
            {
                Produkt produkt = new Produkt
                {
                    Bezeichnung = Name.Text,
                    Preis = Convert.ToDecimal(Preis.Text),
                    ID_ProduktKategorie = idProduktKategorie
                };
                entities.Produkt.Add(produkt);
                entities.SaveChanges();
            }

            catch (Exception)
            {

            }
            Window warenbestand = new UI_Warenbestand.Window1();
            warenbestand.Show();
            this.Close();
        }
    

        private void btn_verwerfen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
