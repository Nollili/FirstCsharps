using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy szoveget, kiiratom betunkent!");
            string s = Console.ReadLine();
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
