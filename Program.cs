using System;

namespace szoveg
{
    class KarakterSzamOszt
    {
        private String s;
        private int karakterSzama, mhDb, szokDb, a_db, e_db, i_db, u_db, o_db;

        public KarakterSzamOszt(int a_db, int e_db, int i_db, int u_db, int o_db, int mhDb, int szokDb)
        {
            this.a_db = a_db;
            this.e_db = e_db;
            this.i_db = i_db;
            this.o_db = o_db;
            this.u_db = u_db;
            this.mhDb = mhDb;
            this.szokDb = szokDb;
            
            Console.WriteLine("Az ön szövege: ");
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
            Console.WriteLine("A megadott szöveg: ");
            Console.WriteLine(s);
            Console.WriteLine("Karakterek száma: " + karakterSzama);
            Console.WriteLine("Magánkangzók száma: " + mhDb);

            Console.WriteLine("\t\t 'a' karakterek száma: " + a_db);
            Console.WriteLine("\t\t 'e' karakterek száma: " + e_db);
            Console.WriteLine("\t\t 'i' karakterek száma: " + i_db);
            Console.WriteLine("\t\t 'o' karakterek száma: " + o_db);
            Console.WriteLine("\t\t 'u' karakterek száma: " + u_db);

            Console.WriteLine("Szóközök száma: " + szokDb);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            KarakterSzamOszt karSzamOszt = new KarakterSzamOszt(0, 0, 0, 0, 0, 0, 0);
            karSzamOszt.Vizsgalat();
            karSzamOszt.EredmenyKiir();
        }
    }
}
