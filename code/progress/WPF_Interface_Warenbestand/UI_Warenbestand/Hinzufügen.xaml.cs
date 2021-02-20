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
                case 2:
                    idProduktKategorie = 3;
                    break;
            }
            try
            {
                if(Convert.ToInt32(Preis.Text) <0 || Convert.ToInt32(Anzahl.Text) < 0)
                {
                    return;
                }
                Produkt produkt = new Produkt
                {
                    Bezeichnung = tb_Name.Text,
                    Preis = Convert.ToDecimal(Preis.Text),
                    ID_ProduktKategorie = idProduktKategorie,
                    Anzahl = Convert.ToInt32(Anzahl.Text)
                };
                entities.Produkt.Add(produkt);
                entities.SaveChanges();
            }

            catch (Exception)
            {
                return;
            }
            Window warenbestand = new Window1();
            warenbestand.Show();
            this.Close();
        }
    

        private void btn_verwerfen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
