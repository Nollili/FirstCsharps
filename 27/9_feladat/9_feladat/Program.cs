using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_feladat
{

    class OsztalyozOsztaly
    {
        public static int Osztalyoz(int pontszam)
        {
            int erdemjegy = 0;
            if (pontszam >= 0 && pontszam <= 100)
            {
                if (pontszam >= 90) erdemjegy = 5;
                else if (pontszam >= 70) erdemjegy = 4;
                else if (pontszam >= 60) erdemjegy = 3;
                else if (pontszam >= 50) erdemjegy = 2;
                else erdemjegy = 1;
            }
            else
            {
                Console.WriteLine("Hibas adatot adott meg!");
            }
            return erdemjegy;
        }

        public static void ErdemjegySzovegesen(int jegy)
        {
            if (jegy >= 1 && jegy <= 5)
            {
                switch (jegy)
                {
                    case 1:
                        Console.WriteLine("Erdemjegy : elegtelen");
                        break;
                    case 2:
                        Console.WriteLine("Erdemjegy : elegseges");
                        break;
                    case 3:
                        Console.WriteLine("Erdemjegy : kozepes");
                        break;
                    case 4:
                        Console.WriteLine("Erdemjegy : jo");
                        break;
                    case 5:
                        Console.WriteLine("Erdemjegy : jeles");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Hibas jegye adott meg!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int dolgozatPont = 0, erdemjegy = 0;
            do
            {
                Console.WriteLine("A dolgozat pontszama : ");
                dolgozatPont = int.Parse(Console.ReadLine());
            } while (dolgozatPont < 0 || dolgozatPont > 100);
            erdemjegy = OsztalyozOsztaly.Osztalyoz(dolgozatPont);
            OsztalyozOsztaly.ErdemjegySzovegesen(erdemjegy);
        }
    }
}
