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
    /// UlkeleriListelePage.xaml etkileşim mantığı
    /// </summary>
    public partial class UlkeleriListelePage : Page
    {
        public UlkeleriListelePage()
        {
            InitializeComponent();
            Filtreler();
            DgUlkeler.ItemsSource = Veriler.Ulkeler;

            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;

            DgUlkeler.MouseDoubleClick += DgUlkeler_MouseDoubleClick;

            CbSırala.ItemsSource = new string[]
            {
                "Rastgele",

                "Ülke Adı (A dan Z ye)",
                "Ülke Adı (Z den A ya)",

                "Nüfusa Göre (Büyükten - Küçüğe)",
                "Nüfusa Göre (Küçükten - Büyüğe)",

                "Yüz Ölçümüne Göre (Büyükten - Küçüğe)",
                "Yüz Ölçümüne Göre (Küçükten - Büyüğe)",
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
            IEnumerable<Ulke> Ulkeler = Veriler.Ulkeler.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(TxAra.Text))
            {
                Ulkeler = Ulkeler.Where(u => u.Ad.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase) 
                || u.Nufus.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase) 
                || u.YuzOlcumu.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase));
            }

            switch (CbSırala.SelectedIndex)
            {
                case 1: Ulkeler = Ulkeler.OrderBy(u => u.Ad);
                    break;
                case 2:Ulkeler = Ulkeler.OrderByDescending(u => u.Ad);
                    break;
                case 3:Ulkeler = Ulkeler.OrderBy(u => u.Nufus);
                    break;
                case 4:Ulkeler = Ulkeler.OrderByDescending(u => u.Nufus);
                    break;
                case 5:Ulkeler = Ulkeler.OrderBy(u => u.YuzOlcumu);
                    break;
                case 6:Ulkeler = Ulkeler.OrderByDescending(u => u.YuzOlcumu);
                    break;
            }
            DgUlkeler.ItemsSource = Ulkeler;
        }

        private void DgUlkeler_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Ulke SeçiliUlke = (Ulke)DgUlkeler.SelectedItem;
            if (SeçiliUlke != null)
            {
                NavigationService.Content = new UlkeAyrıntılarPage(SeçiliUlke);
            }
        }
        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Ulke SeçiliUlke = (Ulke)DgUlkeler.SelectedItem;
            if (SeçiliUlke != null)
            {
                var cevap = MessageBox.Show("Seçili Ulke Silinsin Mi ?", "Sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Ulkeler.Remove(SeçiliUlke);
                    Filtreler();
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Ulke SeçiliUlke = (Ulke)DgUlkeler.SelectedItem;
            if (SeçiliUlke != null)
                NavigationService.Content = new UlkeDuzenlePage(SeçiliUlke);
        }
    }
}
