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
    /// Interaction logic for ModelS.xaml
    /// </summary>
    public partial class ModelS : UserControl
    {
        public ModelS()
        {
            InitializeComponent();

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("mph"))
                {
                    AccelerationYes.Content = "3.7s 0-60 mph";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("kmph"))
                {
                    AccelerationYes.Content = "2.5s 0-100 kmph";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("mile"))
                {
                    Range.Content = $"402 miles";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("meter"))
                {
                    Range.Content = $"646956 meters";
                }
            }
        

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("euro"))
                {
                    Price.Content = "56230 €";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("forint"))
                {
                    Price.Content = "20617740 ft";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("dollar"))
                {
                    Price.Content = "$ 69420";
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
    }
}
