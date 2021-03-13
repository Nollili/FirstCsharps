using System;
using System.Threading;

namespace Szalak
{
    class SajatMetodusok
    {
        public static void Szal1()
        {
            Console.WriteLine("Szal1 fut...");
        }
        public static void Szal2()
        {
            Console.WriteLine("Szal2 fut...");
        }
        public static void Szal3()
        {
            Console.WriteLine("Szal3 fut...");
        }
        public static void Szal4()
        {
            Console.WriteLine("Szal4 fut...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szalak inditasa ...");

            Thread szal1 = new Thread(SajatMetodusok.Szal1);
            Console.WriteLine("Szal1 allapota: "+ szal1.ThreadState);
            szal1.Start();
            Console.WriteLine("Szal1 allapota: " + szal1.ThreadState);
            Thread.Sleep(1000);

            Thread szal2 = new Thread(SajatMetodusok.Szal2);
            Console.WriteLine("Szal21 allapota: " + szal2.ThreadState);
            szal2.Start();
            Console.WriteLine("Szal2 allapota: " + szal2.ThreadState);
            Thread.Sleep(1000);

            Thread szal3 = new Thread(SajatMetodusok.Szal3);
            Console.WriteLine("Szal3 allapota: " + szal3.ThreadState);
            szal3.Start();
            Console.WriteLine("Szal3 allapota: " + szal3.ThreadState);
            Thread.Sleep(1000);

            Thread szal4 = new Thread(SajatMetodusok.Szal4);
            Console.WriteLine("Szal4 allapota: " + szal4.ThreadState);
            szal4.Start();
            Console.WriteLine("Szal4 allapota: " + szal4.ThreadState);
            Thread.Sleep(1000);

            Console.WriteLine("Szalak leallitasa ...");
            szal1.Abort();
            Console.WriteLine("Szal1 allapota: " +szal1.ThreadState);

            szal2.Abort();
            Console.WriteLine("Szal2 allapota: " + szal2.ThreadState);

            szal3.Abort();
            Console.WriteLine("Szal3 allapota: " + szal3.ThreadState);

            szal4.Abort();
            Console.WriteLine("Szal4 allapota: " + szal4.ThreadState);
        }
    }
}
