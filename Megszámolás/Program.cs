using System;

namespace Megszámolás
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Megszámolás");

            Random random = new Random();
            int[] szamok = new int[20];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1, 100);
            }

            foreach (int szam in szamok)
            {
                Console.WriteLine(szam);
            }
            Console.WriteLine();
            Console.WriteLine();

            int db = 0;
            for (int j = 0; j < szamok.Length; j++)
            {
                if ( szamok[j] % 5 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("Van {0} db szám, ami osztható 5-tel.", db);
        }
    }
}
