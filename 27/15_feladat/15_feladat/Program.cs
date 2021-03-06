using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_feladat
{
    class Program
    {
        static void Main(string[] args)
        {

            Verem<int> verem = new Verem<int>();
            for (int i = 1; i <= 5; i++)
            {
                verem.Betesz(i);
            }

            Console.WriteLine("verem 1. eleme :" + verem.Kivesz());
            Console.WriteLine("verem 2. eleme :" + verem.Kivesz());
            Console.WriteLine("verem 3. eleme :" + verem.Kivesz());
            Console.WriteLine("verem 4. eleme :" + verem.Kivesz());
            Console.WriteLine("verem 5. eleme :" + verem.Kivesz());

        }
    }
}
