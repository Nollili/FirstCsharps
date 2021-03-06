using System;

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

            Console.WriteLine("CompareTo: " + nev3.CompareTo(nev5));
            Console.WriteLine("IndexOf: " + nev3.IndexOf('P'));
            Console.WriteLine("IndexOfAny: " + nev4.IndexOfAny(c));     //karaktertömb kell ide
            Console.WriteLine("LastIndexOf: " + nev3.LastIndexOf('r'));
            Console.WriteLine("LasIndexOfAny: " + nev3.LastIndexOfAny(c));  //karaktertömb kell ide
            Console.WriteLine("Constains: " + nev3.Contains("erenc"));
            Console.WriteLine("Replace: " + nev3.Replace('r', 's'));
            Console.WriteLine("Trim: " + nev3.Trim(c));
            Console.WriteLine("Insert: " + nev3.Insert(12, "esek"));
            Console.WriteLine("Remove: " + nev3.Remove(3, 8));
            Console.WriteLine("Substring: " + nev3.Substring(6, 6));
            Console.WriteLine("ToUpper: " + nev3.ToUpper());
            Console.WriteLine("ToLower: " + nev3.ToLower());
        }
    }
}
