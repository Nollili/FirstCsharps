using System;

namespace Lineáris_keresés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear search");

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

            for (int j = 0; j < szamok.Length; j++)
            {
                if (szamok[j] % 3 == 0 && szamok[j] % 5 == 0)
                {
                    Console.WriteLine("Number which can be divided by 3 and 5 with no remainder: {0}", szamok[j]);

                    //Console.WriteLine(szamok[j]);
                }
            }
        }
    }
}
