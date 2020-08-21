using AlbümMüzikSanatçı.Views;
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
using System.Windows.Threading;

namespace AlbümMüzikSanatçı
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frm.Content = new MüzikListesiPage();
            RbAlbümEkle.Click += (s, e) => Frm.Content = new AlbümEklePage();
            RbMüzikEkle.Click += (s, e) => Frm.Content = new MüzikEklePage();
            RbSanatçıEkle.Click += (s, e) => Frm.Content = new SanatçıEklePage();
            RbMüzikListesi.Click += (s, e) => Frm.Content = new MüzikListesiPage();

            Frm.Navigated += Frm_Navigated;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TbSaat.Text = DateTime.Now.ToLongTimeString();
            TbTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void Frm_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is MüzikListesiPage)
                RbMüzikListesi.IsChecked = true;

            else if (e.Content is MüzikEklePage)
                RbMüzikEkle.IsChecked = true;

            else if (e.Content is AlbümEklePage)
                RbAlbümEkle.IsChecked = true;

            else if (e.Content is SanatçıEklePage)
                RbSanatçıEkle.IsChecked = true;
        }
    }
}
