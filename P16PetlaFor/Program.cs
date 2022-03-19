using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
            int k = 0;
            while (k<napis.Length)
            {
                Console.WriteLine(napis.Substring(k,1));
                k++;
            }

            for (int i = 0; i < napis.Length; i++) // zmienna i zyje tylko w ciele danej pętli
            {
                Console.WriteLine(napis.Substring(i,1));
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            k = 0; // zmienna k zyje w całej metodzie

            Console.ReadKey();

        }
    }
}
