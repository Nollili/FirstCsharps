using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringekMetodusaik
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 128;
            char betu = 'F';
            char[] c = new char[] { 'r', 'b', 'c' };

            string nev1 = "Demeter Bela";

            char[] nevTomb = { 'P', 'e', 't', 'e', 'r', ' ', 'F', 'e', 'r', 'e', 'n', 'c' };
            String nev3 = new String(nevTomb);

            string nev4 = " Seres Sandor ";
            string nev5 = "peter ferenc";

            Console.WriteLine(nev3.CompareTo(nev5));
            Console.WriteLine(nev3.IndexOf('P'));
            //Console.WriteLine(nev4.IndexOfAny());
            Console.WriteLine(nev3.LastIndexOf('r'));
            //Console.WriteLine(nev3.LastIndexOfAny(betu));
            Console.WriteLine(nev3.Contains("erenc"));
            Console.WriteLine(nev3.Replace('r', 's'));
            Console.WriteLine(nev3.Trim(c));
            Console.WriteLine(nev3.Insert(12, "esek"));
            Console.WriteLine(nev3.Remove(3, 8));
            Console.WriteLine(nev3.Substring(6, 6));
            Console.WriteLine(nev3.ToUpper());
            Console.WriteLine(nev3.ToLower());

            Console.ReadKey();
        }
    }
}
