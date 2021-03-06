using System;

namespace _6_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy szöveget, kiíratom betűnként!");
            string s = Console.ReadLine();
            foreach( char c in s)
            {
                Console.WriteLine(c);
            }
        }
    }
}
