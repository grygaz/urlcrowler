using System;
using FiltravimoNS;

namespace UrlFiltravimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ivesk URL adresa pvz.: http://www.lrytas.lt ir spausk enter: ");
            string adresas = Console.ReadLine();

            var urlFltr = new Filtravimas();

            Console.WriteLine(urlFltr.UrlFiltravimas(adresas));
            Console.WriteLine(urlFltr.EmailFiltravimas(adresas));

            Console.WriteLine("\nSpausk bet kuri klavisa, jei nori baigti...");
            Console.ReadKey();
        }
    }
}