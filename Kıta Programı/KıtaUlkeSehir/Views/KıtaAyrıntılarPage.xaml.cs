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
    /// KıtaAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class KıtaAyrıntılarPage : Page
    {
        
        public KıtaAyrıntılarPage(Kıta Kıta)
        {
            InitializeComponent();
            if (Kıta!=null)
            {
                TbKıta.Text = Kıta.Ad;
                TbYuzOlcumu.Text = Kıta.YuzOlcumu;
                ImgKıtaResim.Source = Kıta.Resim;
            }

            BtnGeri.Click += BtnGeri_Click;
        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
