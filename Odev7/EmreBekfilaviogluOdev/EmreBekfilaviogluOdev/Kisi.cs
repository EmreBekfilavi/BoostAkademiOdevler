using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreBekfilaviogluOdev
{
    public class Kisi
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public int Yas { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }

        public string BilgileriYazdir()
        {
            return $"\nAd Soyad: {AdSoyad}" + $"\nTelefon : {Telefon}" + $"\nYas : {Yas}" + $"\nAdres: {Adres}";
        }
    }
}
