using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            
            string istek = "";
            do
            {
                Console.Clear();//önceki bilgileri sil
                int uretilenSayi = gen.Next(101);//pc sayı üretsin
                // Console.WriteLine(uretilenSayi);
                Console.Write("Tahmininiz:");
                int kullaniciTahmini = int.Parse(Console.ReadLine());
                int deneme = 1;
                while (kullaniciTahmini != uretilenSayi)
                {
                    deneme++;
                    if (kullaniciTahmini > uretilenSayi)
                    {
                        Console.Write("Daha küçük bir sayı girişi yapınız:");
                        kullaniciTahmini = int.Parse(Console.ReadLine());
                    }
                    else if (kullaniciTahmini < uretilenSayi)
                    {
                        Console.Write("Daha büyük bir sayı girişi yapınız:");
                        kullaniciTahmini = int.Parse(Console.ReadLine());
                    }
                    //sayıların eşitliği döngünün sonlanmasını sağlar bu nedenle bir else bloğuyla bunun kontrol edilmesine gerek yok
                }
                Console.WriteLine("Tebrikler, {1} denemede doğruyu buldunuz sayı {0} olarak üretilmişti.", uretilenSayi, deneme);
                Console.Write("Yeniden oynamak ister misiniz? (e/h):");
                istek = Console.ReadLine();
            } while (istek.ToLower()=="e");
           // Console.ReadLine();


            //challenge: 
            /*
             ogs:30
             banka hesabı:50
             geçiş ücreti=3
             * ogs de 20nin altına düştüğüm zaman bankada varsa 20 br ogs ye aktarılsın. yoksa, kalanın tamamı ogs ye aktarılsın.
             * kaç geçiş yaptım, bankada kalan, ogs de kalan
             */
            //Console.Beep();
        }
    }
}
