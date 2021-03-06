using System;

namespace GetterMetodus
{
    class Getter
    {
        private int x, y, z;

        public Getter(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }

        public int Get()
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Getter getter = new Getter(2, 3, 4);

            Console.WriteLine("X valtozo erteke : " + getter.Get());

            Console.ReadKey();

        }
    }
}
