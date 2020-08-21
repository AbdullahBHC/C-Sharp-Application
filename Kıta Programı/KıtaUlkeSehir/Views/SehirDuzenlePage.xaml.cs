using KıtaUlkeSehir.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KıtaUlkeSehir.Views
{
    /// <summary>
    /// SehirDuzenlePage.xaml etkileşim mantığı
    /// </summary>
    public partial class SehirDuzenlePage : Page
    {
        Sehir Sehir;
        public SehirDuzenlePage(Sehir sehir =null)
        {
            InitializeComponent();
            CbUlke.ItemsSource = Veriler.Ulkeler;
            this.Sehir = sehir;
            if (sehir!=null)
            {
                TxAd.Text = sehir.Ad;
                TxNufus.Text = sehir.Nufus;
                TxYuzOlcumu.Text = sehir.YuzOlcumu;
                CbUlke.SelectedItem = sehir.Ulke;
                TxTelefonKodu.Text = sehir.TelefonKodu.ToString();
            }

            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxTelefonKodu.Text, out int Telkod);
            if (Sehir==null)
            {
                Sehir = new Sehir()
                {
                    Ad = TxAd.Text,
                    Nufus = TxNufus.Text,
                    TelefonKodu = Telkod,
                    Ulke = (Ulke)CbUlke.SelectedItem,
                    YuzOlcumu = TxYuzOlcumu.Text,
                };
                Veriler.Sehirler.Add(Sehir);
            }
            else
            {
                    Sehir.Ad = TxAd.Text;
                    Sehir.Nufus = TxNufus.Text;
                    Sehir.TelefonKodu = Telkod;
                    Sehir.Ulke = (Ulke)CbUlke.SelectedItem;
                    Sehir.YuzOlcumu = TxYuzOlcumu.Text;
            }
            NavigationService.Content = new SehirleriListelePage();
        }
    }
}
