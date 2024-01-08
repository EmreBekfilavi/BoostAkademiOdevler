int sayi, toplam;

toplam = 0;

Console.Write("Lütfen Kaça Kadar İşlem Yapmak İstediğinizi Belirtiniz: ");
sayi = int.Parse(Console.ReadLine());

for (int i = 1; i <= sayi; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine("Çıkar");
        toplam = toplam - i;
    }
    else
    {
        Console.WriteLine("Topla");
        toplam += i;
    }
}

Console.WriteLine($"İstediğiniz İşlemin Sonucu => {toplam}");