using System;
using FiltravimoNS;

namespace UrlFiltravimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIvesk URL adresa pvz.: http(s)://www.lrytas.lt ir spausk enter: ");
            string adresas = Console.ReadLine();

            Filtravimas urlFltr = new Filtravimas();

            Console.WriteLine(urlFltr.UrlFiltravimas(adresas));
            Console.WriteLine(urlFltr.EmailFiltravimas(adresas));

            Console.WriteLine("\nSpausk bet kuri klavisa, jei nori baigti...");
            Console.ReadKey();
        }
    }
}