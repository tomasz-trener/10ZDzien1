using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadaniePliki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj dwa wyrazy");

            string dane = Console.ReadLine();

            // rozbicie na dwa wyrazy (co zamieniamy i na co)
            int poz = dane.IndexOf(" ");
            string napis1 = dane.Substring(0, poz);
            string napis2 = dane.Substring(poz + 1);

            // wczytujemy plik
            string zawartoscPliku= File.ReadAllText(nazwa);
            // zamieniamy co na co (napis1 na napis 2)
            zawartoscPliku= zawartoscPliku.Replace(napis1, napis2);
            // zapisujemy plik.
            File.WriteAllText(nazwa, zawartoscPliku);


        }
    }
}
