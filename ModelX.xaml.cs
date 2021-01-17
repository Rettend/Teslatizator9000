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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Teslatizator9000
{
    /// <summary>
    /// Interaction logic for ModelX.xaml
    /// </summary>
    public partial class ModelX : UserControl
    {
        public ModelX()
        {
            InitializeComponent();
            if (File.ReadLines("Settings.txt").ElementAt(5) == "magyar")
            {
                HomeButton.Content = "Kezdőlap";
                AccelerationLabel.Content = "Gyorsulás";
                RangeLabel.Content = "Hatótávolság";
                TrunkSpaceLabel.Content = "Csomagtartó";
                SeaingLabel.Content = "Ülőhelyek";
                WheelsLabel.Content = "Kerekek";
                StartingLabel.Content = "Kezdőár";
                if (File.ReadLines("Settings.txt").ElementAt(2) == "kilometer")
                {
                    Range.Content = "561 kilométer";
                }
                else
                {
                    Range.Content = "371 mérföld";
                }
                if (File.ReadLines("Settings.txt").ElementAt(2) == "cubefeet")
                {
                    TrunkSpace.Content = "88 köbláb";
                }
                else
                {
                    TrunkSpace.Content = "2491 liter";
                }
            }
            else
            {
                if (File.ReadLines("Settings.txt").ElementAt(3) == "kmph")
                {
                    AccelerationYes.Content = "4.6s 0-100 km/h";
                }
                if (File.ReadLines("Settings.txt").ElementAt(1) == "kilometer")
                {
                    Range.Content = "561 kilometers";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "euro")
                {
                    Price.Content = "64 792 €";
                }
                else if (File.ReadLines("Settings.txt").ElementAt(0) == "dollar")
                {
                    Price.Content = "$ 79 990";
                }
                if (File.ReadLines("Settings.txt").ElementAt(2) == "cubefeet")
                {
                    TrunkSpace.Content = "88 cubic feet";
                }
            }
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
        private void Button_Click_Konfig(object sender, RoutedEventArgs e)
        {
            MainWindow.panel.Children.Clear();
            MainWindow.panel.Children.Add(new Konfig());
        }
        private void Container_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ActualWidth < 1100)
            {
                HomeButton.Content = "H";
                MSButton.Content = "S";
                M3Button.Content = "3";
                MXButton.Content = "X";
                MYButton.Content = "Y";
            }
            else
            {
                if (File.ReadLines("Settings.txt").ElementAt(5) == "magyar")
                {
                    HomeButton.Content = "Kezdőlap";
                }
                else
                {
                    HomeButton.Content = "Home";
                }
                MSButton.Content = "Model S";
                M3Button.Content = "Model 3";
                MXButton.Content = "Model X";
                MYButton.Content = "Model Y";
            }
            if (ActualWidth < 780)
            {
                if (ModelXSub4.Parent != ModelXPanel1)
                {
                    ModelXPanel2.Children.Remove(ModelXSub4);
                    ModelXPanel2.Children.Remove(ModelXSub5);
                    ModelXPanel2.Children.Remove(ModelXSub6);
                    ModelXPanel1.Children.Add(ModelXSub4);
                    ModelXPanel1.Children.Add(ModelXSub5);
                    ModelXPanel1.Children.Add(ModelXSub6);
                    ModelXSub1.FontSize = 30;
                    ModelXSub2.FontSize = 30;
                    ModelXSub3.FontSize = 30;
                    ModelXSub4.FontSize = 30;
                    ModelXSub5.FontSize = 30;
                    ModelXSub6.FontSize = 30;
                }
                Grid.SetColumnSpan(ModelXBorder1, 2);
                ModelXBorder2.Visibility = Visibility.Hidden;
            }
            else
            {
                if (ModelXSub4.Parent == ModelXPanel1)
                {
                    ModelXPanel1.Children.Remove(ModelXSub4);
                    ModelXPanel1.Children.Remove(ModelXSub5);
                    ModelXPanel1.Children.Remove(ModelXSub6);
                    ModelXPanel2.Children.Add(ModelXSub4);
                    ModelXPanel2.Children.Add(ModelXSub5);
                    ModelXPanel2.Children.Add(ModelXSub6);
                    ModelXSub1.FontSize = 40;
                    ModelXSub2.FontSize = 40;
                    ModelXSub3.FontSize = 40;
                    ModelXSub4.FontSize = 40;
                    ModelXSub5.FontSize = 40;
                    ModelXSub6.FontSize = 40;
                }
                Grid.SetColumnSpan(ModelXBorder1, 1);
                ModelXBorder2.Visibility = Visibility.Visible;
            }
        }
    }
}
