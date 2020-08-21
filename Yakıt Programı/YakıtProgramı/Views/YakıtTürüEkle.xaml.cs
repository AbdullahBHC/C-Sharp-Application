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
    /// Interaction logic for YakıtTürüEkle.xaml
    /// </summary>
    public partial class YakıtTürüEkle : Page
    {
        YakıtTürü Yakıt;
        public YakıtTürüEkle(YakıtTürü yakıt=null)
        {
            InitializeComponent();
            this.Yakıt = yakıt;
            if (yakıt!=null)
            {
                TxYakıtLitre.Text = yakıt.YakıtLitre.ToString();
                TxYakıtTürü.Text = yakıt.YakıtTürüAdı;
            }

            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxYakıtLitre.Text, out int yakıtlitre);
            if (Yakıt==null)
            {
                Yakıt = new YakıtTürü()
                {
                    YakıtLitre = yakıtlitre,
                    YakıtTürüAdı = TxYakıtTürü.Text
                };
                Veriler.YakıtTürleri.Add(Yakıt);
            }
            else
            {
                Yakıt.YakıtLitre = yakıtlitre;
                Yakıt.YakıtTürüAdı = TxYakıtTürü.Text;
            }
            NavigationService.Content = new YakıtAl();
        }
    }
}
