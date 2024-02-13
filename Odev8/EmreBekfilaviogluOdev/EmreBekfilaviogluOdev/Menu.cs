using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreBekfilaviogluOdev
{
    public class Menu : Urun
    {
       
        public int MenuAdedi { get; set; }

        public double BoySecimi { get; set; }

        public double EkMalzemeFiyati { get; set; }

        public string SeciliEkMalzemeler { get; set; }

        public override string ToString()
        {
            return UrunAdi;
        }
        public string ListeyeYazdir()
        {
            return $"{MenuAdedi}x {UrunAdi},{SeciliEkMalzemeler}{BoySecimiToString(BoySecimi)} ==> Toplam Fiyat : {FiyatHesapla().ToString("C2")}"; ;
        }

        public double FiyatHesapla( )
        {
            return (MenuAdedi * UrunFiyat * BoySecimi) + EkMalzemeFiyati;
        }

        private string BoySecimiToString(double boySecimi)
        {
            if (boySecimi == 1)
            {
                return "Küçük";
            }
            else if (boySecimi == 1.1)
            {
                return "Orta";
            }
            else
            {
                return "Büyük";
            }
        }
    }
}
