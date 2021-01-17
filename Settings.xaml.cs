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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            forditas();
            if (File.ReadLines("Settings.txt").ElementAt(0) == "euro")
            {
                euro.IsChecked = true;   
            }
            if (File.ReadLines("Settings.txt").ElementAt(0) == "dollar")
            {
                dollar.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(0) == "forint")
            {
                forint.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(1) == "kilometer")
            {
                kilometer.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(1) == "mile")
            {
                euro.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(2) == "liter")
            {
                liter.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(2) == "cubefeet")
            {
                cubefeet.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(3) == "kmph")
            {
                kmph.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(3) == "mph")
            {
                mph.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(4) == "fullscreen")
            {
                fullscreen.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(4) == "windowed")
            {
                windowed.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(5) == "english")
            {
                english.IsChecked = true;
            }
            if (File.ReadLines("Settings.txt").ElementAt(5) == "magyar")
            {
                magyar.IsChecked = true;
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

        private void forint_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[0] = "forint";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void dollar_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[0] = "dollar";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void euro_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[0] = "euro";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void kilometer_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[1] = "kilometer";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void mile_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[1] = "mile";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void liter_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[2] = "liter";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void cubefeet_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[2] = "cubefeet";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void kmph_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[3] = "kmph";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void mph_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[3] = "mph";
            File.WriteAllLines("Settings.txt", ki);
        }
        private void magyar_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[5] = "magyar";
            File.WriteAllLines("Settings.txt", ki);

            forditas();
        }

        private void english_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[5] = "english";
            File.WriteAllLines("Settings.txt", ki);
            forditas();
        }

        private void fullsrceen_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[4] = "fullscreen";
            File.WriteAllLines("Settings.txt", ki);
        }

        private void windowed_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[4] = "windowed";
            File.WriteAllLines("Settings.txt", ki);
        }
        private void forditas()
        {
            if (File.ReadLines("Settings.txt").ElementAt(5) == "magyar")
            {
                CurrencyLabel.Content = "Pénznem";
                euro.Content = "Euró - €";
                dollar.Content = "Dollár - $";
                forint.Content = "Forint - Ft";
                LengthLabel.Content = "Hosszmérték";
                mile.Content = "Mérföld - mi";
                kilometer.Content = "Kilométer - km";
                SreenLabel.Content = "Képernyő";
                fullscreen.Content = "Teljesképernyős";
                windowed.Content = "Ablakos";
                VelocityLabel.Content = "Sebességmérték";
                mph.Content = "Mérföld/óra - mph";
                kmph.Content = "Kilóméter/óra - km/h";
                VolumeLabel.Content = "Térfogatmérték";
                cubefeet.Content = "Köbláb - cu ft";
                LanguageLabel.Content = "Nyelv";
                HomeButton.Content = "Kezdőlap";
            }
            else if (File.ReadLines("Settings.txt").ElementAt(5) == "english")
            {
                CurrencyLabel.Content = "Currency";
                euro.Content = "Euro - €";
                dollar.Content = "Dollar - $";
                forint.Content = "Forint - Ft";
                LengthLabel.Content = "Length";
                mile.Content = "Mile - mi";
                kilometer.Content = "Kilometer - km";
                SreenLabel.Content = "Srcreen mode";
                fullscreen.Content = "Fullscreen";
                windowed.Content = "Windowed";
                VelocityLabel.Content = "Velocity";
                mph.Content = "Miles/hour - mph";
                kmph.Content = "Kilometers/hour - kmh";
                VolumeLabel.Content = "Volume";
                cubefeet.Content = "Cubic feet - cu ft";
                LanguageLabel.Content = "Language";
                HomeButton.Content = "Home";
            }
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
        }
    }
}
