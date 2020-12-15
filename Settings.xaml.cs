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
        public Settings(string sor)
        {
            InitializeComponent();

            string[] m = sor.Split(';');
            Penznem = m[0];
            Hosszmertek = m[1];
            Terfogatmertek = m[2];
            Sebessegmertek = m[3];
        }

        public string Penznem { get; private set; }

        public string Hosszmertek { get; private set; }

        public string Terfogatmertek { get; private set; }

        public string Sebessegmertek { get; private set; }



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
            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                MainWindow.panel.Children.Add(new Settings(i));
            }

            
        }

        private void forint_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                i.Replace(i.Split(';')[0], "forint");
                ki.Add(i);
            }
            File.AppendAllText("Settings.txt", ki.ToString());
        }

        private void dollar_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                i.Replace(i.Split(';')[0], "dollar");
                ki.Add(i);
            }
            File.AppendAllText("Settings.txt", ki.ToString());
        }

        private void euro_Checked(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();

            foreach (var i in File.ReadAllLines("Settings.txt"))
            {
                i.Replace(i.Split(';')[0], "euro");
                ki.Add(i);
            }
            File.AppendAllText("Settings.txt", ki.ToString());
        }

        //C:\Users\Miklós\Documents\GitHub\Teslatizator9000\Settings.txt
    }
}
