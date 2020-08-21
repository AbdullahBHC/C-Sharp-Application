using KıtaUlkeSehir.Models;
using System;
using System.Collections.Generic;
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
    /// SehirAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class SehirAyrıntılarPage : Page
    {
        public SehirAyrıntılarPage(Sehir Sehir)
        {
            InitializeComponent();
            if (Sehir!=null)
            {
                TbNüfus.Text = Sehir.Nufus;
                TbSehir.Text = Sehir.Ad;
                TbTelefonKodu.Text = Sehir.TelefonKodu.ToString();
                TbUlke.Text = Sehir.Ulke.ToString();
                TbYuzOlcumu.Text = Sehir.YuzOlcumu;
            }

            BtnGeri.Click += BtnGeri_Click;
        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
