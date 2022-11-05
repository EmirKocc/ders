using System;

namespace geçti_kaldı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz isminizi ve soyisminizi aşağıdaki alannlara doldurunuz ardından not bilgilerinizi giriniz sistem otomatik olarak geçip geçmediğinizi size söyleyecek.");
            Console.WriteLine("isminizi ilgili alandaki boşluğa yazınız");
            string isim = Console.ReadLine();
            Console.WriteLine("soyisminizi iligili alandaki boşluğa yazınız");
            string soyisim = Console.ReadLine();
            Console.WriteLine("merhaba " + (isim + soyisim));
            Console.WriteLine("dersten geçip geçmediğinizi sotgulamamız için not bilgilerinizi girmeniz gerekmetedir ");
            Console.WriteLine("not bilgisiyle ilgili alanları doldurunuz,");
            Console.WriteLine("ilk sınav sonucunuzu giriniz:");
            string not = Console.ReadLine();
            int puan = Convert.ToInt32((string)not);
            if (puan > 50) 
            {
                Console.WriteLine("tebrikler"+(isim+soyisim));
            }
            else 
            {
                Console.WriteLine("sıkı çalışın ");
            }
            Console.WriteLine("ikinci sınav noyunuzu da öğrenmemiz gerek");
            string not2 = Console.ReadLine();
            int puan2 = Convert.ToInt32((string)not2);
            if (puan2 > 50) 
            {
                Console.WriteLine("tebrikler"+(isim+soyisim));
            }
            else 
            {
                Console.WriteLine("sıkı çalışın" +
                    "");
            }
            Console.WriteLine("sınav geçme notunuz 50'dir");
            Console.WriteLine("notunuz" + (puan + puan2));
            string toplam = (not + not2);
            int toplamlar = Convert.ToInt32(puan + puan2);
            string ortalama=Convert.ToString(toplamlar/2);
            Console.WriteLine("ortalamanız"+ortalama);
            int ortalamaint=Convert.ToInt32((string)ortalama);
            if (ortalamaint > 50)
            {
                Console.WriteLine("öğrenci başarılı olmuştur");
                Console.WriteLine( "tebrikler");
            }
            else { Console.WriteLine("öğrenci kalmıştır"); }
            Console.ReadLine();










        }
    }
}
