using Kanal_Programı.Views;
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

namespace Kanal_Programı
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frm.Content = new ProgramListele();

            RbKanalKayıt.Click += (s,e) => Frm.Content = new KanalKayıt();
            RbProgramKayıt.Click += (s, e) => Frm.Content = new ProgramKayıt();
            RbProgramListele.Click += (s, e) => Frm.Content = new ProgramListele();

            Frm.Navigated += Frm_Navigated;
        }
        private void Frm_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is KanalKayıt)
                RbKanalKayıt.IsChecked = true;

            else if (e.Content is ProgramKayıt) 
                RbProgramKayıt.IsChecked = true;

            else if (e.Content is ProgramListele) 
                RbProgramListele.IsChecked = true;
        }
    }
}
