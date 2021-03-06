using System;

namespace _13_feladat
{
    abstract class Teglalap
    {
        protected double a_oldal, b_oldal, kerulet, terulet;
        public Teglalap(double a, double b)
        {
            a_oldal = a;
            b_oldal = b;
        }
        public abstract void Terulet();
        public abstract void Kerulet();
        public abstract void Kiir();
    }

    interface Teglatest
    {
        void Terfogat();
        void Felszin();
    }

    class Alakzat : Teglalap, Teglatest
    {
        private double c_oldal, terfogat, felszin;

        public Alakzat(double a, double b, double c) : base(a, b)
        {
            c_oldal = c;
        }

        public override void Terulet()
        {
            terulet = a_oldal * b_oldal;
        }

        public override void Kerulet()
        {
            kerulet = 2 * (a_oldal + b_oldal);
        }

        public void Terfogat()
        {
            terfogat = a_oldal * b_oldal * c_oldal;
        }

        public void Felszin()
        {
            felszin = 2 * (a_oldal * b_oldal + a_oldal * c_oldal + b_oldal * c_oldal);
        }

        public override void Kiir()
        {
            Console.WriteLine("Teglalap terulete : " + terulet);
            Console.WriteLine("Teglalap kerulete : " + kerulet);
            Console.WriteLine("Teglatest felszine : " + felszin);
            Console.WriteLine("Teglatest terfogata : " + terfogat);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            Console.WriteLine("Kerem adja meg a teglatest a teglatest harom oldalat!");
            Console.WriteLine("a oldal: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b oldal: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c oldal: ");
            c = double.Parse(Console.ReadLine());

            Alakzat alakz = new Alakzat(a, b, c);
            alakz.Terulet();
            alakz.Kerulet();
            alakz.Terfogat();
            alakz.Felszin();
            alakz.Kiir();

        }
    }
}
