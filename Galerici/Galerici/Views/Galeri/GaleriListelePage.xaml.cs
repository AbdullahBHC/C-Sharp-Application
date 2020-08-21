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
    /// GaleriListelePage.xaml etkileşim mantığı
    /// </summary>
    public partial class GaleriListelePage : Page
    {
        public GaleriListelePage()
        {
            InitializeComponent();

            CbArabaSırala.ItemsSource = new string[] 
            {
                "Tüm Arabalar",
                "Marka A > Z",
                "Marka Z > A",
                "Model A > Z",
                "Model Z > A",
                "Fiyat En Yüksek > En Düşük",
                "Fiyat En Düşük > En Yüksek",
                "Motor Gücü En Yüksek > En Düşük",
                "Motor Gücü En Düşük > En Yüksek",
                "KM En Yüksek > En Düşük",
                "KM En Düşük > En Yüksek",
                "Çıkış Yılı Yeniden > Eskiye",
                "Çıkış Yılı Eskiden > Yeniye",
            };

            CbGaleriSırala.ItemsSource = new string[] 
            {
                "Tüm Galeriler",
                "Galeri İsmi A > Z",
                "Galeri İsmi Z > A",
                "Galeri Sahibi A > Z",
                "Galeri Sahibi Z > A",
                "Araba Sayısı En Yüksek > En Düşük",
                "Araba Sayısı En Düşük > En Yüksek",
                "Konum A > Z",
                "Konum Z > A",
                "Kiralık Araç Model A > Z",
                "Kiralık Araç Model Z > A",
                "Kiralık Araç Fiyat En Yüksek > En Düşük",
                "Kiralık Araç Fiyat En Düşük > En Yüksek",
                "Satılık Araç Model A > Z",
                "Satılık Araç Model Z > A",
                "Satılık Araç Fiyat En Yüksek > En Düşük",
                "Satılık Araç Fiyat En Yüksek > En Düşük",
            };

            CbArabaSırala.SelectedIndex = 0;
            CbGaleriSırala.SelectedIndex = 0;

            CbArabaSırala.SelectionChanged += (s, e) => ArabaFiltrele();
            CbGaleriSırala.SelectionChanged += (s, e) => GaleriFiltrele();

            TxArabaAra.TextChanged += (s, e) => ArabaFiltrele();
            TxGaleriAra.TextChanged += (s, e) => GaleriFiltrele();

            LbGaleriler.ItemsSource = Veriler.Galeriler;

            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;

            MiDüzenleAraba.Click += MiDüzenleAraba_Click;
            MiSilAraba.Click += MiSilAraba_Click;

            BtnGalerilereDön.Click += BtnGalerilereDön_Click;
            BtnGalerilereDön.MouseEnter += BtnGalerilereDön_MouseEnter;
            BtnGalerilereDön.MouseLeave += BtnGalerilereDön_MouseLeave;

            LbAraçlar.MouseDoubleClick += LbAraçlar_MouseDoubleClick;
            LbGaleriler.SelectionChanged += LbGaleriler_SelectionChanged;
            LbGaleriler.MouseDoubleClick += LbGaleriler_MouseDoubleClick;
        }

        private void ArabaFiltrele()
        {
            IEnumerable<Araba> Arabalar = Veriler.Arabalar.Where(a => a.Galeri == LbGaleriler.SelectedItem).AsEnumerable();
            
            if (string.IsNullOrWhiteSpace(TxArabaAra.Text)==false)
            {
                Arabalar = Arabalar.Where
                (a => a.Marka.MarkaAdı.StartsWith(TxArabaAra.Text, StringComparison.CurrentCultureIgnoreCase)
                  || a.Model.StartsWith(TxArabaAra.Text, StringComparison.CurrentCultureIgnoreCase));
            }
            
            switch (CbArabaSırala.SelectedIndex)
            {
                case 1: Arabalar = Arabalar.OrderBy(a => a.Marka.MarkaAdı);
                    break;

                case 2: Arabalar = Arabalar.OrderByDescending(a=>a.Marka.MarkaAdı);
                    break;

                case 3: Arabalar = Arabalar.OrderBy(a => a.Model);
                    break;

                case 4: Arabalar = Arabalar.OrderByDescending(a => a.Model);
                    break;

                case 5:Arabalar = Arabalar.OrderByDescending(a => a.Fiyat);
                    break;

                case 6:Arabalar = Arabalar.OrderBy(a => a.Fiyat);
                    break;

                case 7:Arabalar = Arabalar.OrderByDescending(a => a.MotorGücü);
                    break;

                case 8:Arabalar = Arabalar.OrderBy(a => a.MotorGücü);
                    break;

                case 9:Arabalar = Arabalar.OrderByDescending(a => a.Km);
                    break;

                case 10:Arabalar = Arabalar.OrderBy(a => a.Km);
                    break;

                case 11:Arabalar = Arabalar.OrderByDescending(a => a.ÇıkışYılı);
                    break;

                case 12:Arabalar = Arabalar.OrderBy(a => a.ÇıkışYılı);
                    break;
            }
            LbAraçlar.ItemsSource = Arabalar;
        }

        private void GaleriFiltrele()
        {
            IEnumerable<Galeri> Galeriler = Veriler.Galeriler.AsEnumerable();

            if (string.IsNullOrWhiteSpace(TxGaleriAra.Text)==false)
            {
                Galeriler = Galeriler.Where
                (g => g.İsim.StartsWith(TxGaleriAra.Text, StringComparison.CurrentCultureIgnoreCase) 
                || g.Sahibi.StartsWith(TxGaleriAra.Text, StringComparison.CurrentCultureIgnoreCase));
            }

            switch (CbGaleriSırala.SelectedIndex)
            {
                case 1: Galeriler = Galeriler.OrderBy(g => g.İsim);
                    break;

                case 2:Galeriler = Galeriler.OrderByDescending(g => g.İsim);
                    break;

                case 3: Galeriler = Galeriler.OrderBy(g => g.Sahibi);
                    break;
                    
                case 4: Galeriler = Galeriler.OrderByDescending(g => g.Sahibi);
                    break;

                case 5: Galeriler = Galeriler.OrderBy(g => g.ArabaSayısı);
                    break;

                case 6:Galeriler = Galeriler.OrderByDescending(g => g.ArabaSayısı);
                    break;

                case 7:
                    Galeriler = Galeriler.OrderBy(g => g.Konum);
                    break;

                case 8:
                    Galeriler = Galeriler.OrderByDescending(g => g.Konum);
                    break;

                case 9:
                    Galeriler = Galeriler.OrderBy(g => g.KiralıkAraç_Model);
                    break;

                case 10:
                    Galeriler = Galeriler.OrderByDescending(g => g.KiralıkAraç_Model);
                    break;

                case 11:
                    Galeriler = Galeriler.OrderBy(g => g.KiralıkAraç_Fiyat);
                    break;

                case 12:
                    Galeriler = Galeriler.OrderByDescending(g => g.KiralıkAraç_Fiyat);
                    break;

                case 13:
                    Galeriler = Galeriler.OrderBy(g => g.SatılıkAraç_Model);
                    break;

                case 14:
                    Galeriler = Galeriler.OrderByDescending(g => g.SatılıkAraç_Model);
                    break;

                case 15:
                    Galeriler = Galeriler.OrderBy(g => g.SatılıkAraç_Fiyat);
                    break;

                case 16:
                    Galeriler = Galeriler.OrderByDescending(g => g.SatılıkAraç_Fiyat);
                    break;
            }
            LbGaleriler.ItemsSource = Galeriler;
        }

        private void LbGaleriler_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Galeri SeçiliGaleri = (Galeri)LbGaleriler.SelectedItem;
            if (SeçiliGaleri!=null)
            {
                NavigationService.Content = new GaleriAyrıntılarPage(SeçiliGaleri);
            }
        }

        private void LbGaleriler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LbAraçlar.ItemsSource = Veriler.Arabalar.Where(a => a.Galeri == LbGaleriler.SelectedItem);
        }

        private void LbAraçlar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Araba SeçiliAraba = (Araba)LbAraçlar.SelectedItem;
            if (SeçiliAraba!=null)
            {
                NavigationService.Content = new ArabaAyrıntılarPage(SeçiliAraba);
            }
        }

        private void BtnGalerilereDön_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnGalerilereDön.Content = "+";
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

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Galeri SeçiliGaleri = (Galeri)LbGaleriler.SelectedItem;
            if (SeçiliGaleri!=null)
            {
                var cevap = MessageBox.Show("Seçili Galeri Silinsin Mi ?", "Galeri Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap ==MessageBoxResult.Yes)
                {
                    Veriler.Galeriler.Remove(SeçiliGaleri);
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Galeri SeçiliGaleri = (Galeri)LbGaleriler.SelectedItem;
            if (SeçiliGaleri != null)
            {
                NavigationService.Content = new GaleriKayıtPage(SeçiliGaleri);
            }
        }

        private void MiSilAraba_Click(object sender, RoutedEventArgs e)
        {
            Araba SeçiliAraba = (Araba)LbAraçlar.SelectedItem;
            if (SeçiliAraba != null)
            {
                var cevap = MessageBox.Show("Seçili Araba Silinsin Mi ? ", "Araba Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Arabalar.Remove(SeçiliAraba);
                }
            }
            LbAraçlar.Items.Refresh();
            LbAraçlar.ItemsSource = Veriler.Arabalar.Where(p=>p.Galeri ==LbGaleriler.SelectedItem);
        }

        private void MiDüzenleAraba_Click(object sender, RoutedEventArgs e)
        {
            Araba SeçiliAraba = (Araba)LbAraçlar.SelectedItem;
            if (SeçiliAraba != null)
            {
                NavigationService.Content = new ArabaKayıtPage(SeçiliAraba);
            }
        }
    }
}
