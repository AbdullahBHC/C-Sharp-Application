using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace telefonsatısdeneme.Views
{
   public static class Veriler
    {
        public static ObservableCollection<Telefon> Telefonlar = new ObservableCollection<Telefon>();
        public static ObservableCollection<Marka> Markalar = new ObservableCollection<Marka>();
        public static ObservableCollection<İşletimSistemi> İşletimSistemleri = new ObservableCollection<İşletimSistemi>();

        static Veriler()
        {
            Marka mSamsung = new Marka()
            { 
                MarkaAdı = "Samsung",
                KuruluşYılı = 1938 ,
                MarkaResim= new BitmapImage(new Uri("/Images/samsung.png" ,UriKind.Relative))
            };
            Markalar.Add(mSamsung);

            Marka mApple = new Marka()
            { 
                MarkaAdı = "Apple",
                KuruluşYılı = 1976 ,
                MarkaResim = new BitmapImage(new Uri("/Images/iphone.png", UriKind.Relative))
            };
            Markalar.Add(mApple);

            Marka mXiaomi = new Marka() 
            { 
                MarkaAdı = "Xiaomi",
                KuruluşYılı = 2010 ,
                MarkaResim = new BitmapImage(new Uri("/Images/xiaomi.png", UriKind.Relative))
            };
            Markalar.Add(mXiaomi);


            İşletimSistemi isIOS = new İşletimSistemi() 
            {
                İşletimSistemii = "IOS" ,
                İşletimSistemiResim = new BitmapImage(new Uri("/Images/ios.png", UriKind.Relative))
            };
            İşletimSistemleri.Add(isIOS);

            İşletimSistemi isAndroid = new İşletimSistemi() 
            { 
                İşletimSistemii = "Android" ,
                İşletimSistemiResim = new BitmapImage(new Uri("/Images/android.png", UriKind.Relative))
            };
            İşletimSistemleri.Add(isAndroid);

            Telefon Telefon = new Telefon()
            {
                MarkaAdı=mSamsung,
                ModelAdı="Grand Neo Plus",
                Batarya=2600,
                Hafıza=8,
                Ram=1,
                İşletimSistemi=isAndroid,
                Fiyat=600,
                TelefonResim=new BitmapImage(new Uri("/Images/samsunggrandneoplus.png",UriKind.Relative))
            };
            Veriler.Telefonlar.Add(Telefon);

             Telefon = new Telefon()
            {
                MarkaAdı = mApple,
                ModelAdı = "İphone XS Max",
                Batarya = 4000,
                Hafıza = 128,
                Ram = 4,
                İşletimSistemi = isIOS,
                Fiyat = 15000,
                TelefonResim = new BitmapImage(new Uri("/Images/iphonexsmax.png", UriKind.Relative))
             };
            Veriler.Telefonlar.Add(Telefon);

             Telefon = new Telefon()
            {
                MarkaAdı = mXiaomi,
                ModelAdı = "Redmi Note 8 Pro",
                Batarya = 5000,
                Hafıza = 64,
                Ram = 6,
                İşletimSistemi = isAndroid,
                Fiyat = 2100,
                TelefonResim = new BitmapImage(new Uri("/Images/xiaomiredminote8pro.png", UriKind.Relative))
             };
            Veriler.Telefonlar.Add(Telefon);
        }
    }
}
