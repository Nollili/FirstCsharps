using System;

namespace _4_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1, szam2;
            string muvelet;

            Console.WriteLine("Kérem adja meg az első számot: ");
            szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem adja meg az első számot: ");
            szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem adja meg az elvégzendő műveleti jelet ( +  -  *  / )");
            muvelet = Console.ReadLine();

            switch (muvelet)
            {
                case "+":
                    Console.WriteLine(szam1 + " és " + szam2 + " összege: " + (szam1 + szam2));
                    break;
                case "-":
                    Console.WriteLine(szam1 + " és " + szam2 + " különbsége: " + (szam1 - szam2));
                    break;
                case "*":
                    Console.WriteLine(szam1 + " és " + szam2 + " szorzata: " + (szam1 * szam2));
                    break;
                case "/":
                    Console.WriteLine(szam1 + " és " + szam2 + " hányadosa: " + (szam1 / szam2));
                    break;
                default:
                    Console.WriteLine("Hibás műveletet adott meg");
                    break;
            }
        }
    }
}
