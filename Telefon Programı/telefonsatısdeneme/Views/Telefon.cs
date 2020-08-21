using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace telefonsatısdeneme.Views
{
   public class Telefon
    {
        internal readonly int fiyatı;

        public Marka MarkaAdı { get; set; }
        public string ModelAdı { get; set; }
        public İşletimSistemi İşletimSistemi { get; set; }
        public int Hafıza { get; set; }
        public int Batarya { get; set; }
        public int Ram { get; set; }
        public int Fiyat { get; set; }
        public BitmapImage TelefonResim { get; set; }
        public override string ToString() => $"{MarkaAdı} - {ModelAdı} | {Fiyat}";
       
    }
}
