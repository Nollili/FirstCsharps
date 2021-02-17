using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b, c, d;
            float e, f;
            b = 5;
            c = 3;

            //Aritmetikai operátorok, egyenlőség operátorok
            a = b + c;
            Console.WriteLine(a);
            a = b - c;
            Console.WriteLine(a);
            a = b * c;
            Console.WriteLine(a);
            f = b;
            e = (float)(f / c);
            Console.WriteLine(e);
            //rövidített forma
            a = a + 2;              //teljes forma
            Console.WriteLine(a);
            a += 2;                 //rövidített forma ugyanaz mind a = a + 2
            Console.WriteLine(a);
            a -= 2;
            a *= 2;
            a /= 2;
            a = b % c;
            Console.WriteLine(a);
            //a = a % c;
            a %= c;
            Console.WriteLine(a);
            

            //inkrementáló, dekrementáló operátorok
            a = 2;
            a = a - 1;
            //a++;
            //Console.WriteLine(a--);
            Console.WriteLine(a);
            //++a;
            Console.WriteLine(++a);
            //--a;
            Console.WriteLine(--a);
            

            //bitműveleti operácorok
            int i = 0;      //0000
            int j = 2;      //0010
            int k = i & j; //0000 & 0010 = 0000
            Console.WriteLine(k);
            k = i | j;      //0000 | 0010 = 0010
            Console.WriteLine(k);
            k = i ^ j;  //0000 ^ 0010 =  0010
            Console.WriteLine(k);
            j = j << 2;     // 0010 << 2 = 1000
            //j <<=2;
            Console.WriteLine(j);
            j = j >> 3;     //1000 >> 3 = 0001
            Console.WriteLine(j);
            

            //relációs operátorok
            int l = 35;//20;
            int m = 35;
            bool relacio = false;
            relacio = (l < m);
            Console.WriteLine("l < m : " + relacio);
            relacio = (l == m);
            Console.WriteLine("l == m : " + relacio);
            relacio = (l != m);
            Console.WriteLine("l != m : " + relacio);
            relacio = (l >= m);
            Console.WriteLine("l >= m : " + relacio);
            relacio = (l <= m);
            Console.WriteLine("l <= m : " + relacio);
            

            //logikai operátorok
            bool igaz = true;
            bool hamis = false;
            bool eredmeny;
            eredmeny = igaz && false;
            Console.WriteLine("Logikai és : " + eredmeny);
            eredmeny = igaz || hamis;
            Console.WriteLine("Logikai vagy : " + eredmeny);
            

            //feltételes operátor
            int q = 3;
            int z = 5;
            string v = (q > z) ? "q a nagyobb" : "z a nagyobb";
            Console.WriteLine(v);
            //maximum kiválasztás
            int p = (q > z) ? 3 : 5;
            Console.WriteLine(p);
            

            //precedencia szabály
            int prec = (5 + 4) * 8;
            Console.WriteLine(prec);
            

            //asszociativitás szabály
            int n, w, u;
            n = w = u = 16;
            Console.WriteLine("n = " + n + ", w = " + w + ", u = " + u);

            Console.ReadKey();
        }
    }
}
