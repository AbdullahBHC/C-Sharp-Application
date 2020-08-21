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
using telefonsatısdeneme.Views;

namespace telefonsatısdeneme.Models
{
    /// <summary>
    /// İşletimSistemiEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class İşletimSistemiEkle : Page
    {
        İşletimSistemi iş;
        public İşletimSistemiEkle(İşletimSistemi IS =null)
        {
            InitializeComponent();
            this.iş = IS;
            if (IS!=null)
            {
                TxİşletimSistemi.Text = IS.İşletimSistemii;
                ImgResim.Source = IS.İşletimSistemiResim;
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
            if (ofd.ShowDialog() == true)
            {
                ImgResim.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (iş==null)
            {
                İşletimSistemi işl = new İşletimSistemi()
                {
                    İşletimSistemii = TxİşletimSistemi.Text,
                    İşletimSistemiResim = (BitmapImage)ImgResim.Source,
                };
                Veriler.İşletimSistemleri.Add(işl);
            }
            else
            {
                    iş.İşletimSistemii = TxİşletimSistemi.Text;
                    iş.İşletimSistemiResim = (BitmapImage)ImgResim.Source;
            }
            NavigationService.Content = new İşletimSistemiListele();
        }
    }
}
