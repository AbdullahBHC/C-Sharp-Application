using Kanal_Programı.Models;
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

namespace Kanal_Programı.Views
{
    /// <summary>
    /// Interaction logic for KanalKayıt.xaml
    /// </summary>
    public partial class KanalKayıt : Page
    {
        Kanal Kanal;
        public KanalKayıt(Kanal kanal=null)
        {
            InitializeComponent();
            this.Kanal = kanal;
            if (kanal!=null)
            {
                TxKanalAdı.Text = kanal.KanalAdı;
                ImgLogo.Source = kanal.Logo;
            }

            BtnGözat.Click += BtnGözat_Click;
            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (Kanal==null)
            {
                Kanal = new Kanal()
                {
                    KanalAdı = TxKanalAdı.Text,
                    Logo = (BitmapImage)ImgLogo.Source,
                };
                Veriler.Kanallar.Add(Kanal);
            }
            else
            {
                Kanal.KanalAdı = TxKanalAdı.Text;
                Kanal.Logo = (BitmapImage)ImgLogo.Source;
            }
            NavigationService.Content = new ProgramListele();
        }

        private void BtnGözat_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Resim Seç",
                Filter ="Resim Dosyaları|*-jpg;*.png",
            };
            if (ofd.ShowDialog()==true)
            {
                ImgLogo.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
