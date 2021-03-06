using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {


            bool isHungry = true;

            if (isHungry == true)
            {
                Console.WriteLine("Go make some food !!!!");
            }
            else if (isHungry == false)
            {
                Console.WriteLine("Go to the Gym!");
            }

            cooking();
            Console.WriteLine(GetMax(962, 54785, 485265));
        }

        static void cooking()
        {
            bool haveIngredients = true;
            bool amIHungry = true;

            if (haveIngredients && amIHungry)
            {
                Console.WriteLine("Go to the kitchen and make some food now!");

            }
            else if (!haveIngredients && amIHungry)
            {
                Console.WriteLine("You have to go to the market to buy some ingredients");
            }
            else if (!haveIngredients && !amIHungry)
            {
                Console.WriteLine("Better to go shopping before you become hungry!");
            }
            else
            {
                Console.WriteLine("You can go play games now!");
            }
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 > num2 && num1 > num3)
            {
                result = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}
