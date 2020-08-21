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
    /// KıtalarıListelePage.xaml etkileşim mantığı
    /// </summary>
    public partial class KıtalarıListelePage : Page
    {
        public KıtalarıListelePage()
        {
            InitializeComponent();
            DgKıtalar.ItemsSource = Veriler.Kıtalar;
            Filtreler();
            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;

            DgKıtalar.MouseDoubleClick += DgKıtalar_MouseDoubleClick;

            CbSırala.ItemsSource = new string[]
            {
                "Rastgele",

                "Kıta Adı (A dan Z ye) ",
                "Kıta Adı (Z den A ya) ",

                "Yüz Ölçümü (Büyükten - Küçüğe)",
                "Yüz Ölçümü (Küçükten - Büyüğe)",
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
            IEnumerable<Kıta> Kıtalar = Veriler.Kıtalar.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(TxAra.Text))
            {
                Kıtalar = Kıtalar.Where(k => k.Ad.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase) 
                ||k.YuzOlcumu.StartsWith(TxAra.Text,StringComparison.CurrentCultureIgnoreCase));
            }

            switch (CbSırala.SelectedIndex)
            {
                case 1: Kıtalar = Kıtalar.OrderBy(k => k.Ad);
                    break;

                case 2: Kıtalar = Kıtalar.OrderByDescending(k => k.Ad);
                    break;

                case 3: Kıtalar = Kıtalar.OrderByDescending(k => k.YuzOlcumu);
                    break;

                case 4: Kıtalar = Kıtalar.OrderBy(k => k.YuzOlcumu);
                    break;
            }

            DgKıtalar.ItemsSource = Kıtalar;
        }
        private void DgKıtalar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Kıta SeçiliKıta = (Kıta)DgKıtalar.SelectedItem;
            if (SeçiliKıta!=null)
            {
                NavigationService.Content = new KıtaAyrıntılarPage(SeçiliKıta);
            }
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Kıta SeçiliKıta = (Kıta)DgKıtalar.SelectedItem;
            if (SeçiliKıta!=null)
            {
                var cevap = MessageBox.Show("Seçili Kıta Silinsin Mi ?", "Sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap==MessageBoxResult.Yes)
                {
                    Veriler.Kıtalar.Remove(SeçiliKıta);
                    Filtreler();
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Kıta SeçiliKıta = (Kıta)DgKıtalar.SelectedItem;

            if (SeçiliKıta != null)

                NavigationService.Content = new KıtaDuzenlePage(SeçiliKıta);
        }
    }
}
