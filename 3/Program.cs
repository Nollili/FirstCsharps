using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial!");
            Console.Write("Give me a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int szorzat = 1;
            for (int i = 1; i <= num; i++)
            {
                szorzat *= i;
            }
            Console.WriteLine("Factorial is: {0}", szorzat);

        }
    }
}
