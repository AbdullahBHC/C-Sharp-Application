using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Kanal_Programı.Models
{
    public class Kanal
    {
        public string KanalAdı { get; set; }
        public BitmapImage Logo { get; set; }

        public override string ToString() => KanalAdı;
    
    }
}
