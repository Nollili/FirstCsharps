using System;

namespace _8_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = "369";
            object o2 = "Hello";
            object o3 = 20;
            object o4 = 7.45;

            string s1 = o1 as string;
            Console.WriteLine((s1 == null) ? "NULL" : s1);

            string s2 = o2 as string;
            Console.WriteLine((s2 == null) ? "NULL" : s2);

            string s3 = o3 as string;
            Console.WriteLine((s3 == null) ? "NULL" : s3);

            string s4 = o4 as string;
            Console.WriteLine((s4 == null) ? "NULL" : s4);

        }
    }
}
