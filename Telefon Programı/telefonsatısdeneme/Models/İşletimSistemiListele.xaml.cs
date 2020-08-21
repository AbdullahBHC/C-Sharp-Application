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
    /// İşletimSistemiListele.xaml etkileşim mantığı
    /// </summary>
    public partial class İşletimSistemiListele : Page
    {
        public İşletimSistemiListele()
        {
            InitializeComponent();
            LbİşletimSistemleri.ItemsSource = Veriler.İşletimSistemleri;
            MiSil.Click += MiSil_Click;
            MiDüzenle.Click += MiDüzenle_Click;
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            İşletimSistemi SeçiliİşletimSistemi = (İşletimSistemi)LbİşletimSistemleri.SelectedItem;
            if (SeçiliİşletimSistemi != null)
            {
                NavigationService.Content = new İşletimSistemiEkle(SeçiliİşletimSistemi);
            }
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            İşletimSistemi SeçiliİşletimSistemi = (İşletimSistemi)LbİşletimSistemleri.SelectedItem;
            if (SeçiliİşletimSistemi != null)
            {
                var cevap = MessageBox.Show("Seçili Telefon Silinecek ?", "sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.İşletimSistemleri.Remove(SeçiliİşletimSistemi);
                }
            }
        }
    }
}
