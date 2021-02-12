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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }



        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
