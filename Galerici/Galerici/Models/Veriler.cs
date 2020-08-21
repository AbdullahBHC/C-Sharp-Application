using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Galerici.Models
{
    public static class Veriler
    {
        public static ObservableCollection<Galeri> Galeriler = new ObservableCollection<Galeri>();
        public static ObservableCollection<Araba> Arabalar = new ObservableCollection<Araba>();

        public static ObservableCollection<Çekiş> ÇekişTürleri = new ObservableCollection<Çekiş>();
        public static ObservableCollection<Durum> ArabaDurumları = new ObservableCollection<Durum>();
        public static ObservableCollection<Marka> Markalar = new ObservableCollection<Marka>();
        public static ObservableCollection<Vites> VitesTürleri = new ObservableCollection<Vites>();
        public static ObservableCollection<Yakıt> YakıtTürleri = new ObservableCollection<Yakıt>();
        public static ObservableCollection<Kasa> KasaTipleri = new ObservableCollection<Kasa>();

        static Veriler()
        {
            #region Galeriler

            Galeriler.Add(new Galeri()
            {
                İsim = "BHC Rent A Car",
                Sahibi = "Mehmet Bahceci",
                Konum = "İstanbul - Kağıthane",
                ArabaSayısı = 20,
                KiralıkAraç_Model = "Renault Clio - 2011",
                KiralıkAraç_Fiyat = "Günlük 150₺ - Aylık 3.500₺",
                SatılıkAraç_Model = "Peugeot 206 - 2006",
                SatılıkAraç_Fiyat = "33.750₺",
                GaleriResim = new BitmapImage(new Uri("/Images/ArabaResimleri/BHC.jpg" , UriKind.Relative)),
            });
            Galeriler.Add(new Galeri()
            {
                İsim = "SALE Rent A Car",
                Sahibi = "Gökhan Gönül",
                Konum = "Ordu - Çarşamba",
                ArabaSayısı = 30,
                KiralıkAraç_Model = "Citroen C Elyesee - 2014",
                KiralıkAraç_Fiyat = "Günlük 225₺ - Aylık 6.000₺",
                SatılıkAraç_Model = "Volkswagen Passat - 2018",
                SatılıkAraç_Fiyat = "290.000₺",
                GaleriResim = new BitmapImage(new Uri("/Images/ArabaResimleri/SALE.jpg", UriKind.Relative)),
            }); 

            #endregion

            #region Araba Özellikleri 

            ÇekişTürleri.Add(new Çekiş() { ÇekişTürü = "Önden Çekiş" });
            ÇekişTürleri.Add(new Çekiş() { ÇekişTürü = "Arkadan Çekiş" });
            ÇekişTürleri.Add(new Çekiş() { ÇekişTürü = "4x4" });

            ArabaDurumları.Add(new Durum() { Durumu = "Sıfır" });
            ArabaDurumları.Add(new Durum() { Durumu = "İkinci El" });

            Markalar.Add(new Marka() { MarkaAdı = "BMW" });
            Markalar.Add(new Marka() { MarkaAdı = "Audi" });
            Markalar.Add(new Marka() { MarkaAdı = "Peugeot" });
            Markalar.Add(new Marka() { MarkaAdı = "Renault" });

            VitesTürleri.Add(new Vites() { VitesTürü = "Otomatik" });
            VitesTürleri.Add(new Vites() { VitesTürü = "Manuel" });
            VitesTürleri.Add(new Vites() { VitesTürü = "Yarı Otomatik" });

            YakıtTürleri.Add(new Yakıt() { YakıtTürü = "Dizel" });
            YakıtTürleri.Add(new Yakıt() { YakıtTürü = "Benzin" });
            YakıtTürleri.Add(new Yakıt() { YakıtTürü = "LPG" });

            KasaTipleri.Add(new Kasa() { KasaTipi ="Hatchback"});
            KasaTipleri.Add(new Kasa() { KasaTipi ="Sedan"});
            KasaTipleri.Add(new Kasa() { KasaTipi = "SUV" });

            #endregion

            #region Arabalar

            Arabalar.Add(new Araba()
            {
                Model = "5.20D",
                MotorGücü = "150 Beygir",
                Renk = "Siyah",
                ÇıkışYılı = 2014,
                Km = 10000,
                Fiyat = 250000,
                Galeri = Galeriler[0],
                Marka = Markalar[0],
                Durum = ArabaDurumları[1],
                Kasa = KasaTipleri[1],
                Vites = VitesTürleri[0],
                Çekiş = ÇekişTürleri[1],
                Yakıt = YakıtTürleri[1],
                Resim = new BitmapImage(new Uri("/Images/ArabaResimleri/BMW520D.png",UriKind.Relative)),
            });

            Arabalar.Add(new Araba()
            {
                Model = "206",
                MotorGücü = "70 Beygir",
                Renk = "Kırmızı",
                ÇıkışYılı = 2011,
                Km = 190000,
                Fiyat = 120000,
                Galeri = Galeriler[1],
                Marka = Markalar[2],
                Durum = ArabaDurumları[1],
                Kasa = KasaTipleri[0],
                Vites = VitesTürleri[1],
                Çekiş = ÇekişTürleri[0],
                Yakıt = YakıtTürleri[2],
                Resim = new BitmapImage(new Uri("/Images/ArabaResimleri/peugeot.jpg", UriKind.Relative)),
            });

            Arabalar.Add(new Araba()
            {
                Model = "Symbol",
                MotorGücü = "110 Beygir",
                Renk = "Beyaz",
                ÇıkışYılı = 2018,
                Km = 5000,
                Fiyat = 170000,
                Galeri = Galeriler[0],
                Marka = Markalar[3],
                Durum = ArabaDurumları[1],
                Kasa = KasaTipleri[1],
                Vites = VitesTürleri[2],
                Çekiş = ÇekişTürleri[0],
                Yakıt = YakıtTürleri[0],
                Resim = new BitmapImage(new Uri("/Images/ArabaResimleri/Symbol.png", UriKind.Relative)),
            });
            Arabalar.Add(new Araba()
            {
                Model = "RS 6",
                MotorGücü = "550 Beygir",
                Renk = "Gri",
                ÇıkışYılı = 2020,
                Km = 0,
                Fiyat = 750000,
                Galeri = Galeriler[1],
                Marka = Markalar[1],
                Durum = ArabaDurumları[0],
                Kasa = KasaTipleri[2],
                Vites = VitesTürleri[0],
                Çekiş = ÇekişTürleri[2],
                Yakıt = YakıtTürleri[1],
                Resim = new BitmapImage(new Uri("/Images/ArabaResimleri/RS6.png", UriKind.Relative)),
            });
            #endregion         
        } 


    }
}
