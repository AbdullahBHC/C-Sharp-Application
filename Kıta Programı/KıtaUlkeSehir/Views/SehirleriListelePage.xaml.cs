using KıtaUlkeSehir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// SehirleriListelePage.xaml etkileşim mantığı
    /// </summary>
    public partial class SehirleriListelePage : Page
    {
        public SehirleriListelePage()
        {
            InitializeComponent();
           
            DgSehirler.ItemsSource = Veriler.Sehirler;
            Filtreler();

            MiSil.Click += MiSil_Click;
            MiDüzenle.Click += MiDüzenle_Click;

            DgSehirler.MouseDoubleClick += DgSehirler_MouseDoubleClick;

            CbSırala.ItemsSource = new string[]
            {
                "Rastgele",

                "Şehir Adı (A dan Z ye)",
                "Şehir Adı (Z den A ya)",

                "Ülke Adı (A dan Z ye)",
                "Ülke Adı (Z den A ya)",

                "Yüz Ölçümüe (Büyükten - Küçüğe)",
                "Yüz Ölçümü (Küçükten - Büyüğe)",

                "Nüfus (Büyükten - Küçüğe)",
                "Nüfus (Küçükten - Büyüğe)",

                "Telefon Kodu (Büyükten - Küçüğe)",
                "Telefon Kodu (Küçükten - Büyüğe)",

            };

            CbSırala.SelectedIndex = 0;
            CbSırala.SelectionChanged += CbSırala_SelectionChanged;
            TxAra.TextChanged += TxAra_TextChanged;
        }

        private void TxAra_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtreler();
        }

        private void CbSırala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtreler();
        }

        private void Filtreler()
        {
            IEnumerable<Sehir> Sehirler = Veriler.Sehirler.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(TxAra.Text))
            {
               Sehirler = Sehirler.Where(s => s.Ad.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase) 
                || s.Ulke.Ad.StartsWith(TxAra.Text,StringComparison.CurrentCultureIgnoreCase));
            }

            switch (CbSırala.SelectedIndex)
            {
                case 1:Sehirler = Sehirler.OrderBy(s => s.Ad);
                    break;

                case 2: Sehirler = Sehirler.OrderByDescending(s => s.Ad);
                    break;

                case 3: Sehirler = Sehirler.OrderBy(s => s.Ulke.Ad);
                    break;

                case 4:Sehirler = Sehirler.OrderByDescending(s => s.Ulke.Ad);
                    break;

                case 5:Sehirler = Sehirler.OrderBy(s => s.YuzOlcumu);
                    break;

                case 6: Sehirler = Sehirler.OrderByDescending(s => s.YuzOlcumu); 
                    break;

                case 7:Sehirler = Sehirler.OrderBy(s => s.Nufus);
                    break;

                case 8: Sehirler = Sehirler.OrderByDescending(s => s.Nufus); 
                    break;

                case 9:Sehirler = Sehirler.OrderByDescending(s => s.TelefonKodu);
                    break;

                case 10: Sehirler = Sehirler.OrderBy(s => s.TelefonKodu); 
                    break;
            }

            DgSehirler.ItemsSource = Sehirler;
        }

        private void DgSehirler_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Sehir SeçiliŞehir = (Sehir)DgSehirler.SelectedItem;
            if (SeçiliŞehir != null)
            {
                NavigationService.Content = new SehirAyrıntılarPage(SeçiliŞehir);
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Sehir SeçiliŞehir = (Sehir)DgSehirler.SelectedItem;
            if (SeçiliŞehir != null)
                NavigationService.Content = new SehirDuzenlePage(SeçiliŞehir);
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Sehir SeçiliŞehir = (Sehir)DgSehirler.SelectedItem;
            if (SeçiliŞehir!=null)
            {
                var cevap = MessageBox.Show("Seçili Şehir Silinsin Mi ?", "Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap==MessageBoxResult.Yes)
                {
                    Veriler.Sehirler.Remove(SeçiliŞehir);
                    Filtreler();
                }
            }
        }
    }
}
