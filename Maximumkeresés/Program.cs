using System;

namespace Maximumkeresés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximumkeresés");

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

            int max = 0;
            for (int j = 0; j < szamok.Length; j++)
            {
                if (szamok[j] > max)
                {
                    max = szamok[j];
                }
            }
            Console.WriteLine("A legnagyobb szám a tömbben a {0}", max);
        }
    }
}
