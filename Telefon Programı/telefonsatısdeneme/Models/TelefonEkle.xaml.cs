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
    /// TelefonEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class TelefonEkle : Page
    {
        Telefon Telefon;
        public TelefonEkle(Telefon telefon=null)
        {
            InitializeComponent();
            this.Telefon = telefon;
            CbMarka.ItemsSource = Veriler.Markalar;
            CbİşletimSistemi.ItemsSource = Veriler.İşletimSistemleri;
            if (telefon!=null)
            {
                TxBatarya.Text = telefon.Batarya.ToString();
                TxFiyat.Text = telefon.Fiyat.ToString();
                TxHafıza.Text = telefon.Hafıza.ToString();
                TxKamera.Text = telefon.Hafıza.ToString();
                TxModel.Text = telefon.ModelAdı;
                TxRam.Text = telefon.Ram.ToString();
                CbMarka.SelectedItem = telefon.MarkaAdı;
                CbİşletimSistemi.SelectedItem = telefon.İşletimSistemi;
                ImgResim.Source = telefon.TelefonResim;
            }
            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxBatarya.Text, out int batarya);
            int.TryParse(TxFiyat.Text, out int fiyat);
            int.TryParse(TxHafıza.Text, out int hafıza);
            int.TryParse(TxKamera.Text, out int kamera);
            int.TryParse(TxRam.Text, out int ram);
            if (Telefon==null)
            {
                Telefon t = new Telefon()
                {
                    MarkaAdı = (Marka)CbMarka.SelectedItem,
                    ModelAdı = TxModel.Text,
                    Batarya = batarya,
                    Hafıza = hafıza,
                    İşletimSistemi = (İşletimSistemi)CbİşletimSistemi.SelectedItem,
                    Ram = ram,
                    Fiyat=fiyat,
                    TelefonResim=(BitmapImage)ImgResim.Source,
                };
                Veriler.Telefonlar.Add(t);
            }
            else
            {
               Telefon.MarkaAdı = (Marka)CbMarka.SelectedItem;
               Telefon.ModelAdı = TxModel.Text;
               Telefon.Batarya = batarya;
               Telefon.Hafıza = hafıza;
               Telefon.İşletimSistemi = (İşletimSistemi)CbİşletimSistemi.SelectedItem;
               Telefon.Ram = ram;
               Telefon.Fiyat = fiyat;
               Telefon.TelefonResim = (BitmapImage)ImgResim.Source;
            }
            NavigationService.Content = new TelefonListesi();
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
              ImgResim.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
