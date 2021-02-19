using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, x;
            double atlag, osszeg = 0;
            Console.WriteLine("Hány adattal kíván dolgozni?");
            n = int.Parse(Console.ReadLine());
            //i = 0;

            /*while(i < n)
            {
                Console.WriteLine("Adja meg az " + (i + 1) + ". adatot!");
                x = int.Parse(Console.ReadLine());
                osszeg += x;
                i++;
            }*/

            /*do
            {
                Console.WriteLine("Adja meg az " + (i + 1) + ". adatot!");
                x = int.Parse(Console.ReadLine());
                osszeg += x;
                i++;
            } while (i < n);*/

            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Adja meg az " + (i + 1) + ". adatot!");
                x = int.Parse(Console.ReadLine());
                osszeg += x;
            }
            atlag = osszeg / n;
            Console.WriteLine("Az adatok osszege: " + osszeg);
            Console.WriteLine("Az adatok atlaga: " + atlag);

            Console.ReadKey();
        }
    }
}
