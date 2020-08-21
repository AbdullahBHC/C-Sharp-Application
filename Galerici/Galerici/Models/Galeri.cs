using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Galerici.Models
{
    public class Galeri
    {
        public string İsim { get; set; }
        public string Sahibi { get; set; }
        public int ArabaSayısı { get; set; }
        public string Konum { get; set; }
        public string KiralıkAraç_Fiyat { get; set; }
        public string KiralıkAraç_Model { get; set; }
        public string SatılıkAraç_Fiyat { get; set; }
        public string SatılıkAraç_Model { get; set; }
        public BitmapImage GaleriResim { get; set; }

        public override string ToString() => $"{İsim}";
      

    }
}
