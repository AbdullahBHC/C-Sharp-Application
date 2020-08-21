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
    /// Interaction logic for TelefonAyrıntılar.xaml
    /// </summary>
    public partial class TelefonAyrıntılar : Page
    {
        public TelefonAyrıntılar(Telefon telefon)
        {
            InitializeComponent();
            //TbBatarya.Text = $"{telefon.Batarya} mAh";
            //TbFiyat.Text = $"{telefon.Fiyat} ₺";
            //TbHafıza.Text = $"{telefon.Hafıza} GB";
            //TbMarka.Text = $"{telefon.MarkaAdı.MarkaAdı}";
            //TbModel.Text = telefon.ModelAdı;
            //TbRam.Text = $"{telefon.Ram} GB";
            //TbİşletimSistemi.Text = telefon.İşletimSistemi.İşletimSistemii;
            //ImgResim.Source = telefon.TelefonResim;

            this.DataContext = telefon;

            BtnGeri.Click += BtnGeri_Click;
        }
        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new TelefonListesi();
        }
    }
}
