using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Imaging;

namespace KıtaUlkeSehir.Models
{
    public static class Veriler
    {
        public static ObservableCollection<Kıta> Kıtalar = new ObservableCollection<Kıta>();
        public static ObservableCollection<Ulke> Ulkeler = new ObservableCollection<Ulke>();
        public static ObservableCollection<Sehir> Sehirler = new ObservableCollection<Sehir>();

        static Veriler()
        {
            #region Kıtalar 

            Kıtalar.Add(new Kıta()
            {
                Ad = "Kuzey Amerika",
                YuzOlcumu = "24.710.000 km²",
                Resim = new BitmapImage(new Uri("/Images/KuzeyAmerika.png", UriKind.Relative))
            });

            Kıtalar.Add(new Kıta()
            {
                Ad = "Güney Amerika",
                YuzOlcumu = "17.840.000 km²",
                Resim = new BitmapImage(new Uri("/Images/GuneyAmerika.png", UriKind.Relative))
            });

            Kıtalar.Add(new Kıta()
            {
                Ad = "Afrika",
                YuzOlcumu = "30.370.000 km²",
                Resim = new BitmapImage(new Uri("/Images/Afrika.png", UriKind.Relative))
            });

            Kıtalar.Add(new Kıta()
            {
                Ad = "Avrupa",
                YuzOlcumu = "10.180.000 km²",
                Resim = new BitmapImage(new Uri("/Images/Avrupa.png", UriKind.Relative))
            });

            Kıtalar.Add(new Kıta()
            {
                Ad = "Asya",
                YuzOlcumu = "44.580.000 km²",
                Resim = new BitmapImage(new Uri("/Images/Asya.png", UriKind.Relative))
            });

            Kıtalar.Add(new Kıta()
            {
                Ad = "Avustralya",
                YuzOlcumu = "07.692.000 km²",
                Resim = new BitmapImage(new Uri("/Images/Avustralya.png", UriKind.Relative))
            });

            Kıtalar.Add(new Kıta()
            {
                Ad = "Antarktika",
                YuzOlcumu = "14.000.000 km²",
                Resim = new BitmapImage(new Uri("/Images/Antarktika.png", UriKind.Relative))
            });

            #endregion

            #region Ülkeler

            Ulkeler.Add(new Ulke()
            {
                Ad = "Amerika Birleşik Devletleri",
                Kıta = Kıtalar[0],
                Nufus = "327,2 Milyon",
                Sehirler = "New York , Los Angeles , Chicago , Houston , Philadelphia , Phoenix , San Antonio , San Diego , Dallas , San Jose",
                TelefonKodu = 1,
                YuzOlcumu = "9.834.000 km²",
                UlkeKodu = 400,
                Bayrak = new BitmapImage(new Uri("/Images/ABD.png", UriKind.Relative)),
            });

            Ulkeler.Add(new Ulke()
            {
                Ad = "Meksika",
                Kıta = Kıtalar[1],
                Nufus = "129,2 Milyon ",
                Sehirler = "Meksiko , Ecatepec , Guadalajara , Tijuana , Ciudad Juárez , Puebla , Nezahualcóyotl , León , Zapopan , Monterrey",
                TelefonKodu = 52,
                YuzOlcumu = "1.973.000 km²",
                UlkeKodu = 412,
                Bayrak = new BitmapImage(new Uri("/Images/Meksika.png", UriKind.Relative)),
            });

            Ulkeler.Add(new Ulke()
            {
                Ad = "Mısır",
                Kıta = Kıtalar[2],
                Nufus = "97,55 Milyon",
                Sehirler = "Ahmim (Akhmim) , El Alameyn(Al `Alamayn) , El Ariş(Al `Arish) , Asvan(Aswan) , AsyutBenha(Banha) , Beni Süveyf(Bani Suwayf) , Ad DakhilahDemenhur(Damanhur) , Dendera(Dandarah)",
                TelefonKodu = 20,
                YuzOlcumu = "1.010.000 km²",
                UlkeKodu = 220,
                Bayrak = new BitmapImage(new Uri("/Images/Mısır.png", UriKind.Relative)),
            });

            Ulkeler.Add(new Ulke()
            {
                Ad = "Türkiye",
                Kıta = Kıtalar[3],
                Nufus = "80,81 Milyon",
                Sehirler = "İstanbul , Ankara , İzmir , Antalya , Kayseri , Trabzon , Hatay , Bursa , Eskişehir , Hakkari",
                TelefonKodu = 90,
                YuzOlcumu = "9.834.000 km²",
                UlkeKodu = 52,
                Bayrak = new BitmapImage(new Uri("/Images/Turkiye.png", UriKind.Relative)),
            });

            Ulkeler.Add(new Ulke()
            {
                Ad = "Çin",
                Kıta = Kıtalar[4],
                Nufus = "1,386 Milyar",
                Sehirler = "Pekin , Shanghai , Hong Kong , Tianjin , Wuhan , Shenyang , Guangzhou ,HarbinXi`an , Chongqing",
                TelefonKodu = 86,
                YuzOlcumu = "9.597.000 km²",
                UlkeKodu = 720,
                Bayrak = new BitmapImage(new Uri("/Images/Çin.png", UriKind.Relative)),
            });

            Ulkeler.Add(new Ulke()
            {
                Ad = "Avustralya",
                Kıta = Kıtalar[5],
                Nufus = "24,6 Milyon",
                Sehirler = "Sydney , Melbourne , Canberra , Brisbane , Adelaide , Perth , Darwin , Hobart , Cairns , Alice Springs",
                TelefonKodu = 61,
                YuzOlcumu = "7.692.000 km²",
                UlkeKodu = 800,
                Bayrak = new BitmapImage(new Uri("/Images/Avustralya2.png", UriKind.Relative)),
            });

            Ulkeler.Add(new Ulke()
            {
                Ad = "Ülke Bulunmuyor.",
                Kıta = Kıtalar[6],
                Nufus = "1000 (Kış) - 5000 (Yaz)",
                Sehirler = "Şehir Bulunmuyor.",
                TelefonKodu = 672,
                YuzOlcumu = "9.834.000 km²",
                UlkeKodu = 891,
                Bayrak = new BitmapImage(new Uri("/Images/Antarktika.png", UriKind.Relative)),
            });

            #endregion

            #region Şehirler

            Sehirler.Add(new Sehir()
            {
                Ad = "Los Angeles",
                Nufus = "4 milyon",
                TelefonKodu = 424,
                YuzOlcumu = "1.302 km²",
                Ulke = Ulkeler[0],
            });

            Sehirler.Add(new Sehir()
            {
                Ad = "Ecatepec",
                Nufus = "1,655 milyon",
                TelefonKodu = 478,
                YuzOlcumu = "186,9 km²",
                Ulke = Ulkeler[1],
            });

            Sehirler.Add(new Sehir()
            {
                Ad = "Kahire",
                Nufus = "19,5 milyon",
                TelefonKodu = 2,
                YuzOlcumu = "3.085 km²",
                Ulke = Ulkeler[2],
            });

            Sehirler.Add(new Sehir()
            {
                Ad = "Istanbul",
                Nufus = "15,52 milyon",
                TelefonKodu = 216,
                YuzOlcumu = "5.343 km²",
                Ulke = Ulkeler[3],
            });

            Sehirler.Add(new Sehir()
            {
                Ad = "Pekin",
                Nufus = "21,54 milyon",
                TelefonKodu = 10,
                YuzOlcumu = "16.808 km²",
                Ulke = Ulkeler[4],
            });

            Sehirler.Add(new Sehir()
            {
                Ad = "Sdney",
                Nufus = "5,23 milyon",
                TelefonKodu = 61,
                YuzOlcumu = "12.368 km²",
                Ulke = Ulkeler[5],
            });

            Sehirler.Add(new Sehir()
            {
                Ad = "Şehir Yok.",
                Nufus = "Ulke Nufusu :5000",
                TelefonKodu = 672,
                YuzOlcumu = "14.000.000 km²",
                Ulke = Ulkeler[6],
            }); 

            #endregion
        }
    }
}
