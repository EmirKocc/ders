using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayı_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayıyı giriniz");
            string birinci_sayı = Console.ReadLine();
            int sayı1int = Convert.ToInt32(birinci_sayı);
            Console.WriteLine("ikinci sayıyı giriniz");
            string ikinci_sayı= Console.ReadLine();
            int sayı2int = Convert.ToInt32(ikinci_sayı);
            Console.WriteLine("sayıların toplamı" + (sayı1int + sayı2int));
            Console.ReadLine();

                }
    }
}
