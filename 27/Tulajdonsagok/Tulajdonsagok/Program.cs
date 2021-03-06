using System;

namespace Tulajdonsagok
{
    class Program
    {
        abstract class AlapOszt
        {
            protected int x, y;
            public abstract void Kiiras();
        }

        class Szarmaztatott : AlapOszt
        {
            public Szarmaztatott(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int X
            {
                get { return this.x; }
                set { this.x = value; }
            }

            public int Y
            {
                get { return this.y; }
                set { this.y = value; }
            }

            public override void Kiiras()
            {
                Console.WriteLine("Kiiras metodusbol : x = " + x + "; y = " + y);
            }
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            Szarmaztatott szmOszt = new Szarmaztatott(a, b);
            szmOszt.Kiiras();

            Console.WriteLine("Kiiras tulajdonsagokbol : x = " + szmOszt.X + "; y = " + szmOszt.Y);

            szmOszt.X = 3;
            szmOszt.Y = 12;

            Console.WriteLine("Kiiras tulajdonsagokbol : x = " + szmOszt.X + "; y = " + szmOszt.Y);
        }
    }
}
