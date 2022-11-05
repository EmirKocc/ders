using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace boy_kilo_endeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen kilonuzu giriniz.");
            int kilo =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("lütfen boyunuzu giriniz.");
            double boy=Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("boy kilo endeksiniz:" + (kilo / (boy * boy)));
            double endeks = (kilo/(boy*boy));
            if (endeks < 18)
            {
                Console.WriteLine("zayıfsınız.");
                Console.ReadLine();
            }
            else if (endeks < 25 && endeks > 18)  
            {
                Console.WriteLine("ortalamasınız.");
                Console.ReadLine();
            }  
            else if (endeks > 25) 
            {
                Console.WriteLine("şişmansınız.");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
