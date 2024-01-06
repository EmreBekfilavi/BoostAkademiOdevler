string renkTercihi;
double carpimTablosu;
char icecekTercihi;

// Ödev2-1

Console.Write("Lütfen Renk Tercihinizi Belirtiniz (Mavi,Sarı,Kırmızı,Yeşil) == ");
renkTercihi = Console.ReadLine();

if (renkTercihi == "Mavi")
    Console.BackgroundColor = ConsoleColor.Blue;
else if (renkTercihi == "Sarı")
    Console.BackgroundColor = ConsoleColor.Yellow;
else if (renkTercihi == "Kırmızı")
    Console.BackgroundColor = ConsoleColor.Red;
else if (renkTercihi == "Yeşil")
    Console.BackgroundColor = ConsoleColor.Green;
else
    Console.WriteLine("!!!Geçerli Bir Renk Girilmediği İçin Değişiklik Yapamıyorum!!!");

// Ödev2-2 

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        carpimTablosu = i * j;
        Console.WriteLine($"{i} x {j} = {carpimTablosu}");
    }
}

// If ile İçecek Tercihi

Console.Write("Lütfen İçecek Tercihini Giriniz (C, L, K) == ");
icecekTercihi = char.Parse(Console.ReadLine());

if (icecekTercihi == 'C')
    Console.WriteLine("Çay Seçtiğiniz İçin Teşekkür Ederiz");
else if (icecekTercihi == 'L')
    Console.WriteLine("Limonata Seçtiğiniz İçin Teşekkür Ederiz");
else if (icecekTercihi == 'K')
    Console.WriteLine("Kahve Seçtiğiniz İçin Teşekkür Ederiz");
else
    Console.WriteLine("!!!Geçerli Bir İçecek Tercihinde Bulunmadınız!!!");


// Switch İle İçecek Tercihi 

char switchTercih;

Console.Write("Lütfen İçecek Tercihini Giriniz (C, L, K) == ");
switchTercih = char.Parse(Console.ReadLine());


switch (switchTercih)
{
    case 'C':
    case 'c':
        Console.WriteLine("Çay Seçtiğiniz İçin Teşekkür Ederiz");
        break;

    case 'L':
    case 'l':
        Console.WriteLine("Limonata Seçtiğiniz İçin Teşekkür Ederiz");
        break;

    case 'K':
    case 'k':
        Console.WriteLine("Kahve Seçtiğiniz İçin Teşekkür Ederiz");
        break;

    default:
        Console.WriteLine("!!!Geçerli Bir İçecek Tercihinde Bulunmadınız!!!");
        break;
}