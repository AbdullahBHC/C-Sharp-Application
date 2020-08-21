using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace telefonsatısdeneme.Views
{
   public class İşletimSistemi
    {
        public string İşletimSistemii { get; set; }
        public BitmapImage İşletimSistemiResim { get; set; }
        public override string ToString() => İşletimSistemii;
    }
}
