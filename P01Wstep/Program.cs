using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Wstep
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "ala ma kota";

            Console.WriteLine(a);

            int b = 5;

            double c = 5.6;

            b = b + 1;
            b++; // zwiększenie o 1
                 // operatory :  *, / , + , - 

            int b2 = 10 / 3; // 3

            double c2 = 3;

            double c3 = 10 / c2; // 3.33

            double c4 = 10 / 3; // 3 

            // zapisy skrótowe

            int e = 1;
            e = e + 1;
            e++; // zwiększ o 1
            e += 1; // zwieksz o 1
            e += 5; // zwieksz o 5 

            e--; // zmniejszo 1
            e -= 5; // zmniejsz o dodwolna inna wartosc 

            e *= 3; // przemnoz 
            e /= 3; // przedziel zmiast e = e/3;




            Console.ReadKey();


        }
    }
}
