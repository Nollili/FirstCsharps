using System;

namespace today
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Celsius Farenheit converter
            Console.WriteLine("Convert celsius to farenheit. Write a celsius here: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double farenheit = celsius * 1.8 + 32;

            Console.WriteLine("{0} °C = {1} °F", celsius, farenheit);


            Console.WriteLine("Convert farenheit to celsius. Write a farenheit here: ");
            double farenheit2 = Convert.ToDouble(Console.ReadLine());

            double celsius2 = (farenheit2 - 32) * 5/9;

            Console.WriteLine("{0} °F = {1} °C", farenheit2, celsius2);
            


            
            Console.Write("A vonal hossza legyen: ");
            byte szám = byte.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < szám; i ++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            


            
            Console.Write("A négyzet mérete legyen: ");
            byte szam = byte.Parse(Console.ReadLine());


            for (int i = 0; i < szam; i++)
            {
                for (int j = 0; j < szam; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(); //Console.Write("\n);
            }
            


            
            Console.Write("A háromszög magassága legyen: ");
            byte magassag = byte.Parse(Console.ReadLine());


            for (int sor = 0; sor < magassag; sor++)
            {

                for (int j = 0; j < magassag - sor - 1 ; j++)  // Szóközök
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < sor * 2 + 1; k++)  // o karakterek
                {
                    Console.Write("o");
                }
                Console.WriteLine();
            }
            


            
            // Összegzés
            Console.WriteLine("Kérem a számokat, -1 a vége");
            int szam = Convert.ToInt32(Console.ReadLine());

            int osszeg = 0;
            while (szam != -1)
            {
                osszeg += szam; 
                szam = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Összeg : {0}", osszeg);
            

            
            // Számlálás, osztók száma
            Console.Write("kérem a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            int darab = 0;
            for (int oszto = 1; oszto <= szam; oszto++)
            {
                if( szam % oszto == 0)
                {
                    darab++;  //darab +=1
                }
            }
            Console.WriteLine("Összesen {0} osztója van.", darab);
            

            
            // Maximum keresése
            Console.WriteLine("Kérem a számokat, -1 a vége");
            int szam = Convert.ToInt32(Console.ReadLine());

            int maximum = szam;

            while (szam != -1)
            {
                if (maximum < szam)
                {
                    maximum = szam;
                }
                szam = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("A maximum {0} .", maximum);
            

            
            // Eldöntés tétele
            Console.Write("kérem a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            bool vanoszto = false;
            int oszto = 2;
            while (oszto < szam)
            {
                if (szam % oszto == 0)
                {
                    vanoszto = true;
                    break;
                }
                oszto++;
            }
            if (vanoszto)
            {
                Console.WriteLine(" A {0} nem prím.", szam);
            }
            else
            {
                Console.WriteLine(" A {0} prím.", szam);

            }
            


            
            string[] fruits = { "alma", "szölö", "eper" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            


            
            double[] szamok = new double[5];

            // értékek beolvasása
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("{0}. szám: ", i + 1);
                szamok[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            foreach (double szam in szamok)
            {
                Console.WriteLine(szam);
            }

            Console.WriteLine();
            for (int i = szamok.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}. szám: {1}", i + 1, szamok[i]);
            }
            


            
            //Szétválogatás két tömbre
            int[] szamok = { 3, -8, 10, 94, 55, 76, 31, 109 };

            int[] paratlanSzamok = new int[szamok.Length];
            int[] parosSzamok = new int[szamok.Length];

            Console.WriteLine();

            int db_prs = 0, db_prtln = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    parosSzamok[db_prs] = szamok[i];
                    db_prs++;
                }
                else
                {
                    paratlanSzamok[db_prtln] = szamok[i];
                    db_prtln++;
                }

            }
            Console.WriteLine();

            foreach (int paros in parosSzamok)
            {
                Console.Write("{0} ", paros);
            }
            Console.WriteLine();

            foreach (int paratlan in paratlanSzamok)
            {
                Console.Write("{0} ", paratlan);
            }
            


            
            //Átlagszámítás
            int[] szamok = { 3, -8, 10, 94, 55, 76, 31, 109 };
            int osszeg = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            double atlag = (double)osszeg / szamok.Length;
            Console.WriteLine("A tömb elemeinek száma {0} ", szamok.Length);
            Console.WriteLine("A tömb elemeinek összege {0} ", osszeg);
            Console.WriteLine("A tömb átlaga {0} ", atlag);
            



            int [,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[0, 1]);



        }
    }
}
