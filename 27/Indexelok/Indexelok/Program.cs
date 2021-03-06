using System;
using System.Collections;

namespace Indexelok
{
    class Szemelyek
    {
        private ArrayList szemelyek;

        public Szemelyek()
        {
            szemelyek = new ArrayList();
            szemelyek.Add("Sandor");
            szemelyek.Add("Tamas");
            szemelyek.Add("Peter");
            szemelyek.Add("Erika");
        }

        public int szemelyekSzama
        {
            get { return szemelyek.Count; }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < szemelyek.Count)
                    return szemelyek[index].ToString();
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szemelyek szem = new Szemelyek();

            for (int i = 0; i <= szem.szemelyekSzama - 1; i++)
                Console.WriteLine((i + 1) + ". nev = " + szem[i]);
        }
    }
}
