using System;

namespace Eldöntés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eldöntés");

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


            int db_prs = 0;
            int db_prtln = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    db_prs++;
                }
                else
                {
                    db_prtln++;
                }
            }
            Console.WriteLine("{0} db páros és {1} db páratlan szám található", db_prs, db_prtln);

        }
    }
}
