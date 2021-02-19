using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1, szam2;
            string muveletiJel;

            Console.WriteLine("Kerem adja meg az elso szamot: ");
            szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kerem adja meg az masodik szamot: ");
            szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem adja meg a műveleti jelet: ");
            muveletiJel = Console.ReadLine();

            switch (muveletiJel)
            {
                case "+":
                    Console.WriteLine(szam1 + " és " + szam2 + " osszege : " + (szam1 + szam2));
                    break;
                case "-":
                    Console.WriteLine(szam1 + " és " + szam2 + " kulonbsege : " + (szam1 - szam2));
                    break;
                case "*":
                    Console.WriteLine(szam1 + " és " + szam2 + " szorzata : " + (szam1 * szam2));
                    break;
                case "/":
                    Console.WriteLine(szam1 + " és " + szam2 + " hanyadosa : " + (szam1 / szam2));
                    break;
                default:
                    Console.WriteLine("Hibas muveleti jel!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
