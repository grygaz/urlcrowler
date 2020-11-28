using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace FiltravimoNS
{
    public class Filtravimas
    {
        public string UrlFiltravimas(string adresas)
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
            return sablonas;
        }

        public string EmailFiltravimas(string adresas)
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
            return sablonas;
        }

    }

}

