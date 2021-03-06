using System;

namespace Oroklodes
{
    class OsOsztaly
    {
        protected double x, y, eredmeny;
        public OsOsztaly(double x1, double y1)
        {
            x = x1;
            y = y1;
        }

        public void Szamol()
        {
            eredmeny = (x + y) / 2;     //számtani közép számolása
        }

        public void Kiiratas1()
        {
            Console.WriteLine("x = " + x + "; y = " + y);
            Console.WriteLine("Szamtani kozep : " + eredmeny);
        }
    }

    class SzarmaztatottOsztaly : OsOsztaly
    {
        private double osszeg;
        public SzarmaztatottOsztaly(double x1, double y1) : base(x1, y1)
        {
            osszeg = 0;
        }

        public void Szamol()
        {
            eredmeny = Math.Sqrt(x * y);    //mértani közép számolása, az ősosztály tagváltozóit érjük el, amiket örökölt a származtatott osztály
        }

        public void Kiiratas1()
        {
            Console.WriteLine("x = " + x + "; y = " + y);
            Console.WriteLine("Mertani kozep : " + eredmeny);
        }

        public void OsszegKepzes()
        {
            osszeg = x + y;
        }

        public void Kiiratas2()
        {
            Console.WriteLine("Osszeg : " + osszeg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double xx, yy;
            Console.WriteLine("Kerem adja meg az első adatot : ");
            xx = double.Parse(Console.ReadLine());
            Console.WriteLine("Kerem adja meg a masodik adatot : ");
            yy = double.Parse(Console.ReadLine());

            OsOsztaly osOszt = new OsOsztaly(xx, yy);   //ősosztály példányosítása
            osOszt.Szamol();
            osOszt.Kiiratas1();
            Console.WriteLine();

            SzarmaztatottOsztaly szarmOszt = new SzarmaztatottOsztaly(xx, yy);  //származtatott osztály példányosítása
            szarmOszt.Szamol();
            szarmOszt.Kiiratas1();
            szarmOszt.OsszegKepzes();
            szarmOszt.Kiiratas2();
        }
    }
}
