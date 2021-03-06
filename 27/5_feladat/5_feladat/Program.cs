using System;

namespace _5_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, x;
            double atlag, osszeg = 0;


            Console.WriteLine("Hány adatot kíván feldolgozni?");
            n = int.Parse(Console.ReadLine());
            i = 0;

            while (i < n)
            {
                Console.WriteLine("Adja emg az " + (i + 1) + ". adatot: ");
                x = int.Parse(Console.ReadLine());
                osszeg += x;
                i++;
            }

            atlag = osszeg / n;
            Console.WriteLine("Az adatok összege : " + osszeg);
            Console.WriteLine("Az adatok átlaga : " + atlag);
        }
    }
}
