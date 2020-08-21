using Galerici.Views;
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
using System.Windows.Threading;

namespace Galerici
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //1300 SATIR KOD.

            InitializeComponent();
            Frm.Content = new GaleriListelePage();
            RbGaleriListele.Click += (s, e) => Frm.Content = new GaleriListelePage();
            RbGaleriEkle.Click += (s, e) => Frm.Content = new GaleriKayıtPage();
            RbArabaEkle.Click += (s, e) => Frm.Content = new ArabaKayıtPage();

            BtnKapat.Background = new SolidColorBrush(Colors.White);

            BtnKapat.Click += BtnKapat_Click;

            BtnKapat.GotFocus += (s, e) => BtnKapat.Background = new SolidColorBrush(Colors.Red);
            BtnKapat.MouseEnter += (s, e) => BtnKapat.Background = new SolidColorBrush(Colors.Red);
            BtnKapat.MouseLeave += (s, e) => BtnKapat.Background = new SolidColorBrush(Colors.Transparent);

            BtnBeyazArkaPlan.Click += BtnBeyazArkaPlan_Click;
            BtnKırmızıArkaPlan.Click += BtnKırmızıArkaPlan_Click;
            BtnSiyahArkaPlan.Click += BtnSiyahArkaPlan_Click;

            Frm.Navigated += Frm_Navigated;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void BtnKırmızıArkaPlan_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
            LblTarih.Foreground = new SolidColorBrush(Colors.Black);
            LblSaat.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void BtnBeyazArkaPlan_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.White);
            LblTarih.Foreground = new SolidColorBrush(Colors.Black);
            LblSaat.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void BtnSiyahArkaPlan_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Black);
            LblTarih.Foreground = new SolidColorBrush(Colors.White);
            LblSaat.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblSaat.Content = "-" + " " +  DateTime.Now.ToLongTimeString();
            LblTarih.Content = DateTime.Now.ToLongDateString();
        }

        private void BtnKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void Frm_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is GaleriListelePage)
                RbGaleriListele.IsChecked = true;

            else if (e.Content is GaleriKayıtPage)
                RbGaleriEkle.IsChecked = true;

            else if (e.Content is ArabaKayıtPage)
                RbArabaEkle.IsChecked = true;
        }
    }
}
