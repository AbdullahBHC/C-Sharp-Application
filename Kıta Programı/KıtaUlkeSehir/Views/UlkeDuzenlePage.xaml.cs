using KıtaUlkeSehir.Models;
using Microsoft.Win32;
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
    /// UlkeDuzenlePage.xaml etkileşim mantığı
    /// </summary>
    public partial class UlkeDuzenlePage : Page
    {
        Ulke Ulke;
        public UlkeDuzenlePage(Ulke ulke=null)
        {
            InitializeComponent();
            CbKıta.ItemsSource = Veriler.Kıtalar;
            this.Ulke = ulke;
            if (ulke!=null)
            {
                TxAd.Text = ulke.Ad;
                TxNufus.Text = ulke.Nufus;
                TxSehirler.Text = ulke.Sehirler;
                TxTelefonKodu.Text = ulke.TelefonKodu.ToString();
                TxUlkeKodu.Text = ulke.UlkeKodu.ToString();
                CbKıta.SelectedItem = ulke.Kıta;
                TxYuzOlcumu.Text = ulke.YuzOlcumu;
                ImgUlkeBayrak.Source = ulke.Bayrak;
            }

            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxUlkeKodu.Text, out int UlkeKodu);
            int.TryParse(TxTelefonKodu.Text, out int TelefonKodu);

            if (Ulke==null)
            {
                Ulke = new Ulke()
                {
                    Ad = TxAd.Text,
                    Bayrak = (BitmapImage)ImgUlkeBayrak.Source,
                    Kıta = (Kıta)CbKıta.SelectedItem,
                    Nufus = TxNufus.Text,
                    Sehirler = TxSehirler.Text,
                    YuzOlcumu = TxYuzOlcumu.Text,
                    TelefonKodu = TelefonKodu,
                    UlkeKodu = UlkeKodu,
                };
                Veriler.Ulkeler.Add(Ulke);
            }
            else
            {
                   Ulke.Ad = TxAd.Text;
                   Ulke.Bayrak = (BitmapImage)ImgUlkeBayrak.Source;
                   Ulke.Kıta = (Kıta)CbKıta.SelectedItem;
                   Ulke.Nufus = TxNufus.Text;
                   Ulke.Sehirler = TxSehirler.Text;
                   Ulke.YuzOlcumu = TxYuzOlcumu.Text;
                   Ulke.TelefonKodu = TelefonKodu;
                   Ulke.UlkeKodu = UlkeKodu;
            }
            NavigationService.Content = new UlkeleriListelePage();
        }

        private void BtnGözat_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Resim Dosyaları|*-jpg;*.png",
                Title = "Resim Seç",
            };
            if (ofd.ShowDialog()==true)
            {
                ImgUlkeBayrak.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
