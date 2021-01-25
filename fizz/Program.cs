using System;

namespace fizzfuzzbanana
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("BANANA");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("FUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }


            for(int b = 1; b <=20; b++)
            {
                if (b % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (b % 5 == 0)
                {
                    Console.WriteLine("FUZZ");
                }
                else if (b % 15 == 0)
                {
                    Console.WriteLine("BANANA");
                }
                else
                {
                    Console.WriteLine(b);
                }
            }


            for(int c = 1; c <=20; c++)
            {
                if (c % 3 == 0 && c % 5 == 0)
                {
                    Console.WriteLine("BANANA");
                }
                else if (c % 5 == 0)
                {
                    Console.WriteLine("FUZZ");
                }
                else if (c % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }

        }
    }
}
