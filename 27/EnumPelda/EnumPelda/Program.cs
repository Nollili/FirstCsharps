using System;

namespace EnumPelda
{
    class Program
    {
        enum Allat { kutya, macska, farkas, tigris }
        static void Main(string[] args)
        {
            Allat allat = Allat.macska;
            Console.WriteLine("Az allat neve:" + allat);

            int iAllat = (int)allat;

            Console.WriteLine("Sorszama:" + iAllat);

            foreach (int i in Enum.GetValues(typeof(Allat)))
                Console.WriteLine(i);
        }
    }
}
