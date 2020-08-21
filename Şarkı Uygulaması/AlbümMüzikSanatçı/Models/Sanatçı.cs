using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AlbümMüzikSanatçı.Models
{
    public class Sanatçı
    {
        public string SanatçıAdı { get; set; }
        public BitmapImage Resim { get; set; }

        public override string ToString()
        {
            return SanatçıAdı;
        }
    }
}
