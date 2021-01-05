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

        private void meter_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[1] = "meter";
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
        private void english_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                ki.Add(i);
            }
            ki[5] = "english";
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
                HomeButton.Content = "Home";
                MSButton.Content = "Model S";
                M3Button.Content = "Model 3";
                MXButton.Content = "Model X";
                MYButton.Content = "Model Y";
            }
        }
    }
}
