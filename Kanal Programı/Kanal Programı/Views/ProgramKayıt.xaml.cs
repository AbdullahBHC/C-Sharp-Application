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
    /// Interaction logic for ProgramKayıt.xaml
    /// </summary>
    public partial class ProgramKayıt : Page
    {
        Program Programkayıt;
        public ProgramKayıt(Program programkayıt=null)
        {
            InitializeComponent();
            CbKanallar.ItemsSource = Veriler.Kanallar;
            this.Programkayıt = programkayıt;
            if (programkayıt!=null)
            {
                CbKanallar.SelectedItem = programkayıt.Kanal;
                TxProgramAdı.Text = programkayıt.ProgramAdı;
                DpZaman.SelectedDate = programkayıt.Zaman;
                TxSüre.Text = programkayıt.Süre.ToString();
            }

            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxSüre.Text, out int süre);
            if (Programkayıt==null)
            {
                Programkayıt = new Program()
                {
                    Kanal = (Kanal)CbKanallar.SelectedItem,
                    ProgramAdı =TxProgramAdı.Text,
                    Süre = süre,
                    Zaman = DpZaman.SelectedDate.Value,
                };
                Veriler.Programlar.Add(Programkayıt);
            }
            else
            {
                Programkayıt.Kanal = (Kanal)CbKanallar.SelectedItem;
                Programkayıt.ProgramAdı = TxProgramAdı.Text;
                   Programkayıt.Süre = süre;
                Programkayıt.Zaman = DpZaman.SelectedDate.Value;
            }

            NavigationService.Content = new ProgramListele();
        }
    }
}
