using System;

namespace _3_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy pozitív egész számot!");
            int szam = int.Parse(Console.ReadLine());
            bool igaze = true;

            if (szam <= 0)
            {
                Console.WriteLine("Hibás adat.");
            }
            else
            {
                if (szam % 3 == 0 && szam % 5 == 0 && szam % 2 == 0)
                {
                    Console.WriteLine(szam + " osztható 3-mal, 2-vel és 5-tel maradék nélkül");
                    igaze = true;
                    return;
                }
                if (szam % 3 == 0 && szam % 5 == 0)
                {
                    Console.WriteLine(szam + " osztható 3-mal és 5-tel maradék nélkül");
                    igaze = true;
                    return;
                }
                if (szam % 2 == 0)
                {
                    Console.WriteLine(szam + " osztható 2-vel maradék nélkül");
                    igaze = true;
                    return;
                }
                if (szam % 3 == 0)
                {
                    Console.WriteLine(szam + " osztható 3-mal maradék nélkül");
                    igaze = true;
                    return;
                }
                if (!igaze)
                {
                    Console.WriteLine(szam + " nem osztható 2-vel 3-mal és 5-tel maradék nélkül");
                    return;
                }
            }
        }
    }
}
