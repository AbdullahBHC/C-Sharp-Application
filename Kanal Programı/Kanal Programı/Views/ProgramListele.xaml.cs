using Kanal_Programı.Models;
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

namespace Kanal_Programı.Views
{
    /// <summary>
    /// Interaction logic for ProgramListele.xaml
    /// </summary>
    public partial class ProgramListele : Page
    {
        public ProgramListele()
        {
            InitializeComponent();
            Filtrele();
            MiSil.Click += MiSil_Click;
            MiDüzenle.Click += MiDüzenle_Click;
        }

        private void Filtrele()
        {
            CbKanalFiltrele.ItemsSource = Veriler.Kanallar;
            IEnumerable<Program> Programlar = Veriler.Programlar.AsEnumerable();

            Programlar = Programlar.Where(p => p.Kanal.KanalAdı.StartsWith(TxAra.Text, StringComparison.CurrentCultureIgnoreCase) 
            || p.ProgramAdı.StartsWith(TxAra.Text,StringComparison.CurrentCultureIgnoreCase) 
            || p.Zaman.ToString().StartsWith(TxAra.Text));

            Kanal SeçiliKanal = (Kanal)CbKanalFiltrele.SelectedItem;
            if (SeçiliKanal!=null)
            {
                Programlar = Programlar.Where(p => p.Kanal == SeçiliKanal);
            }

            DgProgramlar.ItemsSource = Programlar;
        }
        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Program SeçiliProgram = (Program)DgProgramlar.SelectedItem;
            if (SeçiliProgram != null)
            {
                NavigationService.Content = new ProgramKayıt(SeçiliProgram);
            }
        }
        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Program SeçiliProgram = (Program)DgProgramlar.SelectedItem;
            if (SeçiliProgram!=null)
            {
                var cevap = MessageBox.Show("Seçili Program Silinsin Mi ? ", "Sil", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Programlar.Remove(SeçiliProgram);
                    Filtrele();
                }
            }
        }
    }
}
