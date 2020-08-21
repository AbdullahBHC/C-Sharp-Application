using Galerici.Models;
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
    /// GaleriAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class GaleriAyrıntılarPage : Page
    {
        public GaleriAyrıntılarPage(Galeri galeri)
        {
            InitializeComponent();
            if (galeri!=null)
            {
                ImgGaleri.Visibility = Visibility.Visible;
                BtnGalerilereDön.Visibility = Visibility.Visible;

                Txİsim.Text = galeri.İsim;
                TxSahibi.Text = galeri.Sahibi;
                TxKonum.Text = galeri.Konum;
                TxArabaSayısı.Text = galeri.ArabaSayısı.ToString();
                TxKiralıkAraçModel.Text = galeri.KiralıkAraç_Model;
                TxKiralıkAraçFiyat.Text = galeri.KiralıkAraç_Fiyat;
                TxSatılıkAraçModel.Text = galeri.SatılıkAraç_Model;
                TxSatılıkAraçFiyat.Text = galeri.SatılıkAraç_Fiyat;
                ImgGaleri.Source = galeri.GaleriResim;
            }
            BtnGalerilereDön.MouseEnter += BtnGalerilereDön_MouseEnter;
            BtnGalerilereDön.MouseLeave += BtnGalerilereDön_MouseLeave;
            BtnGalerilereDön.Click += BtnGalerilereDön_Click;
        }

        private void BtnGalerilereDön_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnGalerilereDön.Content = "<";
            BtnGalerilereDön.Width = 20;
            BtnGalerilereDön.Height = 20;
        }

        private void BtnGalerilereDön_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnGalerilereDön.Content = "Galerilere Dön";
            BtnGalerilereDön.Width = 85;
            BtnGalerilereDön.Height = 30;
        }

        private void BtnGalerilereDön_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new GaleriListelePage();
        }
    }
}
