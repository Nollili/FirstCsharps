using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            TextReader tr = File.OpenText("szamok.txt");
            string szoveg = tr.ReadLine();
            string[] szamTomb = szoveg.Split(',');

            for (int i = 0; i < szamTomb.Length; i++)
            {
                Console.WriteLine(szamTomb[i]);
                osszeg += int.Parse(szamTomb[i]);
            }

            Console.WriteLine("Osszeg : " + osszeg);
        }
    }
}
