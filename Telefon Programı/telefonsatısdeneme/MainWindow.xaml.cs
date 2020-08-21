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
using telefonsatısdeneme.Models;

namespace telefonsatısdeneme
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frm.Content = new TelefonListesi();
            RbTelefonEkle.Click += RbTelefonEkle_Click;
            RbTelefonListele.Click += RbTelefonListele_Click;
            RbMarkaEkle.Click += RbMarkaEkle_Click;
            RbMarkaListele.Click += RbMarkaListele_Click;
            RbİşletimSistemiListele.Click += RbİşletimSistemiListele_Click;
            RbişletimSistemiEkle.Click += RbişletimSistemiEkle_Click;
            Frm.Navigated += Frm_Navigated;
            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape && Frm.Content is TelefonAyrıntılar)
                Frm.GoBack();
        }

        private void Frm_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is TelefonEkle)
            {
                RbTelefonEkle.IsChecked = true;
            }
            else if (e.Content is TelefonListesi)
            {
                RbTelefonListele.IsChecked = true;
            }
            else if (e.Content is MarkaEkle)
            {
                RbMarkaEkle.IsChecked = true;
            }
            else if (e.Content is MarkaListele)
            {
                RbMarkaListele.IsChecked = true;
            }
            else if (e.Content is İşletimSistemiEkle)
            {
                RbişletimSistemiEkle.IsChecked = true;
            }
            else if (e.Content is İşletimSistemiListele)
            {
                RbİşletimSistemiListele.IsChecked = true;
            }
        }
        private void RbişletimSistemiEkle_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new İşletimSistemiEkle();
        }

        private void RbİşletimSistemiListele_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new İşletimSistemiListele();
        }

        private void RbMarkaListele_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new MarkaListele();
        }

        private void RbMarkaEkle_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new MarkaEkle();
        }
        private void RbTelefonListele_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new TelefonListesi();
        }

        private void RbTelefonEkle_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new TelefonEkle();
        }
    }
}
