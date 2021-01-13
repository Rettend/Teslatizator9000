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
    /// Interaction logic for ModelY.xaml
    /// </summary>
    public partial class ModelY : UserControl
    {
        public ModelY()
        {
            InitializeComponent();
            if (File.ReadLines("Settings.txt").ElementAt(5) == "magyar")
            {
                HomeButton.Content = "Kezdőlap";
                AccelerationLabel.Content = "Gyorsulás";
                RangeLabel.Content = "Hatótávolság";
                TrunkSpaceLabel.Content = "Csomagtartó";
                SeatingLabel.Content = "Ülőhelyek";
                WheelsLabel.Content = "Kerekek";
                StartingLabel.Content = "Kezdőár";
                if (File.ReadLines("Settings.txt").ElementAt(1) == "kilometer")
                {
                    Range.Content = "505 kilométer";
                }
                if (File.ReadLines("Settings.txt").ElementAt(2) == "mile")
                {
                    Range.Content = "326 mérföld";
                }
                if (File.ReadLines("Settings.txt").ElementAt(2) == "cubefeet")
                {
                    TrunkSpace.Content = "68 köbláb";
                }
                if (File.ReadLines("Settings.txt").ElementAt(2) == "liter")
                {
                    TrunkSpace.Content = "1925 liter";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "euro")
                {
                    Price.Content = "40492 €";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "dollar")
                {
                    Price.Content = "$ 49990";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "forint")
                {
                    Price.Content = "13497300 Ft";
                }
            }
            if (File.ReadLines("Settings.txt").ElementAt(5) == "english")
            {
                if (File.ReadLines("Settings.txt").ElementAt(3) == "kmph")
                {
                    AccelerationYes.Content = "5.1s 0-100 km/h";
                }
                if (File.ReadLines("Settings.txt").ElementAt(1) == "kilometer")
                {
                    Range.Content = "505 kilometers";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "euro")
                {
                    Price.Content = "40492 €";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "dollar")
                {
                    Price.Content = "$ 49990";
                }
                if (File.ReadLines("Settings.txt").ElementAt(0) == "forint")
                {
                    Price.Content = "13497300 Ft";
                }
                if (File.ReadLines("Settings.txt").ElementAt(2) == "cubefeet")
                {
                    TrunkSpace.Content = "68 cubic feet";
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
                if (ModelYSub4.Parent != ModelYPanel1)
                {
                    ModelYPanel2.Children.Remove(ModelYSub4);
                    ModelYPanel2.Children.Remove(ModelYSub5);
                    ModelYPanel2.Children.Remove(ModelYSub6);
                    ModelYPanel1.Children.Add(ModelYSub4);
                    ModelYPanel1.Children.Add(ModelYSub5);
                    ModelYPanel1.Children.Add(ModelYSub6);
                    ModelYSub1.FontSize = 30;
                    ModelYSub2.FontSize = 30;
                    ModelYSub3.FontSize = 30;
                    ModelYSub4.FontSize = 30;
                    ModelYSub5.FontSize = 30;
                    ModelYSub6.FontSize = 30;
                }
                Grid.SetColumnSpan(ModelYBorder1, 2);
                ModelYBorder2.Visibility = Visibility.Hidden;
            }
            else
            {
                if (ModelYSub4.Parent == ModelYPanel1)
                {
                    ModelYPanel1.Children.Remove(ModelYSub4);
                    ModelYPanel1.Children.Remove(ModelYSub5);
                    ModelYPanel1.Children.Remove(ModelYSub6);
                    ModelYPanel2.Children.Add(ModelYSub4);
                    ModelYPanel2.Children.Add(ModelYSub5);
                    ModelYPanel2.Children.Add(ModelYSub6);
                    ModelYSub1.FontSize = 40;
                    ModelYSub2.FontSize = 40;
                    ModelYSub3.FontSize = 40;
                    ModelYSub4.FontSize = 40;
                    ModelYSub5.FontSize = 40;
                    ModelYSub6.FontSize = 40;
                }
                Grid.SetColumnSpan(ModelYBorder1, 1);
                ModelYBorder2.Visibility = Visibility.Visible;
            }
        }
    }
}
