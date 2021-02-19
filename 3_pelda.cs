using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            //bool igaze = true;
            Console.WriteLine("Kerem adjon meg egy pozitiv egesz szamot!");
            szam = int.Parse(Console.ReadLine());
            if(szam <= 0)
                Console.WriteLine("Hibas adat!");
            else
            {
                if ((szam % 3 == 0) && (szam % 5 == 0))
                {
                    Console.WriteLine(szam + " oszthato 3-al es 5-el!");
                    //igaze = true;
                }
                else if (szam % 2 == 0)
                {
                    Console.WriteLine(szam + " oszthato 2-vel, tehat paros!");
                    //igaze = true;
                }
                else if(szam % 3 == 0)
                {
                    Console.WriteLine(szam + " oszthato 3-al!");
                    //igaze = true;
                }
                else if(szam % 5 == 0)
                {
                    Console.WriteLine(szam + " oszthato 5-el!");
                    //igaze = true;
                }
                else //if (!igaze)
                {
                    Console.WriteLine(szam + " nem osthato 2-vel, 3-al és 5-el!");
                }
                
            }

            Console.ReadKey();
        }
    }
}
