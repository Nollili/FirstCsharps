using System;
using System.Text;

namespace Delegaltak
{
    public delegate void SajatDelegate1(string uzenet);
    public delegate void SajatDelegate2(StringBuilder uzenet);

    class Osztaly1
    {
        public void Metodus1(string uzenet)
        {
            Console.WriteLine("Osztaly1 Metodus1 kivasa ezzel az uzenettel: " + uzenet);
        }
    }

    class Osztaly2
    {
        public void Metodus1(string uzenet)
        {
            Console.WriteLine("Osztaly2 Metodus1 kivasa ezzel az uzenettel: " + uzenet);
        }
    }

    class Osztaly3
    {
        public void Metodus1(StringBuilder uzenet)
        {
            Console.WriteLine("Osztaly3 Metodus1 kivasa ezzel az uzenettel: " + uzenet);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[] { 'h', 'e', 'l', 'l', 'o', 'L', 'i', 'l', 'i' };
            var sb1 = new StringBuilder();

            Osztaly1 o1 = new Osztaly1();
            SajatDelegate1 sajatDel1 = o1.Metodus1;
            sajatDel1("Üdv. Osztaly 1 Metodus 1 vagyok");

            Osztaly2 o2 = new Osztaly2();
            sajatDel1 = o2.Metodus1;
            sajatDel1("Üdv. Osztaly 2 Metodus 1 vagyok");

            for(int i = 0; i< c.Length; i++)
            {
                sb1.Append(c[i]);
            }
            sajatDel1("\n Sajat delegate 1: " + sb1.ToString());

            Osztaly3 o3 = new Osztaly3();
            SajatDelegate2 sajatDel2 = o3.Metodus1;
            sb1.Clear();

            for (int b = 0; b < c.Length; b++)
            {
                sb1.Append(c[b]);
            }
            Console.WriteLine("Sajatdel2: ");
            sajatDel2(sb1);


        }
    }
}
