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
    /// ArabaAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class ArabaAyrıntılarPage : Page
    {
        public ArabaAyrıntılarPage(Araba araba=null)
        {
            InitializeComponent();
            BtnAraçlaraDön.Click += BtnAraçlaraDön_Click;
            BtnAraçlaraDön.MouseEnter += BtnAraçlaraDön_MouseEnter;
            BtnAraçlaraDön.MouseLeave += BtnAraçlaraDön_MouseLeave;

            if (araba!=null)
            {
                ImgAraba.Visibility = Visibility.Visible;
                BtnAraçlaraDön.Visibility = Visibility.Visible;

                TxAraçDurumu.Text = araba.Durum.ToString();
                TxFiyat.Text = araba.Fiyat.ToString("#,### ₺");
                TxGaleri.Text = araba.Galeri.ToString();
                TxKasaTipi.Text = araba.Kasa.ToString();
                TxKM.Text = araba.Km.ToString();
                TxMarka.Text = araba.Marka.ToString();
                TxModel.Text = araba.Model;
                TxMotorGücü.Text = araba.MotorGücü;
                TxRenk.Text = araba.Renk;
                TxVitesTürü.Text = araba.Vites.ToString();
                TxYakıtTürü.Text = araba.Yakıt.ToString();
                TxÇekişTürü.Text = araba.Çekiş.ToString();
                TxÇıkışYılı.Text = araba.ÇıkışYılı.ToString();
                ImgAraba.Source = araba.Resim;
            }
        }

        private void BtnAraçlaraDön_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnAraçlaraDön.Content = "+";
            BtnAraçlaraDön.Width = 20;
            BtnAraçlaraDön.Height = 20;
        }

        private void BtnAraçlaraDön_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnAraçlaraDön.Content = "Araçlara Dön";
            BtnAraçlaraDön.Width = 85;
            BtnAraçlaraDön.Height = 30;
        }

        private void BtnAraçlaraDön_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
