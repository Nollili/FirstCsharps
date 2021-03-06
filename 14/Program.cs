using System;

namespace Kiválasztás
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiválasztás (20 db szám)");

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

            int oszthatoharommal_db = 0;
            int[] oszthatoak = new int[szamok.Length];
            for (int j = 0; j < szamok.Length; j++)
            {
                if (szamok[j] % 3 == 0)
                {
                    oszthatoharommal_db++;
                    oszthatoak[oszthatoharommal_db] = szamok[j];
                }
            }
            Console.WriteLine("{0} db 3-mal osztható szám van.", oszthatoharommal_db);
            Console.WriteLine();

            Console.WriteLine("A 3-mal osztható számok:");
            foreach (int szam in oszthatoak)
            {
                Console.WriteLine(szam);
            }

        }
    }
}
