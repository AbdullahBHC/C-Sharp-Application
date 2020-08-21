using AlbümMüzikSanatçı.Models;
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

namespace AlbümMüzikSanatçı.Views
{
    /// <summary>
    /// AlbümAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class AlbümAyrıntılarPage : Page
    {
        public AlbümAyrıntılarPage(Albüm Albüm)
        {
            InitializeComponent();
            if (Albüm!=null)
            {
                TxAlbümAdı.Text = Albüm.AlbümAdı;
                TxAlbümSanatçı.Text = Albüm.Sanatçı.SanatçıAdı;
                TxYıl.Text = Albüm.Yıl.ToString();
                ImgAlbüm.Source = Albüm.Resim;
            }

            BtnGoBack.Click += (s, e) => NavigationService.GoBack();
        }
    }
}
