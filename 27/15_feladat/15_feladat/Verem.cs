using System;
using System.Collections.Generic;
using System.Text;

namespace _15_feladat
{
    class Verem<Tipus>
    {
        private Tipus[] tarolo;
        private int y;

        public Verem(int elemszam = 10)
        {
            tarolo = new Tipus[elemszam];
            y = -1;
        }

        ~Verem()
        {
            Console.WriteLine("Destruktor! Ez volt a {0} elemu verem..." + tarolo.Length);
            Console.ReadKey();
        }

        public bool TeleVan()
        {
            if (y < tarolo.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Betesz(Tipus elem)
        {
            if (!TeleVan())
            {
                tarolo[++y] = elem;
            }
        }

        public bool Ures()
        {
            if (y == -1)
                return true;
            else
                return false;
        }

        public Tipus Kivesz()
        {
            if (!Ures())
                return tarolo[y--];
            else
            {
                throw new Exception("A verem ures...");
            }
        }
    }
}
