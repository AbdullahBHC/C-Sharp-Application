using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Kanal_Programı.Models
{
    public static class Veriler
    {
        public static ObservableCollection<Kanal> Kanallar = new ObservableCollection<Kanal>();
        public static ObservableCollection<Program> Programlar = new ObservableCollection<Program>();

        static Veriler()
        {
            Kanallar.Add(new Kanal() { KanalAdı = "TRT BELGESEL", Logo = new BitmapImage(new Uri("/Images/TRT Belgesel.png", UriKind.Relative)) });
            Kanallar.Add(new Kanal() { KanalAdı = "National Geographic Channel", Logo = new BitmapImage(new Uri("/Images/National Geographic Channel.png", UriKind.Relative)) });
            Kanallar.Add(new Kanal() { KanalAdı = "Discovery Science", Logo = new BitmapImage(new Uri("/Images/Discovery Science.jpg", UriKind.Relative)) });
            Kanallar.Add(new Kanal() { KanalAdı = "Discovery Channel", Logo = new BitmapImage(new Uri("/Images/DiscoveryChannel.png", UriKind.Relative)) });

            Programlar.Add(
                new Program()
                {
                    ProgramAdı = "10’larca Bilgi",
                    Zaman = new DateTime(2020, 3, 3, 18, 0, 0),
                    Süre = 90,
                    Kanal = Kanallar[0]
                });

            Programlar.Add(
                new Program()
                {
                    ProgramAdı = "Çırak",
                    Zaman = new DateTime(2020, 3, 3, 19, 30, 0),
                    Süre = 90,
                    Kanal = Kanallar[0]
                });

            Programlar.Add(
                new Program()
                {
                    ProgramAdı = "Yeni Hayata Başlangıç",
                    Zaman = new DateTime(2020, 3, 3, 21, 30, 0),
                    Süre = 45,
                    Kanal = Kanallar[0]
                });

            Programlar.Add(
                new Program()
                {
                    ProgramAdı = "Ormanın Kahramanları",
                    Zaman = new DateTime(2020, 3, 4, 18, 30, 0),
                    Süre = 60,
                    Kanal = Kanallar[1]
                });

            Programlar.Add(
                new Program()
                {
                    ProgramAdı = "Büyük Kediler",
                    Zaman = new DateTime(2020, 3, 5, 20, 30, 0),
                    Süre = 60,
                    Kanal = Kanallar[1]
                });

            Programlar.Add(
                 new Program()
                 {
                     ProgramAdı = "Nasıl Yapılmış?",
                     Zaman = new DateTime(2020, 3, 4, 20, 00, 0),
                     Süre = 75,
                     Kanal = Kanallar[2]
                 });

            Programlar.Add(
                new Program()
                {
                    ProgramAdı = "Tamirat Tadilat",
                    Zaman = new DateTime(2020, 3, 6, 20, 30, 0),
                    Süre = 60,
                    Kanal = Kanallar[3]
                });
        }
    }
}
