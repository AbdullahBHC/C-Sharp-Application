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
using YakıtProgramı.Models;

namespace YakıtProgramı.Views
{
    /// <summary>
    /// Interaction logic for YakıtAl.xaml
    /// </summary>
    public partial class YakıtAl : Page
    {
        YakıtALımı YakıtAL;
        public YakıtAl(YakıtALımı yakıt=null)
        {
            InitializeComponent();
            CbYakıtTürü.ItemsSource = Veriler.YakıtTürleri;

            if (yakıt!=null)
            {
                YakıtAL = yakıt;

                TxMiktar.Text = YakıtAL.Miktar.ToString();
                TxPlaka.Text = YakıtAL.Plaka;
                CbYakıtTürü.SelectedItem = YakıtAL.YakıtTürü;
                DpZaman.SelectedDate = YakıtAL.Zaman;
            }

            BtnKaydet.Click += BtnKaydet_Click;
        }


        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(TxMiktar.Text, out double miktar);

            if (YakıtAL == null)
            {
                YakıtAL= new YakıtALımı()
                {
                    Miktar = miktar,
                    Zaman = DpZaman.SelectedDate.Value,
                    Plaka = TxPlaka.Text,
                    YakıtTürü = (YakıtTürü)CbYakıtTürü.SelectedItem,
                };
                Veriler.YakıtAlımları.Add(YakıtAL);
            }
            else
            {
                YakıtAL.Miktar = miktar;
                YakıtAL.Zaman = DpZaman.SelectedDate.Value;
                YakıtAL.Plaka = TxPlaka.Text;
                YakıtAL.YakıtTürü = (YakıtTürü)CbYakıtTürü.SelectedItem;
            }
            NavigationService.Content = new YakıtAlımıListele();
        }
    }
}
