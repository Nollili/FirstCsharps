using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_feladat
{
    class Program
    {
        static void Main(string[] args)
        {

            int db;
            Console.WriteLine("Kerem adja meg hany adattal kivan kiirni!");
            db = int.Parse(Console.ReadLine());
            int[] szamok = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine((i + 1) + ". szam : ");
                szamok[i] = int.Parse(Console.ReadLine());
            }

            try
            {
                FileStream fs = File.Create("szamok.txt");
                //FileStream fs = new FileStream("szamok.txt", FileMode.Open);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("\nSzamok kiirasa a szamok.txt fajlba!");
                for (int i = 0; i < db; i++)
                {
                    sw.Write(szamok[i]);
                    sw.Write(',');
                    Console.WriteLine(szamok[i]);
                }
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("A szamok.txt file nem talalhato!!!");
            }

        }
    }
}
