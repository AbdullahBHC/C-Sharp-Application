using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace YakıtProgramı.Models
{
    public class YakıtALımı
    {
        public DateTime Zaman { get; set; }
        public string Plaka { get; set; }
        public YakıtTürü YakıtTürü { get; set; }
        public double Miktar { get; set; }

        public BitmapImage Resim { get; set; }
        public override string ToString() => $"{Zaman}{Plaka}{Miktar}";
      
    }
}
