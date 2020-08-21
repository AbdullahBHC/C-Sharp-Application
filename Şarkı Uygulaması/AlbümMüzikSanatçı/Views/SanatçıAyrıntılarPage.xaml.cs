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
    /// SanatçıAyrıntılarPage.xaml etkileşim mantığı
    /// </summary>
    public partial class SanatçıAyrıntılarPage : Page
    {
        public SanatçıAyrıntılarPage(Sanatçı Sanatçı)
        {
            InitializeComponent();
            if (Sanatçı!=null)
            {
                TxSanatçı.Text = Sanatçı.SanatçıAdı;
                ImgSanatçı.Source = Sanatçı.Resim;
            }

            BtnGoBack.Click += (s, e) => NavigationService.GoBack();
        }
    }
}
