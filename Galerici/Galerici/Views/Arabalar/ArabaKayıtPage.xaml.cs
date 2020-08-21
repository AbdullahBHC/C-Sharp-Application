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
    /// ArabaKayıtPage.xaml etkileşim mantığı
    /// </summary>
    public partial class ArabaKayıtPage : Page
    {
        Araba Araba;
        public ArabaKayıtPage(Araba araba=null)
        {
            InitializeComponent();

            CbDurum.ItemsSource = Veriler.ArabaDurumları;
            CbGaleri.ItemsSource = Veriler.Galeriler;
            CbKasaTipi.ItemsSource = Veriler.KasaTipleri;
            CbMarka.ItemsSource = Veriler.Markalar;
            CbVites.ItemsSource = Veriler.VitesTürleri;
            CbYakıt.ItemsSource = Veriler.YakıtTürleri;
            CbÇekiş.ItemsSource = Veriler.ÇekişTürleri;

            this.Araba = araba;

            if (araba!=null)
            {
                TxFiyat.Text = araba.Fiyat.ToString();
                TxKM.Text = araba.Km.ToString();
                TxModel.Text = araba.Model;
                TxMotorGücü.Text = araba.MotorGücü;
                TxRenk.Text = araba.Renk;
                TxÇıkışYılı.Text = araba.ÇıkışYılı.ToString();
                CbGaleri.SelectedItem = araba.Galeri;
                CbKasaTipi.SelectedItem = araba.Kasa;
                CbMarka.SelectedItem = araba.Marka;
                CbVites.SelectedItem = araba.Vites;
                CbYakıt.SelectedItem = araba.Yakıt;
                CbÇekiş.SelectedItem = araba.Çekiş;
                CbDurum.SelectedItem = araba.Durum;
                CbKasaTipi.SelectedItem = araba.Kasa;
            }

            BtnKaydet.Click += BtnKaydet_Click;
            BtnGözat.Click += BtnGözat_Click;
            BtnTemizle.Click += BtnTemizle_Click;
        }

        private void Temizleme_Olayı() 
        {
            TxFiyat.Clear();
            TxKM.Clear();
            TxModel.Clear();
            TxMotorGücü.Clear();
            TxRenk.Clear();
            TxÇıkışYılı.Clear();
            CbDurum.SelectedItem = null;
            CbGaleri.SelectedItem = null;
            CbKasaTipi.SelectedItem = null;
            CbMarka.SelectedItem = null;
            CbVites.SelectedItem = null;
            CbYakıt.SelectedItem = null;
            CbÇekiş.SelectedItem = null;
        }

        private void BtnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizleme_Olayı();
        }

        private void BtnGözat_Click(object sender, RoutedEventArgs e)
        {
            ImgAraba.Visibility = Visibility.Visible;

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları|*-jpg ; *.png",
            };
            if (ofd.ShowDialog() == true)
            {
                ImgAraba.Source = new BitmapImage(new Uri(ofd.FileName));
            }           
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(TxFiyat.Text, out decimal fiyat);
            int.TryParse(TxKM.Text, out int km);
            int.TryParse(TxÇıkışYılı.Text, out int çıkışyılı);

            if (string.IsNullOrWhiteSpace(TxModel.Text) || string.IsNullOrWhiteSpace(TxFiyat.Text) || string.IsNullOrWhiteSpace(TxKM.Text) || string.IsNullOrWhiteSpace(TxMotorGücü.Text) || string.IsNullOrWhiteSpace(TxRenk.Text) || string.IsNullOrWhiteSpace(TxÇıkışYılı.Text))
            {
                if (CbDurum.SelectedIndex==-1 || CbGaleri.SelectedIndex==-1 || CbKasaTipi.SelectedIndex==-1 || CbMarka.SelectedIndex==-1 || CbVites.SelectedIndex==-1 || CbYakıt.SelectedIndex==-1 || CbÇekiş.SelectedIndex ==-1 || ImgAraba.Source==null)
                {
                    MessageBox.Show("Eksik Veya Hatalı Tuşlama Yaptınız.", " Hata !", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                if (Araba == null)
                {
                    Araba = new Araba()
                    {
                        Marka = (Marka)CbMarka.SelectedItem,
                        Model = TxModel.Text,
                        Fiyat = fiyat,
                        Galeri = (Galeri)CbGaleri.SelectedItem,
                        Kasa = (Kasa)CbKasaTipi.SelectedItem,
                        Km = km,
                        MotorGücü = TxMotorGücü.Text,
                        Renk = TxRenk.Text,
                        Resim = (BitmapImage)ImgAraba.Source,
                        Vites = (Vites)CbVites.SelectedItem,
                        Yakıt = (Yakıt)CbYakıt.SelectedItem,
                        Çekiş = (Çekiş)CbÇekiş.SelectedItem,
                        Durum = (Durum)CbDurum.SelectedItem,
                        ÇıkışYılı = çıkışyılı,
                    };
                    Veriler.Arabalar.Add(Araba);
                }
                else
                {
                    Araba.Marka = (Marka)CbMarka.SelectedItem;
                    Araba.Model = TxModel.Text;
                    Araba.Fiyat = fiyat;
                    Araba.Galeri = (Galeri)CbGaleri.SelectedItem;
                    Araba.Kasa = (Kasa)CbKasaTipi.SelectedItem;
                    Araba.Km = km;
                    Araba.MotorGücü = TxMotorGücü.Text;
                    Araba.Renk = TxRenk.Text;
                    Araba.Resim = (BitmapImage)ImgAraba.Source;
                    Araba.Vites = (Vites)CbVites.SelectedItem;
                    Araba.Yakıt = (Yakıt)CbYakıt.SelectedItem;
                    Araba.Çekiş = (Çekiş)CbÇekiş.SelectedItem;
                    Araba.ÇıkışYılı = çıkışyılı;
                }
                NavigationService.Content = new GaleriListelePage();
            }
        }
    }
}
