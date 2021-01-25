using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 7, 331, 13, 77 };
            Console.WriteLine(luckyNumbers[3]);

            string[] fruits = new string[5];
            fruits[0] = "apple";
            fruits[2] = "grape";

            SayHi(" To me! ", 22);
            SayHi(" To You!", 99);

            int cubedNumber = cuber(5);
            Console.WriteLine(cuber(7));
            Console.WriteLine(cubedNumber);


        }


        static void SayHi(string name, int age)
        {

            Console.WriteLine("Hello User!" + name + " you are: " + age);


        }


        static int cuber(int num)
        {
            int result = num * num * num;
            return result;

        }
    }
}
