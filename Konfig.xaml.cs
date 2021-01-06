﻿using System;
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
using System.IO;
using System.Windows.Media.Effects;
using System.Windows.Resources;

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
        public List<int> Prices = new List<int>(5) { 46990, 0, 0, 1500, 0 };
        public Konfig()
        {
            InitializeComponent();
            Model = "Model3";
            Color = "Feher";
            Tire = "Kerek1";
            Interior = "Feher";
            CalcPrice();
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
            Prices[1] = 0;
            CalcPrice();
        }
        private void GrayUi(object sender, RoutedEventArgs e)
        {
            Color = "Metalic";
            UpdateImage("exterior");
            Prices[1] = 1000;
            CalcPrice();
        }
        private void BlackUi(object sender, RoutedEventArgs e)
        {
            Color = "Fekete";
            UpdateImage("exterior");
            Prices[1] = 1000;
            CalcPrice();
        }
        private void RedUi(object sender, RoutedEventArgs e)
        {
            Color = "Piros";
            UpdateImage("exterior");
            Prices[1] = 2000;
            CalcPrice();
        }
        private void BlueUi(object sender, RoutedEventArgs e)
        {
            Color = "Kek";
            UpdateImage("exterior");
            Prices[1] = 1000;
            CalcPrice();
        }
        private void WhiteTire(object sender, RoutedEventArgs e)
        {
            Tire = "Kerek1";
            UpdateImage("exterior");
            Prices[2] = 0;
            CalcPrice();
        }
        private void BlackTire(object sender, RoutedEventArgs e)
        {
            Tire = "Kerek2";
            UpdateImage("exterior");
            Prices[2] = 4500;
            CalcPrice();
        }
        private void WhiteInt(object sender, RoutedEventArgs e)
        {
            Interior = "Feher";
            UpdateImage("interior");
            Prices[3] = 1500;
            CalcPrice();
        }
        private void BlackInt(object sender, RoutedEventArgs e)
        {
            Interior = "Fekete";
            UpdateImage("interior");
            Prices[3] = 0;
            CalcPrice();
        }
        private void CreamInt(object sender, RoutedEventArgs e)
        {
            Interior = "Cream";
            UpdateImage("interior");
            Prices[3] = 1500;
            CalcPrice();
        }
        private void ModelS(object sender, RoutedEventArgs e)
        {
            Model = "ModelS";
            DisabledInt.Focusable = true;
            DisabledInt.IsHitTestVisible = true;
            Prices[0] = 69420;
            ResetAll();
            CalcPrice();
        }
        private void Model3(object sender, RoutedEventArgs e)
        {
            Model = "Model3";
            DisabledInt.Focusable = false;
            DisabledInt.IsHitTestVisible = false;
            Prices[0] = 46990;
            ResetAll();
            CalcPrice();
        }
        private void ModelX(object sender, RoutedEventArgs e)
        {
            Model = "ModelX";
            DisabledInt.Focusable = true;
            DisabledInt.IsHitTestVisible = true;
            Prices[0] = 79990;
            ResetAll();
            CalcPrice();
        }
        private void ModelY(object sender, RoutedEventArgs e)
        {
            Model = "ModelY";
            DisabledInt.Focusable = false;
            DisabledInt.IsHitTestVisible = false;
            Prices[0] = 49990;
            ResetAll();
            CalcPrice();
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
        private void ResetAll()
        {
            //Factory reseto
            Color = "Feher";
            Tire = "Kerek1";
            UpdateImage("exterior");
            Interior = "Feher";
            UpdateImage("interior");
            DefaultInt.IsChecked = true;
            DefaultTire.IsChecked = true;
            DefaultUi.IsChecked = true;
            LongrangeButton.IsChecked = true;
            AutopilotButton.IsChecked = false;
            Prices[1] = 0;
            Prices[2] = 0;
            Prices[3] = 1500;
            Prices[4] = 0;
        }
        private void CalcPrice()
        {
            int price = 0;
            price = Prices.Sum();
            PriceLabel1.Content = $"$ {price}";
            PriceLabel2.Content = $"$ {price}";
        }
        private void CheckoutClick(object sender, RoutedEventArgs e)
        {
            CheckoutPanel.Visibility = Visibility.Visible;
            CheckoutTitle.Content = "Autopilot Included";
            AutopilotButton.Visibility = Visibility.Visible;
            AutopilotContent.Visibility = Visibility.Visible;
            CargearBox1.Visibility = Visibility.Hidden;
            CargearBox2.Visibility = Visibility.Hidden;
            FinanceInfo1.Visibility = Visibility.Hidden;
            FinanceInfo2.Visibility = Visibility.Hidden;
            CheckoutBg.Background = Brushes.White;
            CheckoutBgImg.Background.Opacity = 0;
        }
        private void CheckoutOff(object sender, RoutedEventArgs e)
        {
            CheckoutPanel.Visibility = Visibility.Hidden;
        }

        private void Autopilot(object sender, RoutedEventArgs e)
        {
            if (AutopilotButton.IsChecked == true)
            {
                Prices[4] = 10000;
            }
            else
            {
                Prices[4] = 0;
            }
            CalcPrice();
        }

        private void Autopilot_Click(object sender, RoutedEventArgs e)
        {
            CheckoutTitle.Content = "Autopilot Included";
            AutopilotButton.Visibility = Visibility.Visible;
            AutopilotContent.Visibility = Visibility.Visible;
            CargearBox1.Visibility = Visibility.Hidden;
            CargearBox2.Visibility = Visibility.Hidden;
            FinanceInfo1.Visibility = Visibility.Hidden;
            FinanceInfo2.Visibility = Visibility.Hidden;
            CheckoutBg.Background = Brushes.White;
            CheckoutBgImg.Background.Opacity = 0;
        }
        private void Cargear_Click(object sender, RoutedEventArgs e)
        {
            CheckoutTitle.Content = "Select Your Car";
            AutopilotButton.Visibility = Visibility.Hidden;
            AutopilotContent.Visibility = Visibility.Hidden;
            CargearBox1.Visibility = Visibility.Visible;
            CargearBox2.Visibility = Visibility.Visible;
            FinanceInfo1.Visibility = Visibility.Hidden;
            FinanceInfo2.Visibility = Visibility.Hidden;
            if (Model == "ModelS")
            {
                PerformancePrice.Content = "$ 91990";
                LongrangePrice.Content = "$ 69420";
            }
            else if (Model == "Model3")
            {
                PerformancePrice.Content = "$ 54990";
                LongrangePrice.Content = "$ 46990";
            }
            else if (Model == "ModelX")
            {
                PerformancePrice.Content = "$ 99990";
                LongrangePrice.Content = "$ 79990";
            }
            else
            {
                PerformancePrice.Content = "$ 59990";
                LongrangePrice.Content = "$ 49990";
            }
            CheckoutBg.Background = Brushes.White;
            CheckoutBgImg.Background.Opacity = 0;
        }
        private void Finance_Click(object sender, RoutedEventArgs e)
        {
            CheckoutTitle.Content = "Final Price";
            AutopilotButton.Visibility = Visibility.Hidden;
            AutopilotContent.Visibility = Visibility.Hidden;
            CargearBox1.Visibility = Visibility.Hidden;
            CargearBox2.Visibility = Visibility.Hidden;
            FinanceInfo1.Visibility = Visibility.Visible;
            FinanceInfo2.Visibility = Visibility.Visible;
            CarPrice.Content = $"$ {Prices[0]}";
            ColorPrice.Content = $"$ {Prices[1]}";
            TirePrice.Content = $"$ {Prices[2]}";
            IntPrice.Content = $"$ {Prices[3]}";
            AutopilotPrice.Content = $"$ {Prices[4]}";
            FinalPrice.Content = $"$ {Prices.Sum()}";
            CheckoutBg.Background = Brushes.Black;

            Uri resourceUri;
            if (Model == "ModelS")
            {
                resourceUri = new Uri(@"images\Backgrounds\ModelS_specs_bg.png", UriKind.Relative);
            }
            else if (Model == "Model3")
            {
                resourceUri = new Uri(@"images\Backgrounds\Model3_specs_bg.png", UriKind.Relative);
            }
            else if (Model == "ModelX")
            {
                resourceUri = new Uri(@"images\Backgrounds\ModelX_specs_bg.png", UriKind.Relative);
            }
            else
            {
                resourceUri = new Uri(@"images\Backgrounds\ModelY_specs_bg.png", UriKind.Relative);
            }

            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            brush.Stretch = Stretch.Uniform;
            CheckoutBgImg.Background = brush;
            CheckoutBgImg.Background.Opacity = 1;
        }
        private void Performance_Click(object sender, RoutedEventArgs e)
        {
            if (Model == "ModelS")
            {
                Prices[0] = 91990;
            }
            else if (Model == "Model3")
            {
                Prices[0] = 54990;
            }
            else if (Model == "ModelX")
            {
                Prices[0] = 99990;
            }
            else
            {
                Prices[0] = 59990;
            }
            CalcPrice();
        }
        private void Longrange_Click(object sender, RoutedEventArgs e)
        {
            if (Model == "ModelS")
            {
                Prices[0] = 69420;
            }
            else if (Model == "Model3")
            {
                Prices[0] = 46990;
            }
            else if (Model == "ModelX")
            {
                Prices[0] = 79990;
            }
            else
            {
                Prices[0] = 49990;
            }
            CalcPrice();
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
                CarConfigS.FontSize = 25;
                CarConfig3.FontSize = 25;
                CarConfigX.FontSize = 25;
                CarConfigY.FontSize = 25;
                Checkout.FontSize = 30;
                PriceLabel2.FontSize = 30;
                CarConfig.MinHeight = 150;
                Thickness margin = ConfigGrid.Margin;
                margin.Top = -200;
                ConfigGrid.Margin = margin;
            }
            else
            {
                HomeButton.Content = "Home";
                MSButton.Content = "Model S";
                M3Button.Content = "Model 3";
                MXButton.Content = "Model X";
                MYButton.Content = "Model Y";
                CarConfigS.FontSize = 40;
                CarConfig3.FontSize = 40;
                CarConfigX.FontSize = 40;
                CarConfigY.FontSize = 40;
                Checkout.FontSize = 60;
                PriceLabel2.FontSize = 60;
                CarConfig.MinHeight = 250;
                Thickness margin = ConfigGrid.Margin;
                margin.Top = -300;
                ConfigGrid.Margin = margin;
            }
            if (ActualWidth < 800)
            {
                Grid.SetRow(CarConfig, 2);
                Grid.SetColumnSpan(CarConfig, 1);
                Thickness margin = ConfigSubGrid2.Margin;
                margin.Top = -20;
                ConfigSubGrid2.Margin = margin;
            }
            else
            {
                Thickness margin = ConfigSubGrid2.Margin;
                margin.Top = 10;
                ConfigSubGrid2.Margin = margin;
                Grid.SetRow(CarConfig, 0);
                Grid.SetColumnSpan(CarConfig, 2);
            }
            if (ActualWidth < 1100)
            {
                CarLabel.FontSize = 30;
                CarPrice.FontSize = 30;
                ColorLabel.FontSize = 30;
                ColorPrice.FontSize = 30;
                TireLabel.FontSize = 30;
                TirePrice.FontSize = 30;
                IntLabel.FontSize = 30;
                IntPrice.FontSize = 30;
                AutopilotLabel.FontSize = 30;
                AutopilotPrice.FontSize = 30;
                FinalLabel.FontSize = 30;
                FinalPrice.FontSize = 30;
                PriceLabel1.FontSize = 30;
                AutopilotButton.FontSize = 30;
                CheckoutTitle.FontSize = 40;
                CheckoutX.FontSize = 40;
                Thickness margin = CheckoutX.Margin;
                margin.Left = 40;
                CheckoutX.Margin = margin;
                CheckoutPanel.CornerRadius = new CornerRadius(0);
                AutopilotSwitch.FontSize = 25;
                CarGearSwitch.FontSize = 25;
                FinalSwitch.FontSize = 25;
                AutopilotText.FontSize = 20;
                PerformanceButton.FontSize = 30;
                PerformanceBlock.FontSize = 20;
                PerformancePrice.FontSize = 20;
                LongrangeButton.FontSize = 30;
                LongrangeBlock.FontSize = 20;
                LongrangePrice.FontSize = 20;
                AutopilotText1.FontSize = 15;
                AutopilotText2.FontSize = 15;
                AutopilotText3.FontSize = 15;
                AutopilotText4.FontSize = 15;
                AutopilotText5.FontSize = 15;
            }
            else
            {
                CarLabel.FontSize = 50;
                CarPrice.FontSize = 50;
                ColorLabel.FontSize = 50;
                ColorPrice.FontSize = 50;
                TireLabel.FontSize = 50;
                TirePrice.FontSize = 50;
                IntLabel.FontSize = 50;
                IntPrice.FontSize = 50;
                AutopilotLabel.FontSize = 50;
                AutopilotPrice.FontSize = 50;
                FinalLabel.FontSize = 60;
                FinalPrice.FontSize = 50;
                PriceLabel1.FontSize = 60;
                AutopilotButton.FontSize = 50;
                CheckoutTitle.FontSize = 70;
                CheckoutX.FontSize = 70;
                Thickness margin = CheckoutX.Margin;
                margin.Left = 200;
                CheckoutX.Margin = margin;
                CheckoutPanel.CornerRadius = new CornerRadius(100,100,0,100);
                AutopilotSwitch.FontSize = 40;
                CarGearSwitch.FontSize = 40;
                FinalSwitch.FontSize = 40;
                AutopilotText.FontSize = 35;
                PerformanceButton.FontSize = 50;
                PerformanceBlock.FontSize = 35;
                PerformancePrice.FontSize = 35;
                LongrangeButton.FontSize = 50;
                LongrangeBlock.FontSize = 35;
                LongrangePrice.FontSize = 35;
                AutopilotText1.FontSize = 30;
                AutopilotText2.FontSize = 30;
                AutopilotText3.FontSize = 30;
                AutopilotText4.FontSize = 30;
                AutopilotText5.FontSize = 30;
            }
        }
    }
}
