using System;

namespace _1_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy egész számot és megmondom osztható-e 2-vel.");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A " + szam + " osztható 2 - vel.");
                return;
                Console.ReadKey();
            }
            Console.WriteLine("A " + szam + " nem osztható maradék nélkül 2-vel.");
            return;
        }
    }
}
