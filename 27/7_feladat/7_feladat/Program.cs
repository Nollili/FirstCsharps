using System;

namespace _7_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy valós számot!");
            var v = char.Parse(Console.ReadLine());

            if (v is char)
                Console.WriteLine(v + " char szam!");
            else if (v is int)
                Console.WriteLine(v + " int szam!");
            else if (v is float)
                Console.WriteLine(v + " float szam!");
            else if (v is double)
                Console.WriteLine(v + " double szam!");
            else
                Console.WriteLine(v + " egyeb tipus!");

        }
    }
}
