using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace YakıtProgramı.Models
{
    public static class Veriler
    {
        public static ObservableCollection<YakıtALımı> YakıtAlımları = new ObservableCollection<YakıtALımı>();
        public static ObservableCollection<YakıtTürü> YakıtTürleri = new ObservableCollection<YakıtTürü>();

        static Veriler()
        {
            #region Yakıt Türleri

            YakıtTürü yBenzin = new YakıtTürü() { YakıtTürüAdı = "Benzin", YakıtLitre = 7 };
            YakıtTürleri.Add(yBenzin);

            YakıtTürü yMazot = new YakıtTürü() { YakıtTürüAdı = "Mazot", YakıtLitre = 6 };
            YakıtTürleri.Add(yMazot);

            YakıtTürü yGaz = new YakıtTürü() { YakıtTürüAdı = "Gaz", YakıtLitre = 3 };
            YakıtTürleri.Add(yGaz);

            #endregion

            #region Yakıt Alımları

            YakıtAlımları.Add(new YakıtALımı
            {
                Zaman = new DateTime(2020, 02, 24, 16, 20, 45),
                Plaka = "34 ZJ 2569",
                Miktar = 10,
                YakıtTürü = yMazot,
                Resim = new BitmapImage(new Uri("Images/mercedes.png",UriKind.Relative))
            });

            YakıtAlımları.Add(new YakıtALımı
            {
                Zaman = new DateTime(2019, 10, 13, 23, 47, 04),
                Plaka = "34 MKA 1983",
                Miktar = 120,
                YakıtTürü = yBenzin,
                Resim = new BitmapImage(new Uri("Images/bmw.png", UriKind.Relative))
            });

            YakıtAlımları.Add(new YakıtALımı
            {
                Zaman = new DateTime(2020, 01, 06, 21, 54, 29),
                Plaka = "34 KL 9173",
                Miktar = 5,
                YakıtTürü = yGaz,
                Resim = new BitmapImage(new Uri("Images/audi.jpg", UriKind.Relative))
            });

            YakıtAlımları.Add(new YakıtALımı
            {
                Zaman = new DateTime(2020, 02, 16, 04, 13, 49),
                Plaka = "34 PSV 0101",
                Miktar = 90,
                YakıtTürü = yBenzin,
                Resim = new BitmapImage(new Uri("Images/mercedes.png", UriKind.Relative))
            }); 

            #endregion
        }
    }
}
