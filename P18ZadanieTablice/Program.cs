using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18ZadanieTablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;

            Console.WriteLine("Podaj ile imion chcesz przechowywac");
            int ileImion = Convert.ToInt32(Console.ReadLine());

            string[] imiona = new string[ileImion];
            int i = 0;
            do
            {
                imie = Console.ReadLine();
                imiona[i] = imie;
                i++;
            } while (imie != "koniec");


            // teraz wyswietlamy 
            for (int j = 0; j < i-1; j++)
                if(imiona[j].Length > 3)
                    Console.WriteLine($"{imiona[j]} ({imiona[j].Length})");
            

            Console.ReadKey();

        }
    }
}
