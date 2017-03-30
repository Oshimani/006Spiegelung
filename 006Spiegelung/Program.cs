using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Spiegelung
{
    class Program
    {
        static void Main(string[] args)
        {
            String satz = Console.ReadLine();
            char [] ergebnis = satz.ToArray<char>(); // so erhält man die selbe Länge
            Console.WriteLine(ergebnis);
            int zaehler = 0; // stellenindex
            while (zaehler < satz.Length)
            {
                ergebnis[ergebnis.Length - zaehler -1] = satz[zaehler];
                zaehler = zaehler + 1;
            }
            Console.WriteLine(ergebnis);
        }
    }
}
