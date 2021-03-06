using System;

namespace last
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Bye");

            }

        }
    }
}
