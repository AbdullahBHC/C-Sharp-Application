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
    /// MarkaEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class MarkaEkle : Page
    {
        Marka marka;
        public MarkaEkle(Marka Marka = null)
        {
            InitializeComponent();
            this.marka = Marka;
            if (marka != null)
            {
                TxMarka.Text = marka.MarkaAdı;
                TxKuruluşYılı.Text = marka.KuruluşYılı.ToString();
                ImgResim.Source = marka.MarkaResim;
            }
            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxKuruluşYılı.Text, out int kuruluşyılı);
            if (marka==null)
            {
                Marka m = new Marka()
                {
                    MarkaAdı = TxMarka.Text,
                    KuruluşYılı = kuruluşyılı,
                    MarkaResim = (BitmapImage)ImgResim.Source,
                };
                Veriler.Markalar.Add(m);
            }
            else
            {
                marka.MarkaAdı = TxMarka.Text;
                marka.KuruluşYılı = kuruluşyılı;
                marka.MarkaResim = (BitmapImage)ImgResim.Source;
            }
            NavigationService.Content = new MarkaListele();
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
    }
}
