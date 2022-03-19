using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11InstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek");
            int wiek = Convert.ToInt32(Console.ReadLine());

            // wypisz czy jest mlody czy stary / próg 50

            if (wiek < 50)
            {
                Console.WriteLine("młody");
            }
            else
            {
                Console.WriteLine("stary");
            }

            // gdy opcji jest więcej 
            // np do 30 młody, 30-50 sredni, ponad 50 stary 

            if (wiek<30)
            {
                string x = "wiek: ";
                Console.WriteLine(x + "młody");
            }else if(wiek > 50)
                Console.WriteLine("stary");
            else
                Console.WriteLine("sredni");

            // ponizej 30 bardzo młody, 30-50 młody, 50-70 sredni, powyzej 70 stary
            if (wiek < 30)
                Console.WriteLine("bardzo młody");
            else if (wiek < 50)
                Console.WriteLine("młody");
            else if (wiek < 70)
                Console.WriteLine("średni");
            else
                Console.WriteLine("stary");

            // sprawdz czy to kbieta czy mezczyzna bazujac tylko na wzroście
            // gdy wzrost jest ponad 180 to męzczyzna a ponizej to kobieta
            // wynik zapisz w zmiennej płeć
            int wzrost = 175;
            string plec;

            if (wzrost > 180)
                plec = "mężczyzna";
            else
                plec = "kobieta";

            // w takim przypadku (ale nie zawsze) mozemy uprościć to wyrażenie

            string plec2 = wzrost > 180 ? "mężczyzna" : "kobieta";


        }
    }
}
