using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08WczytywaniePlikow
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dane= File.ReadAllText("c:\\dane\\plik.txt");
            string dane = File.ReadAllText(@"c:\dane\plik.txt");

            Console.WriteLine(dane);

            File.WriteAllText(@"c:\dane\plik.txt","hej");// zapisz dane do pliku

            

            Console.ReadKey();

        }
    }
}
