int[] asalCarpanlar = new int[10];
int sayi;
bool kontrol = true;
int index = 0;

Console.Write("Asal Çarpanlarını Merak Ettiğiniz Sayıyı Giriniz: ");
sayi = int.Parse(Console.ReadLine());

for (int i = 2;  i < sayi; i++)
{
    if(sayi % i == 0)
    {
        for(int j = 2; j<i; j++)
        {
            if(i % j == 0)
            {
                kontrol = false;
                break;
            }

            kontrol = true;

        }

        if (kontrol)
        {
            asalCarpanlar[index] = i;
            index++;
        }
    }
}

Console.WriteLine("Asal Çarpanlar\n------------");

foreach (int asal in asalCarpanlar)
{
    Console.WriteLine(asal);
}
