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
    /// MarkaListele.xaml etkileşim mantığı
    /// </summary>
    public partial class MarkaListele : Page
    {
        public MarkaListele()
        {
            InitializeComponent();
            LbMarkalar.ItemsSource = Veriler.Markalar;
            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Marka SeçiliMarka = (Marka)LbMarkalar.SelectedItem;
            if (SeçiliMarka != null)
            {
                var cevap = MessageBox.Show("Seçili Telefon Silinecek ?", "sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Markalar.Remove(SeçiliMarka);
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Marka SeçiliMarka = (Marka)LbMarkalar.SelectedItem;
            if (SeçiliMarka!=null)
            {
                NavigationService.Content = new MarkaEkle(SeçiliMarka);
            }
        }
    }
}
