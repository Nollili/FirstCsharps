using System;

namespace VirtualisMetodusok
{
    class Szamolas1
    {
        protected int x1, y1, eredmeny1;

        public Szamolas1(int x, int y)
        {
            x1 = x;
            y1 = y;
            eredmeny1 = 0;
        }
        public virtual int Szamol()
        {
            eredmeny1 = x1 + y1;
            return eredmeny1;
        }
    }

    class Szamolas2 : Szamolas1
    {

        public Szamolas2(int x, int y) : base(x, y)
        {
            eredmeny1 = 0;
        }

        public override int Szamol()
        {
            eredmeny1 = x1 * y1;
            return eredmeny1;
        }
    }

    class Szamolas3 : Szamolas2
    {

        public Szamolas3(int x, int y) : base(x, y)
        {
            eredmeny1 = 0;
        }

        public override int Szamol()
        {
            eredmeny1 = x1 % y1;
            return eredmeny1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 5;

            Szamolas1 sz1 = new Szamolas1(a, b);
            Console.WriteLine("Szamol1 metodus : " + sz1.Szamol());

            Szamolas2 sz2 = new Szamolas2(a, b);
            Console.WriteLine("Szamol2 metodus : " + sz2.Szamol());

            Szamolas3 sz3 = new Szamolas3(a, b);
            Console.WriteLine("Szamol3 metodus : " + sz3.Szamol());

            Console.ReadKey();
        }
    }
}
