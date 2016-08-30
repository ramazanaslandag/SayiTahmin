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
                Console.Clear();
                int uretilenSayi = gen.Next(101);
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
                   
                }
                Console.WriteLine("Tebrikler, {1} denemede doğruyu buldunuz sayı {0} olarak üretilmişti.", uretilenSayi, deneme);
                Console.Write("Yeniden oynamak ister misiniz? (e/h):");
                istek = Console.ReadLine();
            } while (istek.ToLower()=="e");
          
        }
    }
}
