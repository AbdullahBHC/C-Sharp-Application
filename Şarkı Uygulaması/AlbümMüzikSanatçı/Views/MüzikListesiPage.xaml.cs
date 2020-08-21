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
    /// MüzikListesiPage.xaml etkileşim mantığı
    /// </summary>
    public partial class MüzikListesiPage : Page
    {
        public MüzikListesiPage()
        {
            InitializeComponent();

            SanatçıListele();

            LbSanatçılar.SelectionChanged += (s, e) => LbAlbümler.ItemsSource = Veriler.Albümler.Where(a => a.Sanatçı == LbSanatçılar.SelectedItem).OrderBy(a => a.AlbümAdı);
            LbAlbümler.SelectionChanged += (s,e) => LbMüzikler.ItemsSource = Veriler.Müzikler.Where(m => m.Albüm == LbAlbümler.SelectedItem).OrderBy(m => m.ParçaNumarası);

            MiAlbümDüzenle.Click += (s, e) => NavigationService.Content = new AlbümEklePage((Albüm)LbAlbümler.SelectedItem);
            MiSanatçıDüzenle.Click += (s,e) => NavigationService.Content = new SanatçıEklePage((Sanatçı)LbSanatçılar.SelectedItem);
            MiMüzikDüzenle.Click += (s, e) => NavigationService.Content = new MüzikEklePage((Müzik)LbMüzikler.SelectedItem);

            LbSanatçılar.MouseDoubleClick += (s, e) => NavigationService.Content = new SanatçıAyrıntılarPage((Sanatçı)LbSanatçılar.SelectedItem);
            LbAlbümler.MouseDoubleClick += (s, e) => NavigationService.Content = new AlbümAyrıntılarPage((Albüm)LbAlbümler.SelectedItem);
            LbMüzikler.MouseDoubleClick += (s, e) => NavigationService.Content = new MüzikAyrıntılarPage((Müzik)LbMüzikler.SelectedItem);

            MiAlbümSil.Click += MiAlbümSil_Click;
            MiMüzikSil.Click += MiMüzikSil_Click;
            MiSanatçıSil.Click += MiSanatçıSil_Click;
        }

        private void SanatçıListele() => LbSanatçılar.ItemsSource = Veriler.Sanatçılar.OrderBy(s => s.SanatçıAdı);

        private void MiSanatçıSil_Click(object sender, RoutedEventArgs e)
        {
            Sanatçı SeçiliSanatçı = (Sanatçı)LbSanatçılar.SelectedItem;
            if (SeçiliSanatçı != null)
            {
                var cevap = MessageBox.Show("Seçili Müzik Silinsin Mi ?", "Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Sanatçılar.Remove(SeçiliSanatçı);
                    SanatçıListele();
                }
            }
        }

        private void MiMüzikSil_Click(object sender, RoutedEventArgs e)
        {
            Müzik SeçiliMüzik = (Müzik)LbMüzikler.SelectedItem;
            if (SeçiliMüzik!=null)
            {
                var cevap = MessageBox.Show("Seçili Müzik Silinsin Mi ?", "Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Müzikler.Remove(SeçiliMüzik);
                    LbMüzikler.ItemsSource = Veriler.Müzikler.Where(m=>m.Albüm==LbAlbümler.SelectedItem).OrderBy(m => m.ParçaNumarası);
                }
            }
       }

        private void MiAlbümSil_Click(object sender, RoutedEventArgs e)
        {
            Albüm SeçiliAlbüm = (Albüm)LbAlbümler.SelectedItem;
            if (SeçiliAlbüm != null)
            {
                var cevap = MessageBox.Show("Seçili Müzik Silinsin Mi ?", "Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Albümler.Remove(SeçiliAlbüm);
                    LbAlbümler.ItemsSource = Veriler.Albümler.Where(a=>a.Sanatçı==LbSanatçılar.SelectedItem).OrderBy(a => a.AlbümAdı);
                }
            }
        }
    }
}
