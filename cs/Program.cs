using System;
using System.Linq;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {


            // Farenheit to celsius
            Console.WriteLine("Convert farenheit to celsius. Write a farenheit here: ");
            double farenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (farenheit - 32) * 5 / 9;
            Console.WriteLine("{0} °F = {1} °C", farenheit, celsius);


            // Hónap -> szám
            Console.WriteLine("Írj be egy hónapot (pl.: március) : ");
            string month = Console.ReadLine();

            switch (month)
            {
                case "január":
                    Console.WriteLine("1.");
                    break;
                case "február":
                    Console.WriteLine("2.");
                    break;
                case "március":
                    Console.WriteLine("3.");
                    break;
                case "április":
                    Console.WriteLine("4.");
                    break;
                case "május":
                    Console.WriteLine("5.");
                    break;
                case "június":
                    Console.WriteLine("6.");
                    break;
                case "július":
                    Console.WriteLine("7.");
                    break;
                case "augusztus":
                    Console.WriteLine("8.");
                    break;
                case "szeptember":
                    Console.WriteLine("9.");
                    break;
                case "október":
                    Console.WriteLine("10.");
                    break;
                case "november":
                    Console.WriteLine("11.");
                    break;
                case "december":
                    Console.WriteLine("12.");
                    break;
                default:
                    Console.WriteLine("Ilyen hónap nem létezik!");
                    break;
            }




            // A beolvasott értéknél kisebb négyzetszámok
            Console.WriteLine("Írjon be egy számot: ");
            byte negyzet = byte.Parse(Console.ReadLine());

            for (int i = 1; Math.Pow(i, 2) < negyzet; i++)
            {

                if (Math.Pow(i, 2) % i == 0)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }

            }


            // Négyzet kerete *-okból


            Console.Write("Add meg a négyzet magasságát:");
            byte magassag = Byte.Parse((Console.ReadLine()));

            for (int i = 1; i <= magassag; i++)
            {
                for (int j = 1; j <= magassag; j++)
                {
                    if (i == 1 || i == magassag || j == 1 || j == magassag)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }










            // Csúcsán álló háromszög
            Console.Write("A háromszög magassága legyen: ");
            byte haromszogmagassag = byte.Parse(Console.ReadLine());

            for (int sor = haromszogmagassag; sor > 0; sor--)
            {
                for (int j = 0; j < haromszogmagassag - sor + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < sor * 2 - 1; k++)
                {
                    Console.Write("o");
                }

                Console.WriteLine();
            }










            // Minimum keresés
            Console.WriteLine("Kérem a számokat, -1 a vége");
            int szam = Convert.ToInt32(Console.ReadLine());

            int min = szam;

            while (szam != -1)
            {
                if (min > szam)
                {
                    min = szam;
                }
                szam = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("A minimum {0} .", min);
       





            // 20 elemű valós/egész számok tömbje, átlag alatti/feletti értékek különválogatása
            int[] szamok = { 3, 7, 99, 36, 71, 25, 85, 10, 44, 68, 41, 38, 93, 56, 74, 79, 24, 3, 7, 9};

            int[] atlagFeletti = new int[szamok.Length];
            int[] atlagAlatti = new int[szamok.Length];

            int feletti = 0, alatti = 0;
            int osszeg = szamok.Sum();
            int atlag = osszeg / szamok.Length;

            for (int i = 0; i < szamok.Length; i++)
            {
                if ( szamok[i] > atlag)
                {
                    atlagFeletti[feletti] = szamok[i];
                    feletti++;
                } else 
                {
                    atlagAlatti[alatti] = szamok[i];
                    alatti++;
                }

            }

            Console.WriteLine(" {0} db szám", szamok.Length);
            Console.WriteLine("Számok összege: {0}", osszeg);
            Console.WriteLine("Számok átlaga: {0}", atlag);

            Console.WriteLine("Átlag felettiek: ");
            foreach (int atlagfel in atlagFeletti)
            {
                Console.WriteLine(atlagfel);
            }

            Console.WriteLine("Átlag alattiak: ");
            foreach (int atlagal in atlagAlatti)
            {
                Console.WriteLine(atlagal);
            }
            

        }
    }
}
