using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szorzótábla: ");

            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    int sum = i * y;
                    Console.Write("{0} ",sum);
                }
                Console.WriteLine();
            }
        }
    }
}
