using Galerici.Models;
using Microsoft.Win32;
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

namespace Galerici.Views
{
    /// <summary>
    /// GaleriKayıtPage.xaml etkileşim mantığı
    /// </summary>
    public partial class GaleriKayıtPage : Page
    {
        Galeri Galeri;
        public GaleriKayıtPage(Galeri galeri=null)
        {
            InitializeComponent();

           

            this.Galeri = galeri;
            if (galeri!=null)
            {
                Txİsim.Text = galeri.İsim;
                TxSahibi.Text = galeri.Sahibi;
                TxKonum.Text = galeri.Konum;
                TxKiralıkAraçModel.Text = galeri.KiralıkAraç_Model;
                TxKiralıkAraçFiyat.Text = galeri.KiralıkAraç_Fiyat;
                TxSatılıkAraçModel.Text = galeri.SatılıkAraç_Model;
                TxSatılıkAraçFiyat.Text = galeri.SatılıkAraç_Fiyat;
                TxArabaSayısı.Text = galeri.ArabaSayısı.ToString();
                İmgGaleri.Source = galeri.GaleriResim;
            }

            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;
            BtnTemizle.Click += BtnTemizle_Click;
        }

        private void Temizleme_Olayı() 
        {
            Txİsim.Text = null;
            TxSahibi.Text = null;
            TxKonum.Text = null;
            TxKiralıkAraçModel.Text = null;
            TxKiralıkAraçFiyat.Text = null;
            TxSatılıkAraçModel.Text = null;
            TxSatılıkAraçFiyat.Text = null;
            TxArabaSayısı.Text = null;
            İmgGaleri.Source = null;
        }

        private void BtnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizleme_Olayı();
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxArabaSayısı.Text, out int arabasayısı);

            if (string.IsNullOrWhiteSpace(Txİsim.Text) || string.IsNullOrWhiteSpace(TxSahibi.Text) || string.IsNullOrWhiteSpace(TxKonum.Text) || string.IsNullOrWhiteSpace(TxArabaSayısı.Text) || string.IsNullOrWhiteSpace(TxKiralıkAraçModel.Text) || string.IsNullOrWhiteSpace(TxKiralıkAraçFiyat.Text) || string.IsNullOrWhiteSpace(TxSatılıkAraçModel.Text) || string.IsNullOrWhiteSpace(TxSatılıkAraçFiyat.Text) || İmgGaleri.Source==null)
            {
                MessageBox.Show("Eksik Veya Hatalı Tuşlama Yaptınız ...", " Hata !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Galeri == null)
                {
                    Galeri = new Galeri()
                    {
                        İsim = Txİsim.Text,
                        Sahibi = TxSahibi.Text,
                        Konum = TxKonum.Text,
                        GaleriResim = (BitmapImage)İmgGaleri.Source,
                        ArabaSayısı = arabasayısı,
                        KiralıkAraç_Model = TxKiralıkAraçModel.Text,
                        KiralıkAraç_Fiyat = TxKiralıkAraçFiyat.Text,
                        SatılıkAraç_Model = TxSatılıkAraçModel.Text,
                        SatılıkAraç_Fiyat = TxSatılıkAraçFiyat.Text,
                    };
                    Veriler.Galeriler.Add(Galeri);
                }
                else
                {
                    Galeri.İsim = Txİsim.Text;
                    Galeri.Sahibi = TxSahibi.Text;
                    Galeri.Konum = TxKonum.Text;
                    Galeri.GaleriResim = (BitmapImage)İmgGaleri.Source;
                    Galeri.ArabaSayısı = arabasayısı;
                    Galeri.KiralıkAraç_Model = TxKiralıkAraçModel.Text;
                    Galeri.KiralıkAraç_Fiyat = TxKiralıkAraçFiyat.Text;
                    Galeri.SatılıkAraç_Model = TxSatılıkAraçModel.Text;
                    Galeri.SatılıkAraç_Fiyat = TxSatılıkAraçFiyat.Text;
                }
                NavigationService.Content = new GaleriListelePage();
            }
        }

        private void BtnGözat_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Resim Dosyaları|*-jpg; *.png",
                Title = "Resim Seç",
            };

            if (ofd.ShowDialog() == true)
            {
                SpGaleriResim.Visibility = Visibility.Visible;
                İmgGaleri.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
