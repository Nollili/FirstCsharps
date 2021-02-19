using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pelda
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Kérlek adj meg egy egész számot!");
            szam = int.Parse(Console.ReadLine());
            if(szam < 0)
                Console.WriteLine(szam + " negatív szám!");
            else if(szam < 10)
                Console.WriteLine(szam + " kisebb mint 10!");
            else
                Console.WriteLine(szam + " nem kisebb mint tíz, és nem negatív!");

            Console.ReadKey();
        }
    }
}
