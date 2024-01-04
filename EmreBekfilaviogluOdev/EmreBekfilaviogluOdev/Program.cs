double sayi1, sayi2, sonuc;
char secim;

Console.WriteLine("Merhaba İşlem Yapmak İstediğiniz 2 Sayıyı Giriniz:");
sayi1 = double.Parse(Console.ReadLine());
sayi2 = double.Parse(Console.ReadLine());

Console.Write("Lütfen Yapmak İstediğiniz İşlemi Belirtiniz (+,-,*,/) : ");
secim = char.Parse(Console.ReadLine());

if (secim == '+')
{
    sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplama İşleminin Sonucu => " + sonuc);

}
else if (secim == '-')
{
    sonuc = sayi1 - sayi2;
    Console.WriteLine("Çıkarma İşleminin Sonucu => " + sonuc);
}
else if (secim == '*')
{
    sonuc = sayi1 * sayi2;
    Console.WriteLine("Çarpma İşleminin Sonucu => " + sonuc);
}
else
{
    if (sayi2 == 0)
    {
        Console.WriteLine("!!! Bölme İşleminde Bölüm 0 olamaz !!!");
    }
    else
    {
        sonuc = sayi1 / sayi2;
        Console.WriteLine("Bölme İşleminin Sonucu => " + sonuc);
    }

}
