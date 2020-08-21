using KıtaUlkeSehir.Views;
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

namespace KıtaUlkeSehir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frm.Content = new KıtalarıListelePage();
            RbKıtalarıListele.Click += (s, e) => Frm.Content = new KıtalarıListelePage();
            RbÜlkeleriListele.Click += (s, e) => Frm.Content = new UlkeleriListelePage();
            RbŞehirleriListele.Click += (s, e) => Frm.Content = new SehirleriListelePage();

            Frm.Navigated += Frm_Navigated;
        }

        private void RbKıtalarıListele_GotFocus(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Frm_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is KıtalarıListelePage)
                RbKıtalarıListele.IsChecked = true;

            if (e.Content is UlkeleriListelePage)
                RbÜlkeleriListele.IsChecked = true;

            if (e.Content is SehirleriListelePage)
                RbŞehirleriListele.IsChecked = true;
        }
    }
}
