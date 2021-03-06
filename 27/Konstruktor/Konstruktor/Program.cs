using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class PeldaOsztaly
    {
        private int x, y, eredmeny;

        public PeldaOsztaly()
        {
            x = y = 1;
            eredmeny = 0;
        }

        public PeldaOsztaly(int x1, int y1)
        {
            x = x1;
            y = y1;
            eredmeny = 0;
        }

        public PeldaOsztaly(PeldaOsztaly obj)
        {
            x = obj.x;
            y = obj.y;
            eredmeny = 0;
        }

        public void Muvelet()
        {
            eredmeny = x + y;
        }

        public void Kiir()
        {
            Console.WriteLine(x + " + " + y + " = " + eredmeny);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int szam1 = 10, szam2 = 7;

            PeldaOsztaly pelda1 = new PeldaOsztaly();
            pelda1.Muvelet();
            pelda1.Kiir();

            PeldaOsztaly pelda2 = new PeldaOsztaly(szam1, szam2);
            pelda2.Muvelet();
            pelda2.Kiir();

            PeldaOsztaly pelda3 = new PeldaOsztaly(pelda2);
            pelda3.Muvelet();
            pelda3.Kiir();

        }
    }
}
