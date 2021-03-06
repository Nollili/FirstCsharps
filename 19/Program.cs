using System;

namespace masodikfeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verebélyi Noémi Lili, második feladat:

            //a, 71 elemű tömb, a [0, 127] zárt intervallumról
            Random random = new Random();
            int[] szamok = new int[71];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(0, 128);
            }

            //b, összes elem átlaga
            Console.WriteLine();
            Console.WriteLine("Átlag: ");
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }
            double atlag = (double)osszeg / szamok.Length;
            Console.WriteLine("A tömb elemeinek száma {0} ", szamok.Length);
            Console.WriteLine("A tömb elemeinek összege {0} ", osszeg);
            Console.WriteLine("A tömb átlaga {0} ", atlag);
            Console.WriteLine();


            //c, 50-nél kisebb érték keresése
            int db_kisebb = 0;
            for (int k = 0; k < szamok.Length; k++)
            {
                if (szamok[k] < 50)
                {
                    db_kisebb++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} db 50-nél kisebb szám van a tömbben.", db_kisebb);


            //d, a legnagyobb és legkisebb érték
            Console.WriteLine();
            int maximum = szamok[0];
            for (int i = 0; i < szamok.Length; i++)
            {
                if (maximum < szamok[i])
                {
                    maximum = szamok[i];
                }
            }
            Console.WriteLine("A tömb legnagyobb értéke: {0}.", maximum);

            int minimum = szamok[0];
            for (int i = 0; i < szamok.Length; i++)
            {
                if (minimum > szamok[i])
                {
                    minimum = szamok[i];
                }
            }
            Console.WriteLine("A tömb legkisebb értéke: {0}.", minimum);


            //e, 120 vagy annál nagyobb érték
            Console.WriteLine();
            bool nagyobb = false;
            int db_nagyobb = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] >= 120)
                {
                    nagyobb = true;
                    db_nagyobb++;
                }
            }
            if (nagyobb)
            {
                Console.WriteLine("Van 120, vagy annál nagyobb érték, {0} db.", db_nagyobb);
            }

            Console.WriteLine();
            Console.WriteLine();

            //f, legnagyobb érték indexe
            int maxIndex = Array.IndexOf(szamok, maximum);
            Console.WriteLine("A legnagyobb érték ({0}) indexe a tömbben: {1}.", maximum, maxIndex);

            Console.WriteLine();
            Console.WriteLine();

            //g, elemek, amelyek az [53; 79] zárt intervallumba esnek
            int db_tomb = 0;
            int[] tomb = new int[szamok.Length];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] >= 53 && szamok[i] <= 79)
                {
                    tomb[db_tomb] = szamok[i];
                    db_tomb++;
                }
            }
            Console.WriteLine("Elemek, amelyek az [53; 79] zárt intervallumba esnek: ");

            foreach (var k in tomb)
            {
                if (k != 0)
                {
                    Console.Write("{0} ", k);
                }

            }

            //h, [53; 79] közötti elemek növekvő sorrendbe

            int temp;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        temp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[53; 79] közötti elemek növekvő sorrendben:");
            foreach (var j in tomb)
            {
                if (j != 0)
                {
                    Console.Write("{0} ", j);
                }

            }

            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine();




            // Ellenőrzés
            Console.WriteLine("Ellenőrzésképp az összes elem + összes elem sorbarendezve:");
            Console.WriteLine("A 71 elemű tömb tagjai:");
            foreach (int szam in szamok)
            {
                Console.Write("{0} ", szam);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("A tömb elemei sorrendben: ");
            int csere;
            for (int i = 0; i < szamok.Length; i++)
            {
                for (int j = i + 1; j < szamok.Length; j++)
                {
                    if (szamok[i] > szamok[j])
                    {
                        csere = szamok[i];
                        szamok[i] = szamok[j];
                        szamok[j] = csere;
                    }
                }
            }

            foreach (var item in szamok)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
