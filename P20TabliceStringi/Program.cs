using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20TabliceStringi
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";

            //musimy zdefiniowac znak speracji (u nas spacja)

            string[] wyrazy = napis.Split(' ');

            // gdyby chcieć rozdzielić po podciągu 

            string napis2 = "ala!%ma!%kota";

            string[] separatory = { "!%" };
            string[] wyrazy2=  napis2.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            // a w drugą stronę czyli z tablicy na ciąg tektowy 

            string[] tablica = { "Jan", "Ola", "Adam" };

            string wynik = string.Join("* - *", tablica); // -> Jan* - *Ola* - *Adam


        }
    }
}
