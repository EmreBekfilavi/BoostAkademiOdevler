int sayi, tahmin, fark;
int sayac = 0; 

Random rnd = new Random();

sayi = rnd.Next(1, 101);

while (true)
{
    Console.Write("Lütfen Tahminde Bulununuz:");
    tahmin = int.Parse(Console.ReadLine());

    sayac++;

    fark = Math.Abs(sayi - tahmin);

    if (fark == 0)
    {
        Console.WriteLine($"Tebrikler Tahmin Ettiğim Sayıyı {sayac}. Tahminde Bulmayı Başardınız!!!");
        break;
    }
    else if (fark < 5)
        Console.WriteLine("Çok Sıcak!!");
    else if (fark < 15)
        Console.WriteLine("Sıcak");
    else if (fark < 25)
        Console.WriteLine("Soğuk");
    else if (fark < 40)
        Console.WriteLine("Çok Soğuk!!");
    else
        Console.WriteLine("!!!Çok Başka Bir Mesafe Bu!!!");

}





