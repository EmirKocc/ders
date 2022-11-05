using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen notunuzu giriniz:");
            string not = Console.ReadLine();
            int puanint = Convert.ToInt32(not);
            if (puanint > 55)
               
            {
                Console.WriteLine("öğrenci geçmiştir");

            }
            else
            {
                Console.WriteLine("öğrenci kalmıştır");

            }
            Console.ReadLine(); 


        }
    }
}
