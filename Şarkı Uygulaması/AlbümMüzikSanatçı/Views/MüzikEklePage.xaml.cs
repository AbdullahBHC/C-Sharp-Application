using AlbümMüzikSanatçı.Models;
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
    /// MüzikEklePage.xaml etkileşim mantığı
    /// </summary>
    public partial class MüzikEklePage : Page
    {
        Müzik Müzik;
        public MüzikEklePage(Müzik müzik=null)
        {
            InitializeComponent();
            CbAlbüm.ItemsSource = Veriler.Albümler;
            this.Müzik = müzik;
            if (müzik!=null)
            {
                TxMüzikAdı.Text = müzik.MüzikAdı;
                TxParçaNumarası.Text = müzik.ParçaNumarası.ToString();
                TxUzunluk.Text = müzik.Uzunluk.ToString();
                CbAlbüm.SelectedItem = müzik.Albüm;
            }

            BtnKaydet.Click += BtnKaydet_Click;

            #region Focus Olayı

            CbAlbüm.GotFocus += (s, e) => CbAlbüm.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); CbAlbüm.BorderThickness = new Thickness(2);
            CbAlbüm.LostFocus += (s, e) => CbAlbüm.BorderBrush = new SolidColorBrush(Colors.Gray); CbAlbüm.BorderThickness = new Thickness(1);

            TxParçaNumarası.GotFocus += (s, e) => TxParçaNumarası.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); TxParçaNumarası.BorderThickness = new Thickness(2);
            TxParçaNumarası.LostFocus += (s, e) => TxParçaNumarası.BorderBrush = new SolidColorBrush(Colors.Gray); TxParçaNumarası.BorderThickness = new Thickness(1);

            TxUzunluk.GotFocus += (s, e) => TxUzunluk.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); TxUzunluk.BorderThickness = new Thickness(2);
            TxUzunluk.LostFocus += (s, e) => TxUzunluk.BorderBrush = new SolidColorBrush(Colors.Gray); TxUzunluk.BorderThickness = new Thickness(1);

            TxMüzikAdı.GotFocus += (s, e) => TxMüzikAdı.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); TxMüzikAdı.BorderThickness = new Thickness(2);
            TxMüzikAdı.LostFocus += (s, e) => TxMüzikAdı.BorderBrush = new SolidColorBrush(Colors.Gray); TxMüzikAdı.BorderThickness = new Thickness(1);

            #endregion
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxParçaNumarası.Text, out int parçanumarası);
            int.TryParse(TxUzunluk.Text, out int uzunluk);
            if (Müzik==null)
            {
                Müzik = new Müzik()
                {
                    Albüm = (Albüm)CbAlbüm.SelectedItem,
                    MüzikAdı = TxMüzikAdı.Text,
                    ParçaNumarası = parçanumarası,
                    Uzunluk = uzunluk,
                };
                Veriler.Müzikler.Add(Müzik);
            }
            else
            {
                Müzik.Albüm = (Albüm)CbAlbüm.SelectedItem;
                Müzik.MüzikAdı = TxMüzikAdı.Text;
                Müzik.ParçaNumarası = parçanumarası;
                Müzik.Uzunluk = uzunluk;
            }
            NavigationService.Content = new MüzikListesiPage();
        }
    }
}
