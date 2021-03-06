using System;

namespace Destruktor
{
    class Program
    {
        class TesztOsztaly
        {
            private int x;
            protected int y;
            public int z;

            public TesztOsztaly(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                Console.WriteLine("Konstruktor");
            }

            ~TesztOsztaly()
            {
                Console.WriteLine("Destruktor");
            }

            public void Kiiras(int a, int b, int c)
            {
                Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main metodus");
            int a = 4, b = 5, c = 6;
            TesztOsztaly to = new TesztOsztaly(a, b, c);
            to.Kiiras(a, b, c);
            to = null;
            GC.Collect();

        }
    }
}
