using System;
using System.Collections.Generic;
using System.Text;

namespace KıtaUlkeSehir.Models
{
    public class Sehir
    {
        public string Nufus { get; set; }
        public string Ad { get; set; }
        public int TelefonKodu { get; set; }
        public Ulke Ulke { get; set; }
        public string YuzOlcumu { get; set; }

        public override string ToString() => Ad;
     }
}
