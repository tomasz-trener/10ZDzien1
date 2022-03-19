using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WczytywanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile masz lat");
            string a= Console.ReadLine();
            int wiek = Convert.ToInt32(a);

            //  string wynik = "Twój wiek to: " + wiek;
            // string wynik = "Twój wiek to: " + Convert.ToString(wiek);

            string wynik = wiek + " to Twoj wiek";


            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
