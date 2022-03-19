using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ZadaniePelte
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj równanie");
                string rownanie = Console.ReadLine();

                int pozPlus = rownanie.IndexOf("+");
                int pozMinus = rownanie.IndexOf("-");
                int pozMnozenie = rownanie.IndexOf("*");
                int pozDzielenie = rownanie.IndexOf("/");

                double wynik;

                if (pozPlus > -1)
                    wynik = Convert.ToInt32(rownanie.Substring(0, pozPlus)) +
                        Convert.ToInt32(rownanie.Substring(pozPlus + 1));
                else if (pozMinus > -1)
                    wynik = Convert.ToInt32(rownanie.Substring(0, pozMinus)) -
                        Convert.ToInt32(rownanie.Substring(pozMinus + 1));
                else if (pozMnozenie > -1)
                    wynik = Convert.ToInt32(rownanie.Substring(0, pozMnozenie)) *
                        Convert.ToInt32(rownanie.Substring(pozMnozenie + 1));
                else if (pozDzielenie > -1)
                    wynik = Convert.ToDouble(rownanie.Substring(0, pozDzielenie)) /
                        Convert.ToDouble(rownanie.Substring(pozDzielenie + 1));
                else
                {
                    Console.WriteLine("Podałeś zły operator");
                    continue;
                    //Console.ReadKey();
                    //return;
                }

                Console.WriteLine("wynik to: " + wynik);
               // Console.ReadKey();
            }
        }
    }
}
