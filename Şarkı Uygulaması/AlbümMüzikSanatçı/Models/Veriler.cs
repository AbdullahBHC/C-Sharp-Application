using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AlbümMüzikSanatçı.Models
{
    public static class Veriler
    {
        public static ObservableCollection<Sanatçı> Sanatçılar = new ObservableCollection<Sanatçı>();
        public static ObservableCollection<Albüm> Albümler = new ObservableCollection<Albüm>();
        public static ObservableCollection<Müzik> Müzikler = new ObservableCollection<Müzik>();

        static Veriler()
        {
            #region Sanatçılar

            Sanatçı sntPinkFloyd = new Sanatçı
            {
                SanatçıAdı = "Pink Floyd",
                Resim = new BitmapImage(new Uri("/Images/Pink Floyd.jpg", UriKind.Relative))
            };
            Sanatçılar.Add(sntPinkFloyd);
            Sanatçı sntJülideÖzçelik = new Sanatçı
            {
                SanatçıAdı = "Jülide Özçelik",
                Resim = new BitmapImage(new Uri("/Images/Jülide Özçelik.jpg", UriKind.Relative))
            };
            Sanatçılar.Add(sntJülideÖzçelik);
            Sanatçı sntBülentOrtaçgil = new Sanatçı
            {
                SanatçıAdı = "Bülent Ortaçgil",
                Resim = new BitmapImage(new Uri("/Images/Bülent Ortaçgil.jpg", UriKind.Relative))
            };
            Sanatçılar.Add(sntBülentOrtaçgil);

            #endregion

            #region Albümler

            Albüm albTheDarkSideOfTheMoon = new Albüm
            {
                Sanatçı = sntPinkFloyd,
                AlbümAdı = "The Dark Side Of The Moon",
                Yıl = 1973,
                Resim = new BitmapImage(new Uri("/Images/[1973] The Dark Side Of The Moon.jpg", UriKind.Relative))
            };
            Albümler.Add(albTheDarkSideOfTheMoon);
            Albüm albTheDivisionBell = new Albüm
            {
                Sanatçı = sntPinkFloyd,
                AlbümAdı = "The Division Bell",
                Yıl = 1994,
                Resim = new BitmapImage(new Uri("/Images/[1994] The Division Bell.jpg", UriKind.Relative))
            };
            Albümler.Add(albTheDivisionBell);
            Albüm albJazzİstanbulVolume1 = new Albüm
            {
                Sanatçı = sntJülideÖzçelik,
                AlbümAdı = "Jazz İstanbul Volume 1",
                Yıl = 2007,
                Resim = new BitmapImage(new Uri("/Images/[2007] Jazz İstanbul Volume 1.jpg", UriKind.Relative))
            };
            Albümler.Add(albJazzİstanbulVolume1);
            Albüm albOyunaDevam = new Albüm
            {
                Sanatçı = sntBülentOrtaçgil,
                AlbümAdı = "Oyuna Devam",
                Yıl = 1991,
                Resim = new BitmapImage(new Uri("/Images/[1991] Oyuna Devam.jpg", UriKind.Relative))
            };
            Albümler.Add(albOyunaDevam);

            #endregion

            #region Müzikler

            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 1, MüzikAdı = "Cluster One", Uzunluk = 345 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 2, MüzikAdı = "What Do You Want From Me", Uzunluk = 261 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 3, MüzikAdı = "Poles Apart", Uzunluk = 423 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 4, MüzikAdı = "Marooned", Uzunluk = 330 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 5, MüzikAdı = "A Great Day For Freedom", Uzunluk = 256 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 6, MüzikAdı = "Wearing The Inside Out", Uzunluk = 409 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 7, MüzikAdı = "Take It Back", Uzunluk = 372 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 8, MüzikAdı = "Coming Back To Life", Uzunluk = 379 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 9, MüzikAdı = "Keep Talking", Uzunluk = 370 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 10, MüzikAdı = "Lost For Words", Uzunluk = 314 });
            Müzikler.Add(new Müzik { Albüm = albTheDivisionBell, ParçaNumarası = 11, MüzikAdı = "High Hopes", Uzunluk = 510 });

            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 1, MüzikAdı = "Speak To Me", Uzunluk = 65 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 2, MüzikAdı = "Breathe", Uzunluk = 169 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 3, MüzikAdı = "On The Run", Uzunluk = 225 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 4, MüzikAdı = "Time", Uzunluk = 413 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 5, MüzikAdı = "The Great Gig In The Sky", Uzunluk = 283 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 6, MüzikAdı = "Money", Uzunluk = 342 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 7, MüzikAdı = "Us And Them", Uzunluk = 469 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 8, MüzikAdı = "Any Colour You Like", Uzunluk = 206 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 9, MüzikAdı = "Brain Damage", Uzunluk = 226 });
            Müzikler.Add(new Müzik { Albüm = albTheDarkSideOfTheMoon, ParçaNumarası = 10, MüzikAdı = "Eclipse", Uzunluk = 130 });

            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 1, MüzikAdı = "Kendinle Kalırsın", Uzunluk = 265 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 2, MüzikAdı = "Mecnun'um Leyla'mı Gördüm", Uzunluk = 247 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 3, MüzikAdı = "Nisan Valsi (Doğaçlama)", Uzunluk = 193 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 4, MüzikAdı = "Toprak", Uzunluk = 365 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 5, MüzikAdı = "Yalan Dünya", Uzunluk = 374 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 6, MüzikAdı = "Sıradan Bir Gün", Uzunluk = 271 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 7, MüzikAdı = "Sebep", Uzunluk = 255 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 8, MüzikAdı = "Anan Var Midur?", Uzunluk = 268 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 9, MüzikAdı = "Geçti Dost Kervanı", Uzunluk = 176 });
            Müzikler.Add(new Müzik { Albüm = albJazzİstanbulVolume1, ParçaNumarası = 10, MüzikAdı = "Bugün Neden Gelmedin?", Uzunluk = 279 });

            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 1, MüzikAdı = "Aşk Nereye Kadar", Uzunluk = 270 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 2, MüzikAdı = "Yasak", Uzunluk = 152 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 3, MüzikAdı = "Bütün Sokaklarım", Uzunluk = 320 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 4, MüzikAdı = "Zamana Sıkışmış", Uzunluk = 263 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 5, MüzikAdı = "Kızıma Mektup", Uzunluk = 262 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 6, MüzikAdı = "Bu Su Hiç Durmaz", Uzunluk = 335 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 7, MüzikAdı = "Duyuyor Musun?", Uzunluk = 230 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 8, MüzikAdı = "Yalnız", Uzunluk = 231 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 9, MüzikAdı = "Oyuna Devam", Uzunluk = 152 });
            Müzikler.Add(new Müzik { Albüm = albOyunaDevam, ParçaNumarası = 10, MüzikAdı = "Kaptan (Yolculuk Ne Zaman)", Uzunluk = 229 }); 

            #endregion

        }
    }
}
