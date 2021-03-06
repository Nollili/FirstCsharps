using System;

namespace TipusKonverziok
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
            int j = 555;
            byte b = (byte)j;
            Console.WriteLine(b);


            char c2 = 'n';
            int k = Convert.ToInt32(c2);
            Console.WriteLine(k);
        }
    }
}
