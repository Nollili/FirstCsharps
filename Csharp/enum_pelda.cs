using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPelda
{
    class Program
    {
        enum Allat { kutya, macska, farkas, tigris }
        static void Main(string[] args)
        {
            Allat allat = Allat.macska;
            Console.WriteLine("Az állat neve : " + allat);

            int iAllat = (int)allat;
            Console.WriteLine("Az allat értéke : " + iAllat);

            foreach(int i in Enum.GetValues(typeof(Allat)))
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
