using System;

namespace _10_feladat
{
    class Program
    {
        class KarakterSzamOszt
        {
            private String s;
            private int karakterSzama, mhDb, szokDb, a_db, e_db, i_db, o_db, u_db;

            //parameteres konstruktor
            public KarakterSzamOszt(int a_db, int e_db, int i_db, int o_db, int u_db, int mhDb, int szokDb)
            {
                this.a_db = a_db;       //this-el hivatkozunk az osztaly tagvaltozojara
                this.e_db = e_db;
                this.i_db = i_db;
                this.o_db = o_db;
                this.u_db = u_db;
                this.mhDb = mhDb;
                this.szokDb = szokDb;
                Console.WriteLine("Az on szovege : ");
                s = Console.ReadLine();
                s = s.ToLower();
                karakterSzama = s.Length;
            }

            public void Vizsgalat()
            {
                for (int i = 0; i < karakterSzama; i++)
                {
                    switch (s[i])
                    {
                        case 'a':
                            mhDb++;
                            a_db++;
                            break;
                        case 'e':
                            mhDb++;
                            e_db++;
                            break;
                        case 'i':
                            mhDb++;
                            i_db++;
                            break;
                        case 'o':
                            mhDb++;
                            o_db++;
                            break;
                        case 'u':
                            mhDb++;
                            u_db++;
                            break;
                        case ' ':
                            szokDb++;
                            break;
                    }
                }
            }

            public void EredmenyKiir()
            {
                Console.WriteLine("A megadott szoveg : ");
                Console.WriteLine(s);
                Console.WriteLine("Karakterek szama : " + karakterSzama);
                Console.WriteLine("Maganhanzok szama : " + mhDb);
                Console.WriteLine("\t\t'a' karakter szama : " + a_db);
                Console.WriteLine("\t\t'e' karakter szama : " + e_db);
                Console.WriteLine("\t\t'i' karakter szama : " + i_db);
                Console.WriteLine("\t\t'o' karakter szama : " + o_db);
                Console.WriteLine("\t\t'u' karakter szama : " + u_db);
                Console.WriteLine("Szokozok szama : " + szokDb);
            }
        }
        static void Main(string[] args)
        {
            KarakterSzamOszt karSzamOszt = new KarakterSzamOszt(0, 0, 0, 0, 0, 0, 0);
            karSzamOszt.Vizsgalat();
            karSzamOszt.EredmenyKiir();
        }
    }
}
