using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int x, y;
            int[,] matrix = new int[2,2];
            /*int[,] matrix = new int[,] { { 3, 6 },
                                         { 7, 9} };*/
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = r.Next(10);   //i a sor, j az oszlop
                }
            }
   
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("sor index : " + i + "; osztlop index: " + j + "; tomb eleme: " + matrix[i, j]);  //i a sor, j az oszlop
                }
            }

            Console.ReadKey();
        }
    }
}
