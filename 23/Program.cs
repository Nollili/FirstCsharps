using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine( "Hello " + name);
            Console.Write("Enter Your age: ");
            string age = Console.ReadLine();
            Console.WriteLine( "Hello " + name  + " you are " + age + " years old.");


            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The two number's sum is: ");
            Console.WriteLine(num1 + num2);

            string color, pluralNoun, celebrity;

            Console.WriteLine("enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine( pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }
    }
}
