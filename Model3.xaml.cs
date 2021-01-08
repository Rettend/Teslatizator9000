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
    /// Interaction logic for Model3.xaml
    /// </summary>
    public partial class Model3 : UserControl
    {
        public Model3()
        {
            InitializeComponent();
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("mph"))
                {
                    AccelerationYes.Content = "4.2s 0-60 mph";
                }

                if (i.Contains("kmph"))
                {
                    AccelerationYes.Content = "3.3s 0-100 kmph";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("mile"))
                {
                    Range.Content = $"353 miles";
                }

                if (i.Contains("kilometer"))
                {
                    Range.Content = $"568 kilometers";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("euro"))
                {
                    Price.Content = "30772 €";
                }

                if (i.Contains("forint"))
                {
                    Price.Content = "10257300 Ft";
                }

                if (i.Contains("dollar"))
                {
                    Price.Content = "$ 37990";
                }
            }

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                if (i.Contains("liter"))
                {
                    TrunkSpace.Content = "424 liters";
                }

                if (i.Contains("cubefeet"))
                {
                    TrunkSpace.Content = "15 cubic feet";
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
                HomeButton.Content = "Home";
                MSButton.Content = "Model S";
                M3Button.Content = "Model 3";
                MXButton.Content = "Model X";
                MYButton.Content = "Model Y";
            }
            if (ActualWidth < 780)
            {
                if (Model3Sub4.Parent != Model3Panel1)
                {
                    Model3Panel2.Children.Remove(Model3Sub4);
                    Model3Panel2.Children.Remove(Model3Sub5);
                    Model3Panel2.Children.Remove(Model3Sub6);
                    Model3Panel1.Children.Add(Model3Sub4);
                    Model3Panel1.Children.Add(Model3Sub5);
                    Model3Panel1.Children.Add(Model3Sub6);
                    Model3Sub1.FontSize = 30;
                    Model3Sub2.FontSize = 30;
                    Model3Sub3.FontSize = 30;
                    Model3Sub4.FontSize = 30;
                    Model3Sub5.FontSize = 30;
                    Model3Sub6.FontSize = 30;
                }
                Grid.SetColumnSpan(Model3Border1, 2);
                Model3Border2.Visibility = Visibility.Hidden;
            }
            else
            {
                if (Model3Sub4.Parent == Model3Panel1)
                {
                    Model3Panel1.Children.Remove(Model3Sub4);
                    Model3Panel1.Children.Remove(Model3Sub5);
                    Model3Panel1.Children.Remove(Model3Sub6);
                    Model3Panel2.Children.Add(Model3Sub4);
                    Model3Panel2.Children.Add(Model3Sub5);
                    Model3Panel2.Children.Add(Model3Sub6);
                    Model3Sub1.FontSize = 40;
                    Model3Sub2.FontSize = 40;
                    Model3Sub3.FontSize = 40;
                    Model3Sub4.FontSize = 40;
                    Model3Sub5.FontSize = 40;
                    Model3Sub6.FontSize = 40;
                }
                Grid.SetColumnSpan(Model3Border1, 1);
                Model3Border2.Visibility = Visibility.Visible;
            }
        }
    }
}
