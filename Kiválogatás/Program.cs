using System;

namespace Kiválogatás
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiválogatás");

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


            int[] parosok = new int[szamok.Length];
            int db_prs = 0;
            for (int j = 0; j < szamok.Length; j++)
            {
                if (szamok[j] % 2 == 0)
                {
                    parosok[db_prs] = szamok[j];
                    db_prs++;
                }
            }
            Console.WriteLine("A páros számok a tömbből: ");
            foreach (int szam in parosok)
            {
                Console.WriteLine(szam);
            }
        }
    }
}
