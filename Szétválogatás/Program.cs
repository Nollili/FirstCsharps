using System;

namespace Szétválogatás
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szétválogatás");

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

            int[] ketto = new int[szamok.Length];
            int[] harom = new int[szamok.Length];
            int[] semmi = new int[szamok.Length];

            int db_ketto = 0;
            int db_harom = 0;
            int db_semmi = 0;

            for (int j = 0; j < szamok.Length; j++)
            {
                if (szamok[j] % 2 == 0)
                {
                    ketto[db_ketto] = szamok[j];
                    db_ketto++;
                }
                else if (szamok[j] % 3 == 0)
                {
                    harom[db_harom] = szamok[j];
                    db_harom++;
                }
                else
                {
                    semmi[db_semmi] = szamok[j];
                    db_semmi++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Páros számok a tömbben: ");
            foreach (var k in ketto)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();
            Console.WriteLine("3-mal osztható számok a tömbben: ");
            foreach (var h in harom)
            {
                Console.WriteLine(h);
            }

            Console.WriteLine();
            Console.WriteLine("Egyebek:");
            foreach (var s in semmi)
            {
                Console.WriteLine(s);
            }




        }
    }
}
