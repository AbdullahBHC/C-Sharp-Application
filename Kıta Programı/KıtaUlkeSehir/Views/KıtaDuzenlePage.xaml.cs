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
    /// KıtaDuzenlePage.xaml etkileşim mantığı
    /// </summary>
    public partial class KıtaDuzenlePage : Page
    {
        Kıta Kıta;
        public KıtaDuzenlePage(Kıta kıta)
        {
            InitializeComponent();
            this.Kıta = kıta;
            if (Kıta!=null)
            {
                TxAd.Text = Kıta.Ad;
                TxYuzOlcumu.Text = Kıta.YuzOlcumu;
                ImgKıtaResim.Source = Kıta.Resim;
            }
            BtnKaydet.Click += BtnKaydet_Click;
            BtnGözat.Click += BtnGözat_Click;
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
                ImgKıtaResim.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (Kıta==null)
            {
                Kıta = new Kıta()
                {
                    Ad = TxAd.Text,
                    Resim = (BitmapImage)ImgKıtaResim.Source,
                    YuzOlcumu = TxYuzOlcumu.Text,
                };
                Veriler.Kıtalar.Add(Kıta);
            }
            else
            {
               Kıta.Ad = TxAd.Text;
               Kıta.Resim = (BitmapImage)ImgKıtaResim.Source;
               Kıta.YuzOlcumu = TxYuzOlcumu.Text;
            }
            NavigationService.Content = new KıtalarıListelePage();
        }
    }
}
