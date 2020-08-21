using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AlbümMüzikSanatçı.Models
{
    public class Müzik
    {
        public Albüm Albüm { get; set; }
        public int ParçaNumarası { get; set; }
        public int Uzunluk { get; set; }
        public string MüzikAdı { get; set; }

        public override string ToString()
        {
            return MüzikAdı;
        }
    }
}
