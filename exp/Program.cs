using System;

namespace exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3,2));
        }



        static int GetPow (int baseNum, int powNum)
        {
            int result = 1;

            for (int i=0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }

    
}
