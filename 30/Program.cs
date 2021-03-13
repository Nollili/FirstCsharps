using System;

namespace Strukturak
{
    struct Konyvek
    {
        public string szerzo;
        public string cim;
        public int kiadasEve;
        public float ar;
        public Konyvek(string szerzo, string cim, int kiadasEve, float ar)
        {
            this.szerzo = szerzo;
            this.cim = cim;
            this.kiadasEve = kiadasEve;
            this.ar = ar;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string szerzo = "Dezso Peter";
            string cim = "A kutya nem alszik";
            int kiadasEve = 2011;
            float ar = (float)2889.5;

            Konyvek k = new Konyvek(szerzo, cim, kiadasEve, ar);
            Console.WriteLine(" A könyv adatai: \n Szerzo: " + szerzo + "; \n Konyv cime: " + cim + ";\n Kiadas eve: " + kiadasEve + ";\n Ar: " + ar + ";");

            Console.WriteLine("Hany konyv adatait kivanja bekerni?");
                int konyvDb = int.Parse(Console.ReadLine());

            Konyvek[] konyvtar = new Konyvek[konyvDb];

            for(int i = 0; i < konyvDb; i++)
            {
                Console.WriteLine("Adja meg a(z) " + (i+1) + ". Konyv szerzojet!");
                konyvtar[i].szerzo = Console.ReadLine();

                Console.WriteLine("Adja meg a(z) " + (i + 1) + ". Konyv cimet!");
                konyvtar[i].cim = Console.ReadLine();

                Console.WriteLine("Adja meg a(z) " + (i + 1) + ". Konyv kiadasi evet!");
                konyvtar[i].kiadasEve = int.Parse(Console.ReadLine());

                Console.WriteLine("Adja meg a(z) " + (i + 1) + ". Konyv arat!");
                konyvtar[i].ar = float.Parse(Console.ReadLine());
            }

            for(int j = 0; j < konyvtar.Length; j++)
            {
                Console.WriteLine("Az " + (j + 1) + ". konyv szerzoje : " + konyvtar[j].szerzo);
                Console.WriteLine("Az " + (j + 1) + ". konyv cime : " + konyvtar[j].cim);
                Console.WriteLine("Az " + (j + 1) + ". konyv kiadasi eve : " + konyvtar[j].kiadasEve);
                Console.WriteLine("Az " + (j + 1) + ". konyv ara : " + konyvtar[j].ar);
            }
        
        
        }
    }
}
