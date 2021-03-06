using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            int index = 11;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }


            do
            {
                Console.WriteLine(index);
                index++;

            } while (index <= 10);



            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            string[] fruits = { "apple", "grape", "melon", "banana", "berry" };
            for (int k = 0; k <= fruits.Length; k++)
            {
                Console.WriteLine(fruits[k]);
            }
        }
    }
}
