using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prímszámok 2-től 1000-ig.");

            int db = 0;
            for (int sz = 2; sz <= 1000; sz++)
            {

                bool prim = true;
                for (int j = 2; j < sz; j++)
                {
                    if (sz % j == 0)
                    {
                        prim = false;
                    }
                }

                if (prim)
                {
                    Console.Write($"{sz} ");
                    db++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("2-től 1000-ig van {0} db prímszám", db);
        }
    }
}
