using System;

namespace osztalyzat
{

    class OsztalyozOsztaly
    {

        public static int Osztályoz(int pontszam)
        {
            int erdemjegy = 0;
            if (pontszam > 0 && pontszam <= 100)
            {
                if (pontszam >= 90)
                {
                    erdemjegy = 5;
                }
                else if (pontszam >= 70)
                {
                    erdemjegy = 4;
                }
                else if (pontszam >= 60)
                {
                    erdemjegy = 3;
                }
                else if (pontszam >= 50)
                {
                    erdemjegy = 2;
                }
                else
                {
                    erdemjegy = 1;
                }
            }
            else
            {
                Console.WriteLine("Hibás adat került bevitelre!");
            }
            return erdemjegy;
        }

        public static void SzovegesJegy(int jegy)
        {
            if (jegy >= 1 && jegy <= 100)
            {
                switch (jegy)
                {
                    case 1:
                        Console.WriteLine("Érdemjegy: elégtelen.");
                        break;
                    case 2:
                        Console.WriteLine("Érdemjegy: elégséges.");
                        break;
                    case 3:
                        Console.WriteLine("Érdemjegy: közepes.");
                        break;
                    case 4:
                        Console.WriteLine("Érdemjegy: jó.");
                        break;
                    case 5:
                        Console.WriteLine("Érdemjegy: jeles.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Hibás adat került bevitelre!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int pontszam = 0, erdemjegy = 0;
            

            do
            {
                Console.WriteLine("A dolgozat pontszáma: ");
                pontszam = int.Parse(Console.ReadLine());
            } while (pontszam < 0 || pontszam > 100);
            
            erdemjegy = OsztalyozOsztaly.Osztályoz(pontszam);
            OsztalyozOsztaly.SzovegesJegy(erdemjegy);


        }
    }
}
