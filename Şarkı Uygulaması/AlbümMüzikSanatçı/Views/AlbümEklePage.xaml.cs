using AlbümMüzikSanatçı.Models;
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

namespace AlbümMüzikSanatçı.Views
{
    /// <summary>
    /// AlbümEklePage.xaml etkileşim mantığı
    /// </summary>
    public partial class AlbümEklePage : Page
    {
        Albüm Albüm;
        public AlbümEklePage(Albüm albüm =null)
        {
            InitializeComponent();
            CbSanatçı.ItemsSource = Veriler.Sanatçılar.OrderBy(s=>s.SanatçıAdı);
            this.Albüm = albüm;
            if (albüm!=null)
            {
                TxAlbümAdı.Text = albüm.AlbümAdı;
                TxYıl.Text = albüm.Yıl.ToString();
                CbSanatçı.SelectedItem = albüm.Sanatçı;
                ImgAlbüm.Source = albüm.Resim;
            }

            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;

            #region Focus Olayı

            TxAlbümAdı.GotFocus += (s, e) => TxAlbümAdı.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); TxAlbümAdı.BorderThickness = new Thickness(2);
            TxAlbümAdı.LostFocus += (s, e) => TxAlbümAdı.BorderBrush = new SolidColorBrush(Colors.Gray); TxAlbümAdı.BorderThickness = new Thickness(1);

            TxYıl.GotFocus += (s, e) => TxYıl.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); TxYıl.BorderThickness = new Thickness(2);
            TxYıl.LostFocus += (s, e) => TxYıl.BorderBrush = new SolidColorBrush(Colors.Gray); TxYıl.BorderThickness = new Thickness(1);

            CbSanatçı.GotFocus += (s, e) => CbSanatçı.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); CbSanatçı.BorderThickness = new Thickness(2);
            CbSanatçı.LostFocus += (s, e) => CbSanatçı.BorderBrush = new SolidColorBrush(Colors.Gray); CbSanatçı.BorderThickness = new Thickness(1);

            #endregion
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxYıl.Text, out int yıl);
            if (Albüm==null)
            {
                Albüm = new Albüm()
                {
                    AlbümAdı = TxAlbümAdı.Text,
                    Resim = (BitmapImage)ImgAlbüm.Source,
                    Sanatçı = (Sanatçı)CbSanatçı.SelectedItem,
                    Yıl = yıl,
                };
                Veriler.Albümler.Add(Albüm);
            }
            else
            {
                Albüm.AlbümAdı = TxAlbümAdı.Text;
                Albüm.Resim = (BitmapImage)ImgAlbüm.Source;
                Albüm.Sanatçı = (Sanatçı)CbSanatçı.SelectedItem;
                Albüm.Yıl = yıl;
            }

            var cevap = MessageBox.Show("Albümleri Listelemek İster Misin ?", "Listele - Kayıta Devam Et", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (cevap == MessageBoxResult.Yes)
            {
                NavigationService.Content = new MüzikListesiPage();
            }
            else
            {
                NavigationService.Content = new MüzikEklePage();
            }
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
                ImgAlbüm.Source = new BitmapImage(new Uri(ofd.FileName));
            }

        }
    }
}
