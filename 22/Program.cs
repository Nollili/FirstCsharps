using System;

namespace Összegzés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Összegzés");

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
            int osszeg = 0;
            for (int j = 0; j < szamok.Length; j++)
            {
                osszeg += szamok[j];
            }
            Console.WriteLine("A számok összege: {0}", osszeg);

        }
    }
}
