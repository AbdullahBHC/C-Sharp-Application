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
    /// SanatçıEklePage.xaml etkileşim mantığı
    /// </summary>
    public partial class SanatçıEklePage : Page
    {
        Sanatçı Sanatçı;
        public SanatçıEklePage(Sanatçı sanatçı = null)
        {
            InitializeComponent();
            this.Sanatçı = sanatçı;
            if (sanatçı != null)
            {
                TxSanatçıAdı.Text = sanatçı.SanatçıAdı;
                ImgSanatçı.Source = sanatçı.Resim;
            }

            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;

            #region Focus Olayı

            TxSanatçıAdı.GotFocus += (s, e) => TxSanatçıAdı.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue); TxSanatçıAdı.BorderThickness = new Thickness(2);
            TxSanatçıAdı.LostFocus += (s, e) => TxSanatçıAdı.BorderBrush = new SolidColorBrush(Colors.Gray); TxSanatçıAdı.BorderThickness = new Thickness(1);

            #endregion     
        }

            private void BtnKaydet_Click(object sender, RoutedEventArgs e)
            {
                if (Sanatçı == null)
                {
                    Sanatçı = new Sanatçı()
                    {
                        SanatçıAdı = TxSanatçıAdı.Text,
                        Resim = (BitmapImage)ImgSanatçı.Source,
                    };
                    Veriler.Sanatçılar.Add(Sanatçı);
                }
                else
                {
                    Sanatçı.SanatçıAdı = TxSanatçıAdı.Text;
                    Sanatçı.Resim = (BitmapImage)ImgSanatçı.Source;
                }

                var cevap = MessageBox.Show("Sanatçıları Listelemek İster Misin ?", "Listele - Kayıta Devam Et", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (cevap == MessageBoxResult.Yes)
                {
                    NavigationService.Content = new MüzikListesiPage();
                }
                else
                {
                    NavigationService.Content = new AlbümEklePage();
                }
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
                    ImgSanatçı.Source = new BitmapImage(new Uri(ofd.FileName));
                }
            }
        }
    } 
