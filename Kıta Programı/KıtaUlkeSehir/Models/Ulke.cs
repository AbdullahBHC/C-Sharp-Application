using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace KıtaUlkeSehir.Models
{
    public class Ulke
    {
        public BitmapImage Bayrak { get; set; }
        public Kıta Kıta { get; set; }
        public string Nufus { get; set; }
        public string Sehirler { get; set; }
        public int TelefonKodu { get; set; }
        public string Ad { get; set; }
        public int UlkeKodu { get; set; }
        public string YuzOlcumu { get; set; }

        public override string ToString() => Ad;

    }
}
