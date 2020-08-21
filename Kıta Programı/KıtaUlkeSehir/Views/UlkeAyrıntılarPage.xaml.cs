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
    /// UlkeAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class UlkeAyrıntılarPage : Page
    {
        public UlkeAyrıntılarPage(Ulke Ulke)
        {
            InitializeComponent();
            if (Ulke!=null)
            {
                TbKıta.Text = Ulke.Kıta.Ad;
                TbNüfus.Text = Ulke.Nufus;
                TbSehirler.Text = Ulke.Sehirler;
                TbTelefonKodu.Text = Ulke.TelefonKodu.ToString();
                TbUlkeKod.Text = Ulke.UlkeKodu.ToString();
                TbYuzOlcumu.Text = Ulke.YuzOlcumu;
                TbÜlke.Text = Ulke.Ad;
            }

            BtnGeri.Click += BtnGeri_Click;
        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
