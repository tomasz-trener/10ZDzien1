using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakis tekst");
            string s = Console.ReadLine();

            int liczbaZnakow = s.Length;
            
            string wynik=
                s.Substring(0, 1).ToUpper() +
                s.Substring(1, liczbaZnakow - 2).ToLower() +
                s.Substring(liczbaZnakow - 1).ToUpper();

            Console.WriteLine(wynik);

            Console.WriteLine(s.Substring(0, 1).ToUpper() +
                s.Substring(1, liczbaZnakow - 2).ToLower() +
                s.Substring(liczbaZnakow - 1).ToUpper());

            Console.ReadKey();
        }
    }
}
