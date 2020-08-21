using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace telefonsatısdeneme.Views
{
    public class Marka
    {
        public string MarkaAdı { get; set; }
        public int KuruluşYılı { get; set; }
        public BitmapImage MarkaResim { get; set; }
        public override string ToString() => MarkaAdı;
    }
}
