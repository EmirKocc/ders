using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 10000;
            int şifre = 3333;
            Console.WriteLine("şifreyi giriniz");
            int sifre = Convert.ToInt32(Console.ReadLine());
            if (sifre == şifre) 
             {
                Console.WriteLine("yapmak istediğiniz işlemi seçiniz");
                string seçim = Console.ReadLine();
                if (seçim =="1") 
                {
                    Console.WriteLine("hesap bakiyeniz:"+bakiye);

                }
                else if (seçim == "2") 
                {
                    Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                    int çekilecek_tutar=Convert.ToInt32(Console.ReadLine());
                    if (çekilecek_tutar < bakiye)
                    {
                        Console.WriteLine("kalan tutar" + (bakiye - çekilecek_tutar));
                    }
                    else
                    {
                        Console.WriteLine("bakiyeniz yetersiz");
                    }
                    else if (seçim == "3") 
                    {
                    }
                }


            }
         

        }
    }
}
