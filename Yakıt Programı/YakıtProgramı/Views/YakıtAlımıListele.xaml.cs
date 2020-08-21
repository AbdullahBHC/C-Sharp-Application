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
using YakıtProgramı.Models;

namespace YakıtProgramı.Views
{
    /// <summary>
    /// Interaction logic for YakıtAlımıListele.xaml
    /// </summary>
    public partial class YakıtAlımıListele : Page
    {
        public YakıtAlımıListele()
        {
            InitializeComponent();
            DgYakıtAlımları.ItemsSource = Veriler.YakıtAlımları;

            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            YakıtALımı SeçiliYakıtAlımı = (YakıtALımı)DgYakıtAlımları.SelectedItem;
            if (SeçiliYakıtAlımı!=null)
            {
                var cevap = MessageBox.Show("Seçili Yakıt Alımı Kaydı Silinecek ?", "Sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.YakıtAlımları.Remove(SeçiliYakıtAlımı);
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        { YakıtALımı SeçiliYakıtAlımı = (YakıtALımı)DgYakıtAlımları.SelectedItem;
            if (SeçiliYakıtAlımı != null)
            {
                NavigationService.Content = new YakıtAl(SeçiliYakıtAlımı);
            }
        }
    }
}
