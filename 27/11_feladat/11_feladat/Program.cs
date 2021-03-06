using System;

namespace _11_feladat
{
    class TombKezeles
    {
        private int[] x;
        private int osszeg, min, max;
        private int db;
        private double atlag;

        Random r = new Random();

        public TombKezeles(int n)
        {
            db = n;
            x = new int[n];
            for (int i = 0; i < db; i++)
                x[i] = (int)(r.Next(1, 20));
            max = min = osszeg = 0;
            atlag = 0;
        }

        public void TombOsszeg()
        {
            for (int i = 0; i < db; i++)
                osszeg += x[i];     //osszeg = osszeg + x[i]
        }

        public void TombAtlag()
        {
            TombOsszeg();
            atlag = (double)osszeg / db;
        }

        public void MaxKereses()
        {
            max = x[0];
            for (int i = 0; i < db; i++)
                if (x[i] > max)
                    max = x[i];
        }

        public void MinKereses()
        {
            min = x[0];
            for (int i = 0; i < db; i++)
                if (x[i] < min)
                    min = x[i];
        }

        public void Kiiratas()
        {
            Console.WriteLine("A tomb elemei : ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine("Tomb elemeinek osszege : " + osszeg);
            Console.WriteLine("A tomb elemeinek atlaga : " + atlag);
            Console.WriteLine("A tomb legnagyobb eleme : " + max);
            Console.WriteLine("A tomb legkisebb eleme : " + min);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerem adja meg a tomb elemeinek a szamat : ");
            int n = int.Parse(Console.ReadLine());
            TombKezeles tk = new TombKezeles(n);
            tk.TombAtlag();
            tk.MaxKereses();
            tk.MinKereses();
            tk.Kiiratas();
        }
    }
}
