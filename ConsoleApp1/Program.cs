using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp1
{
    class Program

    {
        
         static void Main(string[] args)
        {

            string adresas = Console.ReadLine();
            


            Console.WriteLine("Hello world!!!"+"\n");


            UrlFiltravimas(adresas);
            EmailFiltravimas(adresas);
            Console.WriteLine();
            Console.ReadKey();

        }
         static void UrlFiltravimas (string adresas)
        {
            
            var url = new WebClient();
            var text = url.DownloadString(adresas);
            string sablonas = "";
            foreach (Match item in Regex.Matches(text, "(https?:\\/\\/\\w+?\\.?\\w+\\.\\w+\\/)"))
            {
                if (!Regex.IsMatch(sablonas, item.Value))
                {
                    sablonas = sablonas + "\n" + item.Value;
                }
            }

                      
            
            Console.WriteLine("Puslapuje rastos nuorodos:..." + "\n" + sablonas+"\n");
            

        }
         static void EmailFiltravimas(string adresas)
        {

            var url = new WebClient();
            var text = url.DownloadString(adresas);
            string sablonas = "";
            foreach (Match item in Regex.Matches(text, @"\b(?<mail>[a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+)\b"))
            {
                if (!Regex.IsMatch(sablonas, item.Value))
                {
                    sablonas = sablonas + "\n" + item.Value;
                }
            }

            Console.WriteLine("Puslapyje rasti e-mail'ai:.." + "\n" + sablonas);
        }

    }
}
