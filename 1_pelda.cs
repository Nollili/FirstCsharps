using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pelda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy egész számot, és megmondom osztható e 2-vel! ");
            int szam = int.Parse(Console.ReadLine());
            if(szam % 2 == 0)
            {
                Console.WriteLine("A " + szam + " osztható 2-vel, tehát páros!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("A " + szam + " nem osztható 2-vel maradék nélkül, tehát páratlan!");
            Console.ReadKey();
            return;
        }
    }
}
