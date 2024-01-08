int sayi;
string durum;
int toplam;


do
{
    Console.Write("Mükemmelliğini Merak Ettiğiniz Sayıyı Giriniz: ");
    sayi = int.Parse(Console.ReadLine());

    toplam = 0;

    for(int i = 1;  i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam = toplam + i;
        }
    }

    if (toplam == sayi)
        Console.WriteLine("Girdiğinizi Sayı Mükemmel Sayıdır");
    else
        Console.WriteLine("Girdiğiniz Sayı Mükemmel Değildir");

    Console.Write("Yeni Bir Sayı Girmek İstiyor Musunuz? => ");
    durum = Console.ReadLine();

} while (durum == "Evet");


