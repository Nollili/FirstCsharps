using System;
using System.Collections.Generic;

namespace Vector
{
    class Program
    {
        class DinamVektor
        {
            public static void Feltoltes(List<int> vektor, int db)
            {
                for (int i = 0; i < db; i++)
                    vektor.Add(new Random().Next(0, 10 - i));
            }

            public static void Rendezes(List<int> vektor)
            {
                for (int i = 0; i < vektor.Count; i++)
                    for (int j = 0; j < vektor.Count; j++)
                        if (vektor[j] > vektor[i])
                        {
                            int e = vektor[i];
                            vektor[i] = vektor[j];
                            vektor[j] = e;
                        }
            }
        }
        static void Main(string[] args)
        {
            List<int> vec = new List<int>();

            Console.WriteLine("Feltoltes : ");
            DinamVektor.Feltoltes(vec, 10);
            for (int i = 0; i < vec.Count; i++)
                Console.Write(vec[i] + " ");

            Console.WriteLine("Rendezes : ");
            DinamVektor.Rendezes(vec);
            for (int i = 0; i < vec.Count; i++)
                Console.Write(vec[i] + " ");
        }
    }
}
