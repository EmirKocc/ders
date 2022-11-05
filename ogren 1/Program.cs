using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogren_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 21;
            int sayı3 = 31;
            int sonuc = sayı1 + sayı3;
            Console.WriteLine(sonuc);
            int sayı31 = 31;
            int sayı21 = 21;
            int sonuc2 = (sayı31 * sayı21);
            Console.WriteLine(sonuc2);
            int keko = 2;
            int keko2 = 2;
            bool kontrolet = keko == keko2;
            Console.WriteLine(kontrolet);
            int yas = 19;
            int yas2 = 17;
            bool sonuc3 = yas <= yas2;
            Console.WriteLine(sonuc3);
            bool kontrolett = sayı1 == sayı3 && sayı21 <= sayı31;
            Console.WriteLine(kontrolett);
            bool a = true;
            Console.WriteLine(!a);
            int ada = 4;
            ada += 9;
            Console.WriteLine("adanın degeri"+ada);

            Console.ReadLine();

            
        }
    }
}
