using System;

namespace _2_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Kérem adjon meg egy egész számot!");

            szam = int.Parse(Console.ReadLine());
            
            if (szam < 0)
            {
                Console.WriteLine(szam + " negatív, kisebb mint 0!");
            }
            else if (szam < 10)
            {
                Console.WriteLine(szam + " kisebb mint 0!");
            }
            else
            {
                Console.WriteLine(szam + " nem negatív, és nem kisebb mint 10!");
            }
        }
    }
}
