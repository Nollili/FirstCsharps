using System;
using System.Linq;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("────────▓▓▓▓▓▓▓────────────▒▒▒▒▒▒");
            Console.WriteLine("──────▓▓▒▒▒▒▒▒▒▓▓────────▒▒░░░░░░▒▒");
            Console.WriteLine("────▓▓▒▒▒▒▒▒▒▒▒▒▒▓▓────▒▒░░░░░░░░░▒▒▒");
            Console.WriteLine("───▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░░░░░░░░░▒");
            Console.WriteLine("──▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░▒");
            Console.WriteLine("──▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒");
            Console.WriteLine("─▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░▒");
            Console.WriteLine("▓▓▒▒▒▒▒▒░░░░░░░░░░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒");
            Console.WriteLine("▓▓▒▒▒▒▒▒▀▀▀▀▀███▄▄▒▒▒░░░▄▄▄██▀▀▀▀▀░░░░░░▒");
            Console.WriteLine("▓▓▒▒▒▒▒▒▒▄▀████▀███▄▒░▄████▀████▄░░░░░░░▒");
            Console.WriteLine("▓▓▒▒▒▒▒▒█──▀█████▀─▌▒░▐──▀█████▀─█░░░░░░▒");
            Console.WriteLine("▓▓▒▒▒▒▒▒▒▀▄▄▄▄▄▄▄▄▀▒▒░░▀▄▄▄▄▄▄▄▄▀░░░░░░░▒");
            Console.WriteLine("─▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒");
            Console.WriteLine("──▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░▒");
            Console.WriteLine("───▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▀▀░░░░░░░░░░░░░░▒");
            Console.WriteLine("────▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒");
            Console.WriteLine("─────▓▓▒▒▒▒▒▒▒▒▒▒▄▄▄▄▄▄▄▄▄░░░░░░░░▒▒");
            Console.WriteLine("──────▓▓▒▒▒▒▒▒▒▄▀▀▀▀▀▀▀▀▀▀▀▄░░░░░▒▒");
            Console.WriteLine("───────▓▓▒▒▒▒▒▀▒▒▒▒▒▒░░░░░░░▀░░░▒▒");
            Console.WriteLine("────────▓▓▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░▒▒");
            Console.WriteLine("──────────▓▓▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒");
            Console.WriteLine("───────────▓▓▒▒▒▒▒▒▒▒░░░░░░░▒▒");
            Console.WriteLine("─────────────▓▓▒▒▒▒▒▒░░░░░▒▒");
            Console.WriteLine("───────────────▓▓▒▒▒▒░░░░▒▒");
            Console.WriteLine("────────────────▓▓▒▒▒░░░▒▒");
            Console.WriteLine("──────────────────▓▓▒░▒▒");
            Console.WriteLine("───────────────────▓▒░▒");
            Console.WriteLine("                    ▓▒");


            Console.WriteLine(Math.Max(10, 20));

            string firstName = "Jane";
            string lastName = "Doe";

            string name = firstName + " " + lastName;
            Console.WriteLine(name);

            int x = 2, y = 5, z = 9;


            Console.WriteLine(Math.Min(x, z));
            Console.WriteLine(Math.Pow(9, 2));
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(Math.Sin(y));

            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));
            Console.WriteLine(myString[2]);

            var time = DateTime.Now;
            Console.WriteLine(time);

            int number = 15;
            if (number < 18)
            {
                Console.WriteLine(time);
            }
            else if (number > 18)
            {
                Console.WriteLine(Math.Sin(y));
            }
            else
            {
                Console.WriteLine(name);
            }

            string [] cars = {"Volvo", "Mazda", "BMW", "Mercedes"};
            
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
