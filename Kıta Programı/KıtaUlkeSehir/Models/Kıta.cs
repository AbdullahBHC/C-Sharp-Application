using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace KıtaUlkeSehir.Models
{
    public class Kıta
    {
        public string Ad { get; set; }
        public BitmapImage Resim { get; set; }
        public string YuzOlcumu { get; set; }

        public override string ToString() => Ad;

    }
}
