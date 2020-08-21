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
using YakıtProgramı.Views;

namespace YakıtProgramı
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frm.Content = new YakıtAlımıListele();
            RbBenzinlik.Click += RbBenzinlik_Click;
            RbYakıtTürüEkle.Click += RbYakıtTürüEkle_Click;
            RbYakıtAlımıListele.Click += RbYakıtAlımıListele_Click;
            Frm.Navigated += Frm_Navigated;
        }

        private void Frm_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is YakıtAl)
            {
                RbBenzinlik.IsChecked = true;
            }
            else if (e.Content is YakıtAlımıListele)
            {
                RbYakıtAlımıListele.IsChecked = true;
            }
            else if (e.Content is YakıtTürüEkle)
            {
                RbYakıtTürüEkle.IsChecked = true;
            }
        }

        private void RbYakıtAlımıListele_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new YakıtAlımıListele();
        }

        private void RbYakıtTürüEkle_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new YakıtTürüEkle();
        }

        private void RbBenzinlik_Click(object sender, RoutedEventArgs e)
        {
            Frm.Content = new YakıtAl();
        }
    }
}
