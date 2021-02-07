using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írjon be 10 számot: ");
            double[] szamok = new double[10];

            //Sorrendben
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Szám: ");
                szamok[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("A 10 szám:");

            foreach (double num in szamok)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();
            //Fordított sorrendben
            Console.WriteLine("A 10 szám visszafelé:");

            for (int j = szamok.Length - 1; j >= 0; j--)
            {
                Console.Write("{0} ", szamok[j]);
            }
        }
    }
}
