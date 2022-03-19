using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie1 = "Jan";
            string imie2 = "Adam";
            string imie3 = "Ala";

            // tablica

            string[] tablicaImion = new string[4];

            tablicaImion[0] = "Jan";
            tablicaImion[1] = "Adam";
            tablicaImion[2] = imie3;

            // wypisz wszystkie elementy tablicy 

            for (int i = 0; i < tablicaImion.Length; i++)
            {
                Console.WriteLine(tablicaImion[i]);
            }

            bool[] tablicaWartosciLogicznych = new bool[4];
            tablicaWartosciLogicznych[0] = false;
            tablicaWartosciLogicznych[1] = true;

            double[] tablicaLiczb = new double[3];
            tablicaLiczb[0] = 4;
            tablicaLiczb[1] = 6;

            // kazdy z typów ma swoją wartośc domyślą
            // string = null , int/double =0, bool = false itd....


            int?[] pensjePracownikow = new int?[3];
            pensjePracownikow[0] = 3000;
            pensjePracownikow[1] = 4000;

            //Console.WriteLine(pensjePracownikow[2]);


            int? liczba=null;

            Console.WriteLine(liczba);

            int liczba2=1;
            Console.WriteLine(liczba2);


            int? liczba3 = liczba2; // zawsze z czegos co jest not nullabe moge skonwerotwac do nullable 

            //w drugą stronę 

            if (liczba3 != null)
            {
                int liczba4 = (int)liczba3; // nie zawsze bedzie dalo sie tak zrobić 
            }

        }
    }
}
