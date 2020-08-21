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
    /// TelefonListesi.xaml etkileşim mantığı
    /// </summary>
    public partial class TelefonListesi : Page
    {
        public TelefonListesi()
        {
            InitializeComponent();
            Özet();
            CbFiltreler.ItemsSource = new string[]
           {
                "Tüm Telefonlar", //0
                "Fiyatı 2,000₺ Altı Olan Telefonlar", //1
                "Markası Samsung Olan Telefonlar", //2
                "Markası Samsung Ve Fiyatı 4,000₺ Üzerinde Telefonlar", //3
                "İşletim Sistemi Android Olan Telefonlar", //4
                "Pil Kapasitesi 4,000 mAh Üzeri Ve Ya Hafıza Miktarı 128 GB Olan Telefonlar", //5
                "Model Adı İçinde 9 Rakamı Geçen Telefonlar", //6
                "Marka Adı 7 Karakterden Daha Uzun Olan Telefonlar", //7

           };

            CbSırala.ItemsSource = new string[]
            {
                "Marka Adı", //0
                "Marka Adı (Tersten)", //1
                "Fiyat", //2
                "Fiyat (Tersten)", //3
                "Marka Adı , Model Adı", //4
                "Marka Adı , Model Adı (tersten)", //5
                "İşletim Sistemi", //6
                "Hafıza", //7
                "İşletim Sistemi , Hafıza (Tersten) , Kamera Çözünürlüğü (Tersten)" //8
            };
            CbSırala.SelectedIndex = 0;
            CbFiltreler.SelectedIndex = 0;
            LboxTelefonlar.ItemsSource = Veriler.Telefonlar;

            LboxTelefonlar.MouseDoubleClick += LboxTelefonlar_MouseDoubleClick;
            CbFiltreler.SelectionChanged += CbFiltreler_SelectionChanged;
            TxAra.TextChanged += TxAra_TextChanged;
            CbSırala.SelectionChanged += CbSırala_SelectionChanged;
            LboxTelefonlar.ItemsSource = Veriler.Telefonlar;
            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;
        }

        private void LboxTelefonlar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Telefon SeçiliTelefon = (Telefon)LboxTelefonlar.SelectedItem;
            if (SeçiliTelefon!=null)
            {
                NavigationService.Content = new TelefonAyrıntılar(SeçiliTelefon);
            }
        }

        private void CbSırala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtrele();
        }

        private void Filtrele()
        {
            IEnumerable<Telefon> Telefonlar = Veriler.Telefonlar.AsEnumerable();

            if (string.IsNullOrWhiteSpace(TxAra.Text) == false)
            {
                Telefonlar = Telefonlar.Where(t => t.MarkaAdı.MarkaAdı.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase) || t.ModelAdı.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase));
            }

            switch (CbFiltreler.SelectedIndex)
            {
                //case 0:
                //    LboxTelefonlar.ItemsSource = Veriler.Telefonlar;
                //    break;
                case 1:
                    Telefonlar = Telefonlar.Where(t => t.Fiyat <= 2000);
                    break;
                case 2:
                    Telefonlar = Telefonlar.Where(t => t.MarkaAdı.MarkaAdı.StartsWith("Samsung"));
                    break;
                case 3:
                    Telefonlar = Telefonlar.Where(t => t.MarkaAdı.MarkaAdı.StartsWith("Samsung") && t.fiyatı > 4000);
                    break;
                case 4:
                    Telefonlar = Telefonlar.Where(t => t.İşletimSistemi.İşletimSistemii.StartsWith("Android"));
                    break;
                case 5:
                    Telefonlar = Telefonlar.Where(t => t.Batarya >= 4000 || t.Hafıza == 128);
                    break;
                case 6:
                    Telefonlar = Telefonlar.Where(t => t.ModelAdı.Contains("9"));
                    break;
                case 7:
                    Telefonlar = Telefonlar.Where(t => t.MarkaAdı.MarkaAdı.Length > 7);
                    break;
            }

            switch (CbSırala.SelectedIndex)
            {
                //"Marka Adı", //0
                case 0:
                    Telefonlar = Telefonlar.OrderBy(t => t.MarkaAdı.MarkaAdı);
                    break;

                //"Marka Adı (Tersten)", //1
                case 1:
                    Telefonlar = Telefonlar.OrderByDescending(t => t.MarkaAdı.MarkaAdı);
                    break;

                //"Fiyat", //2
                case 2:
                    Telefonlar = Telefonlar.OrderBy(t => t.Fiyat);
                    break;

                //"Fiyat (Tersten)", //3
                case 3:
                    Telefonlar = Telefonlar.OrderByDescending(t => t.Fiyat);
                    break;

                //"Marka Adı , Model Adı", //4
                case 4:
                    Telefonlar = Telefonlar.OrderBy(t => t.MarkaAdı.MarkaAdı).ThenBy(t => t.ModelAdı);
                    break;

                //"Marka Adı , Model Adı (tersten)", //5
                case 5:
                    Telefonlar = Telefonlar.OrderBy(t => t.MarkaAdı.MarkaAdı).ThenByDescending(t => t.ModelAdı);
                    break;

                //"İşletim Sistemi", //6
                case 6:
                    Telefonlar = Telefonlar.OrderBy(t => t.İşletimSistemi.İşletimSistemii);
                    break;

                //"Hafıza", //7
                case 7:
                    Telefonlar = Telefonlar.OrderBy(t => t.Hafıza);
                    break;

                //"İşletim Sistemi , Hafıza (Tersten) , Kamera Çözünürlüğü (Tersten)" //8
                case 8:
                    Telefonlar = Telefonlar.OrderBy(t => t.İşletimSistemi.İşletimSistemii).ThenByDescending(t => t.Hafıza);
                    break;
            }

            LboxTelefonlar.ItemsSource = Telefonlar;
        }
        private void TxAra_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtrele();
        }

        private void CbFiltreler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtrele();
        }
        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Telefon SeçiliTelefon = (Telefon)LboxTelefonlar.SelectedItem;
            if (SeçiliTelefon!=null)
            {
                var cevap = MessageBox.Show("Seçili Telefon Silinecek ?", "sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap==MessageBoxResult.Yes)
                {
                    Veriler.Telefonlar.Remove(SeçiliTelefon);
                    Özet();
                }
                NavigationService.Content = new TelefonListesi();
            }
        }

        private void Özet()
        {
            if (Veriler.Telefonlar.Count>0)
            {
                TbEnYüksekFiyat.Text = Veriler.Telefonlar.Max(t => t.Fiyat).ToString("#,### TL");
                TbEnDüşükFiyat.Text = Veriler.Telefonlar.Min(t => t.Fiyat).ToString("#,### TL");
                TbOrtalamaFiyat.Text = Veriler.Telefonlar.Average(t => t.Fiyat).ToString("#,### TL");

                // 2.Yöntem -> TbOrtalamaFiyat.Text = Veriler.Telefonlar.Select(t=>t.Fiyat).DefaultIfEmpty().Max().ToString();
            }

            TbBütünFiyatlarınToplamı.Text = Veriler.Telefonlar.Sum(t => t.Fiyat).ToString("#,### TL");

            TbTelefonAdedi.Text = Veriler.Telefonlar.Count().ToString();
            TbSamsungTelefonAdedi.Text = Veriler.Telefonlar.Where(t => t.MarkaAdı.MarkaAdı == "Samsung").Count().ToString();

            TbEnDüşüKFiyatlıTelefon.Text = Veriler.Telefonlar.OrderBy(t => t.Fiyat).FirstOrDefault()?.ToString();
            TbEnYüksekFiyatlıTelefon.Text = Veriler.Telefonlar.OrderByDescending(t => t.Fiyat).FirstOrDefault()?.ToString();
        }
        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Telefon SeçiliTelefon = (Telefon)LboxTelefonlar.SelectedItem;
            if (SeçiliTelefon!=null)
            {
                NavigationService.Content = new TelefonEkle(SeçiliTelefon);
            }
        }
    }
}
