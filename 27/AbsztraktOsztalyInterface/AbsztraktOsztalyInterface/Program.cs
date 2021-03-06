using System;

namespace AbsztraktOsztalyInterface
{
    abstract class SZMKozep
    {
        abstract public void SzamtaniKozep();
        abstract public void MertaniKozep();
    }

    interface HatvanyozGyokvonas
    {
        void Hatvanyoz();
        void Gyokvonas();
    }

    class Muveletek : SZMKozep, HatvanyozGyokvonas
    {
        private double x, y, eredmeny;

        public Muveletek(double a, double b)
        {
            x = a;
            y = b;
            eredmeny = 0;
        }

        public override void SzamtaniKozep()
        {
            eredmeny = (x + y) / 2;
            Console.WriteLine("Szamtani kozep : " + eredmeny);
        }

        public override void MertaniKozep()
        {
            eredmeny = Math.Sqrt(x * y);
            Console.WriteLine("Merteni kozep : " + eredmeny);
        }

        public void Hatvanyoz()
        {
            eredmeny = Math.Pow(x, y);
            Console.WriteLine("Hatvanyozas : " + eredmeny);
        }

        public void Gyokvonas()
        {
            eredmeny = Math.Pow(x, 1 / y);
            Console.WriteLine("Gyokvonas : " + eredmeny);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Kerem adja meg az elso szamot!");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Kerem adja meg a masodik szamot!");
            y = int.Parse(Console.ReadLine());

            Muveletek muv = new Muveletek(x, y);
            muv.SzamtaniKozep();
            muv.MertaniKozep();
            muv.Hatvanyoz();
            muv.Gyokvonas();
        }
    }
}
