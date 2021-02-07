using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] szamok = new int[20];
            int[] prs = new int[szamok.Length];
            int[] prtln = new int[szamok.Length];

            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(100);
            }

            int db_prs = 0, db_prtln = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    prs[db_prs] = szamok[i];
                    db_prs++;
                }
                else
                {
                    prtln[db_prtln] = szamok[i];
                    db_prtln++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Párosak: ");
            foreach (int i in prs)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
            Console.WriteLine("Páratlanok: ");
            foreach (int k in prtln)
            {
                Console.Write("{0} ", k);
            }
        }
    }
}
