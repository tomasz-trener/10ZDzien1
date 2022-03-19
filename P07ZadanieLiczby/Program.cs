using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rownanie");

            string r = Console.ReadLine();

            int poz = r.IndexOf("+");

            string liczba1 = r.Substring(0, poz);
            string liczba2 = r.Substring(poz + 1);

            int suma = Convert.ToInt32(liczba1) + Convert.ToInt32(liczba2);

            Console.WriteLine("wynik to" + suma);
            Console.ReadKey();



        }
    }
}
