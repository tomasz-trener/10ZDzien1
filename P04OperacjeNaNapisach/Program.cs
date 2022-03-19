using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04OperacjeNaNapisach
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ala";
            string s2 = "ma";
            int wiek = 30;
            string s3 = "lat";

            string wynik1 = s1 + " " + s2 + " " + wiek + " " + s3;

            string wynik2 = $"{s1} Kowalska {s2} {wiek} {s3} i jutro ma urodziny";

            string wynik3 = string.Format("{0} Kowlaska {1} {2} {3} i jutro ma urodziny",
                s1,s2,wiek,s3);

            string s = "ala ma kota";
                      //012345678910
            int a = s.Length; // dlugosc ciagu tesktowego 

            string w1 = s.Substring(4);// ma kota
            string w2 = s.Substring(4, 2); // ma

            string w3 =  s.ToUpper(); // zamiana na duzelitery // ALA MA KOTA
            string w4 = s.ToLower(); // zamiana na male litery

            string w5 =  s.Replace("ma", "bedzie miala"); // ala bedzie miala kota 

            bool w6 = s.Contains("ma"); // true    opcjonalnie false 

            string w7=  s.Trim(); // usuwa spacje z poczatku i konca ale nie ze srodka 

            int w8 = s.IndexOf("ma");// (wynik = 4) zwraca pozycje pierwszego podciagu

            string napis1 = "ala\nma\nkota";
            string napis2 = "ala\tma\tkota";
            string napis3 = "ala" + Environment.NewLine + "ma" + Environment.NewLine + "kota";



        }
    }
}
