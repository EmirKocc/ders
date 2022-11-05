using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oluyo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 100000;
            int şifre = 3169;
            Console.WriteLine("şifreyi giriniz:");
            string sifre=Console.ReadLine();
            int x = Convert.ToInt32(sifre);
            if (x == şifre)
            {
                Console.WriteLine("bankamıza hoşgeldiniz yapmak istediğiniz işlemi seçiniz.");
                string seçim = Console.ReadLine();
                if (seçim == "1")
                {
                    Console.WriteLine("hesaptaki bakiyeniz:" + bakiye);
                    Console.ReadLine();
                }
                else if (seçim == "2")
                {
                    Console.WriteLine("çekmek istediğiniz tutarı giriniz:");
                    int çekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (çekilecek_tutar <= bakiye)
                    {
                        Console.WriteLine("kalan bakiye:" + (bakiye - çekilecek_tutar));
                    }
                    else
                    {
                        Console.WriteLine("bakiyenizden yüksek para çekemezsiniz.");
                        Console.ReadLine();
                    }
                }
                else if (seçim == "3")
                {
                    Console.WriteLine("yatırmak istediğiniz tutarı giriniz.");
                    int yatırılacak_tutar = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("yeni bakiyeniz:" + (bakiye + yatırılacak_tutar));
                }
                else if (seçim == "q")               
                {
                    Console.WriteLine("hesabınızdan çıkış yapılıyor...");
                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir kod giriniz.");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("geçersiz hesap bilgileri, lütfen daha sonra tekrar deneyin.");
                Console.ReadLine();
            }


           



        }

        
    }
}
