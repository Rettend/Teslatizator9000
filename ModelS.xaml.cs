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
                if (ModelSSub3.Parent != ModelSPanel1)
                {
                    ModelSPanel2.Children.Remove(ModelSSub3);
                    ModelSPanel2.Children.Remove(ModelSSub4);
                    ModelSPanel2.Children.Remove(ModelSSub5);
                    ModelSPanel1.Children.Add(ModelSSub3);
                    ModelSPanel1.Children.Add(ModelSSub4);
                    ModelSPanel1.Children.Add(ModelSSub5);
                    ModelSSub1.FontSize = 30;
                    ModelSSub2.FontSize = 30;
                    ModelSSub3.FontSize = 30;
                    ModelSSub4.FontSize = 30;
                    ModelSSub5.FontSize = 30;
                }
                Grid.SetColumnSpan(ModelSBorder1, 2);
                ModelSBorder2.Visibility = Visibility.Hidden;
            }
            else
            {
                if (ModelSSub3.Parent == ModelSPanel1)
                {
                    ModelSPanel1.Children.Remove(ModelSSub3);
                    ModelSPanel1.Children.Remove(ModelSSub4);
                    ModelSPanel1.Children.Remove(ModelSSub5);
                    ModelSPanel2.Children.Add(ModelSSub3);
                    ModelSPanel2.Children.Add(ModelSSub4);
                    ModelSPanel2.Children.Add(ModelSSub5);
                    ModelSSub1.FontSize = 40;
                    ModelSSub2.FontSize = 40;
                    ModelSSub3.FontSize = 40;
                    ModelSSub4.FontSize = 40;
                    ModelSSub5.FontSize = 40;
                }
                Grid.SetColumnSpan(ModelSBorder1, 1);
                ModelSBorder2.Visibility = Visibility.Visible;
            }
        }
    }
}
