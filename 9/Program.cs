using System;

namespace elsofeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verebélyi Noémi Lili, első feladat:
            bool valid = false;
            do
            {
                Console.Write("Írjon be egy pozitív egész számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());

                if (szam > 0)
                {

                    Console.Write("A(z) {0} valódi osztói a ", szam);
                    int darab = 0;
                    for (int oszto = 2; oszto < szam; oszto++)
                    {
                        if (szam % oszto == 0)
                        {
                            darab++;
                            Console.Write("{0} ", oszto);
                            valid = true;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Összesen {0} valódi osztója van.", darab);
                    break;
                }

            } while (!valid);

        }
    }
}
