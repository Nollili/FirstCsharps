using System;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a kör sugarát: ");
            byte sugar = Convert.ToByte(Console.ReadLine());

            const double pi = Math.PI;

            double terulet = sugar * sugar * pi;
            double kerulet = 2 * sugar * pi;

            double ter = Math.Round(terulet);
            double ker = Math.Round(kerulet);

            Console.WriteLine("A kör területe: {0}.", ter);
            Console.WriteLine("A kör keruletee: {0}.", ker);

        }
    }
}
