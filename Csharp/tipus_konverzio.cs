using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipuskonverzio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Automatikus típuskonverzió
            char c = 'c';
            int i = c;
            Console.WriteLine(i);
            
            float f = (float)10.775;
            double d = f;
            Console.WriteLine(d);
            

            //kényszerített típuskonverzió
            int i = 555;
            byte b = (byte)i;
            Console.WriteLine(b);
            

            char c2 = 'n';
            int i = Convert.ToInt32(c2);
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
