using System;
using System.Windows;
using System.Windows.Input;



namespace UI_Warenbestand
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void top_panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }




        //void beenden_Click(object sender, RoutedEventArgs e)
        //{

        //    //   Environment.Exit(0);
        //    // Application.Current.Shutdown();

        //    this.Close();

        //}
        //               try
        //        {
        //            Close();
        //}

        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

    }
}