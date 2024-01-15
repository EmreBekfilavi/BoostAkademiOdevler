namespace EmreBekfilaviogluOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aracİsmi;
            int yas, motorHacmi;

            Console.Write("Arabanın Tipini Belirtiniz (Binek veya Ticari): ");
            aracİsmi = Console.ReadLine();

            Console.Write("Arabanın Yaşını Giriniz: ");
            yas = int.Parse(Console.ReadLine());

            Console.Write("Arabanın Motor Hacmini Giriniz: ");
            motorHacmi = int.Parse(Console.ReadLine());

            Console.WriteLine("Arabanız İçin Ödemeniz Gereken Vergi == "
                + VergiHesapla(aracİsmi,yas,motorHacmi));
        }

        static double VergiHesapla(string type, int age, int engineCapacity)
        {
            double totalTax =0;

            if (type == "Ticari")
            {
                totalTax = 1500;

                totalTax = totalTax * YasHesabi(age) * MotorHacimHesabi(engineCapacity);

            }   
            else if (type == "Binek")
            {
                totalTax = 1000;

                totalTax = totalTax * YasHesabi(age) * MotorHacimHesabi(engineCapacity);
            }
                
            return totalTax ;

        }

        static double YasHesabi(int age)
        {
            if (age >= 1 && age <= 3)
                return 1.75;
            else if (age >= 4 && age <= 7)
                return 1.5;
            else return 1.25;

        }

        static double MotorHacimHesabi(int motorHacmi)
        {
            if (motorHacmi >= 0 && motorHacmi <= 1000)
                return 2;
            else if ((motorHacmi >= 1001 && motorHacmi <= 1600))
                return 2.5;
            else if (motorHacmi >= 1601 && motorHacmi <= 2000)
                return 3;
            else
                return 4;
        }
    }
}
