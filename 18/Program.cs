using System;
using System.Linq;

namespace maiora
{
    class Program
    {
        static void Main(string[] args)
        {


            //1 Tartály:
            const double pi = Math.PI;

            Console.Write("Magasság: ");
            double magassag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Átmérő: ");
            double atmero = Convert.ToDouble(Console.ReadLine());

            double sugar = atmero / 2;
            double felulet = (2 * sugar * sugar * pi + magassag * 2 * pi * sugar);

            double doboz_db = felulet / 2;

            Console.WriteLine("{0:F2} doboz festék kell", doboz_db);
            Console.WriteLine($"{doboz_db:F2} doboz festék kell");


            //2 Páratlan számok
            Console.WriteLine("Alsó: ");
            int also = int.Parse(Console.ReadLine());

            Console.WriteLine("Felső: ");
            int felso = int.Parse(Console.ReadLine());

            if (also > felso) //alsó és felső helyet cserél 
            {
                int temp = also;
                also = felso;
                felso = temp;
            }

            for (int i = also; i < felso; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i} ");
                }
            }

            for (int i = also; i < felso; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }



            //3 nem prímek
            Console.Write("Határ: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("A határig előforduló nemprímek.: ");
            Console.Write("1 ");

            for (int i = 2; i < szam; i++)
            {
                bool prim = true;

                for (int j = 2; j < i; j++) //csak önmagával osztható
                {
                    if (i % j == 0)
                    {
                        prim = false;
                    }
                }

                if (!prim)
                {
                    Console.Write($"{i} ");
                }
            }


            //4 Utolsó öt átlaga
            double[] szamok = new double[5];

            Console.Write("Írj be számokat, és legyen 0 a vége:");
            double beolvasas = double.Parse(Console.ReadLine());

            int i = 0;
            while (beolvasas != 0)
            {
                szamok[i] = beolvasas;
                i = (i + 1) % 5; //4 után megint 0 -> 0 1 2 3 4 0 1 2 3 4 0 1 2 3 4 0...
                Console.Write("Írj be számokat, és legyen 0 a vége:");
                beolvasas = Double.Parse(Console.ReadLine());
            }

            double osszeg = szamok.Sum();
            double atlag = szamok.Average();
            Console.WriteLine($"Az utolsó 5 szám összege: {osszeg}");
            Console.WriteLine($"Az utolsó 5 szám átlaga: {atlag}");




            //5 Összeg max nélkül
            byte[] szamok = new byte[5];
            byte osszeg = 0;
            Console.WriteLine("Adj meg 5db számot: ");
            
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = Byte.Parse(Console.ReadLine());
            }

            foreach (byte szam in szamok)
            {
                osszeg += szam;
            }

            byte maximum;
            maximum = szamok.Max();
            byte eredmeny = (byte)(osszeg - maximum);
            Console.WriteLine($"Az összeg: {eredmeny}");



            //6 Számkitaláló
            Random rand = new Random();
            int szamom = rand.Next(0, 101); //felső határ mindig plusz 1
            Console.WriteLine("Gondoltam egy számra 1 és 100 között.. Találd ki melyikre!");

            int elet = 5;
            int tipp = -1;
            for (int i = 0; i < elet && szamom != tipp; i++)
            {
                Console.Write("Tipp: ");
                tipp = int.Parse(Console.ReadLine());
                if (tipp != szamom)
                {
                    Console.Write("Nem sikerült, próbáld újra.");
                }
                else
                {
                    Console.Write("Sikerült, gratulálok!");
                }
            }




            Random rando = new Random();
            int jatekospont = 0;
            int szamitogeppont = 0;
            char jatekostipp;
            char szamitogeptipp;
            Console.WriteLine("Kő (k), Papír (p), Olló (o) vagy vége (v) : ");

            //7eső tipp a játékostól
            Console.Write("Szerinted: ");
            jatekostipp = Char.Parse(Console.ReadLine());

            while (jatekostipp != 'v')
            {
                int geptipp_szam = rando.Next(0, 3);
                if (geptipp_szam == 0)
                {
                    szamitogeptipp = 'k';
                }
                else if (geptipp_szam == 1)
                {
                    szamitogeptipp = 'p';
                }
                else
                {
                    szamitogeptipp = 'o';
                }
                Console.WriteLine($"Szerintem: {szamitogeptipp}");

                //összehasonlítás, pontok
                if ((jatekostipp == 'k' && szamitogeptipp == 'o') || (jatekostipp == 'p' && szamitogeptipp == 'k') || (jatekostipp == 'o' && szamitogeptipp == 'p'))
                {
                    jatekospont++;
                    Console.WriteLine("Ezt te nyerted.");
                }
                else if ((szamitogeptipp == 'k' && jatekostipp == 'o') || (szamitogeptipp == 'p' && jatekostipp == 'k') || (szamitogeptipp == 'o' && jatekostipp == 'p'))
                {
                    szamitogeppont++;
                    Console.WriteLine("Ezt én nyertem.");
                }
                else
                {
                    Console.WriteLine("Senki nem kap pontot.");
                }
                Console.Write("Szerinted: ");
                jatekostipp = Char.Parse(Console.ReadLine());
            }

            if (jatekospont > szamitogeppont)
            {
                Console.WriteLine($"Most te nyerted a játszmát. ({jatekospont} - {szamitogeppont}");
            }
            else if (jatekospont < szamitogeppont)
            {
                Console.WriteLine($"Ezt a játszmát én nyertem. ({jatekospont} - {szamitogeppont})");
            }
            else
            {
                Console.WriteLine($"Ez döntetlen lett. ({jatekospont} - {szamitogeppont})");
            }
        }
    }
}

