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

namespace Teslatizator9000
{
    /// <summary>
    /// Interaction logic for Konfig.xaml
    /// </summary>
    public partial class Konfig : UserControl
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public string Tire { get; private set; }
        public string Interior { get; private set; }
        public Konfig()
        {
            InitializeComponent();
            Model = "Model3";
            Color = "Feher";
            Tire = "Kerek1";
            Interior = "Feher";
        }

        private void Button_Click_Off(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new Home());
        }
        private void Button_Click_ModelS(object sender, RoutedEventArgs s)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new ModelS());
        }
        private void Button_Click_Model3(object sender, RoutedEventArgs s)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new Model3());
        }
        private void Button_Click_ModelX(object sender, RoutedEventArgs s)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new ModelX());
        }
        private void Button_Click_ModelY(object sender, RoutedEventArgs s)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new ModelY());
        }
        private void Button_Click_Settings(object sender, RoutedEventArgs e)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new Settings());
        }

        private void WhiteUi(object sender, RoutedEventArgs e)
        {
            Color = "Feher";
            UpdateImage("exterior");
        }
        private void GrayUi(object sender, RoutedEventArgs e)
        {
            Color = "Metalic";
            UpdateImage("exterior");
        }
        private void BlackUi(object sender, RoutedEventArgs e)
        {
            Color = "Fekete";
            UpdateImage("exterior");
        }
        private void RedUi(object sender, RoutedEventArgs e)
        {
            Color = "Piros";
            UpdateImage("exterior");
        }
        private void BlueUi(object sender, RoutedEventArgs e)
        {
            Color = "Kek";
            UpdateImage("exterior");
        }
        private void WhiteTire(object sender, RoutedEventArgs e)
        {
            Tire = "Kerek1";
            UpdateImage("exterior");
        }
        private void BlackTire(object sender, RoutedEventArgs e)
        {
            Tire = "Kerek2";
            UpdateImage("exterior");
        }
        private void WhiteInt(object sender, RoutedEventArgs e)
        {
            Interior = "Feher";
            UpdateImage("interior");
        }
        private void BlackInt(object sender, RoutedEventArgs e)
        {
            Interior = "Fekete";
            UpdateImage("interior");
        }
        private void CreamInt(object sender, RoutedEventArgs e)
        {
            Interior = "Cream";
            UpdateImage("interior");
        }
        private void ModelS(object sender, RoutedEventArgs e)
        {
            Model = "ModelS";
            DisabledInt.Focusable = true;
            DisabledInt.IsHitTestVisible = true;
            ResetImage();
        }
        private void Model3(object sender, RoutedEventArgs e)
        {
            Model = "Model3";
            DisabledInt.Focusable = false;
            DisabledInt.IsHitTestVisible = false;
            ResetImage();
        }
        private void ModelX(object sender, RoutedEventArgs e)
        {
            Model = "ModelX";
            DisabledInt.Focusable = true;
            DisabledInt.IsHitTestVisible = true;
            ResetImage();
        }
        private void ModelY(object sender, RoutedEventArgs e)
        {
            Model = "ModelY";
            DisabledInt.Focusable = false;
            DisabledInt.IsHitTestVisible = false;
            ResetImage();
        }

        private void UpdateImage(string folder)
        {
            if (folder == "interior")
            {
                intImage.Source = new BitmapImage(new Uri($@"images\{Model}\interior\{Model}_Belso_{Interior}.png", UriKind.Relative));
            }
            else
            {
                extImage.Source = new BitmapImage(new Uri($@"images\{Model}\exterior\{Model}_{Color}_{Tire}.png", UriKind.Relative));
            }
        }
        private void IntImageLoaded(object sender, RoutedEventArgs e)
        {
            UpdateImage("interior");
            UpdateImage("exterior");
        }
        private void ResetImage()
        {
            Color = "Feher";
            Tire = "Kerek1";
            UpdateImage("exterior");
            Interior = "Feher";
            UpdateImage("interior");
            DefaultInt.IsChecked = true;
            DefaultTire.IsChecked = true;
            DefaultUi.IsChecked = true;
        }
    }
}
