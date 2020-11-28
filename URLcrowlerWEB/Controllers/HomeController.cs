using FiltravimoNS;
using System.Collections.Generic;
using System.Web.Mvc;
using URLcrowlerWEB.Models;

namespace URLcrowlerWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string adresas = "http://lrytas.lt";

            Filtravimas urlFltr = new Filtravimas();

            var duomenys = urlFltr.UrlFiltravimas(adresas);

            IList<Adresai> urlAdresuSarasas = new List<Adresai>();

            foreach (var item in duomenys)
            {
                urlAdresuSarasas.Add(new Adresai() { urlAdresas = item.ToString() });
            }

            ViewData["adresai"] = urlAdresuSarasas;

            return View();
        }
    }
}