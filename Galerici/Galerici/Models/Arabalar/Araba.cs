using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Galerici.Models
{
    public class Araba
    {
        public Galeri Galeri { get; set; }
        public Marka Marka { get; set; }
        public Vites Vites { get; set; }
        public Yakıt Yakıt { get; set; }
        public Çekiş Çekiş { get; set; }
        public Kasa Kasa { get; set; }
        public string Model { get; set; }
        public int ÇıkışYılı { get; set; }
        public decimal Fiyat { get; set; }
        public int Km { get; set; }
        public string Renk { get; set; }
        public string MotorGücü { get; set; }
        public BitmapImage Resim { get; set; }

        public Durum Durum { get; set; }

        public override string ToString() => $"{Marka} {Model} {Galeri}";
       
    }
}
