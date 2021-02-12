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
using System.Windows.Shapes;

namespace UI_Warenbestand
{
    /// <summary>
    /// Interaktionslogik für Bestellungen.xaml
    /// </summary>
    public partial class Bestellungen : Window
    {
        public Bestellungen()
        {
            InitializeComponent();
        }

        private void warenbestand_Click(object sender, RoutedEventArgs e)
        {

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

        private void beenden_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
