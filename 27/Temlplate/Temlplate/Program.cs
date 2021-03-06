using System;
using System.Collections.Generic;

namespace Temlplate
{
    class Template<E>
    {
        private E h;
        public Template(E x)
        {
            h = x;
        }

        public E H
        {
            get { return this.h; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Template<int> a = new Template<int>(12);
            Console.WriteLine(a.H);

            Template<float> b = new Template<float>((float)12.56);
            Console.WriteLine(b.H);

            Template<double> c = new Template<double>(12.569866657);
            Console.WriteLine(c.H);

            Template<string> d = new Template<string>("Dezső");
            Console.WriteLine(d.H);


            List<int> vector = new List<int>();
            Console.WriteLine("Kerem adja meg az adatok szamat!");
            int db = int.Parse(Console.ReadLine());
            for (int i = 0; i < db; i++)
            {
                vector.Add(i);
                Console.WriteLine(vector[i]);
            }

            vector.Add(9);
            Console.WriteLine(vector[db]);
        }
    }
}
