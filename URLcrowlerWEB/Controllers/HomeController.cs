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

            var urlDuomenys = urlFltr.UrlFiltravimas(adresas);
            var emailDuomenys = urlFltr.EmailFiltravimas(adresas);

            IList<UrlAdresai> urlAdresuSarasas = new List<UrlAdresai>();
            IList<EmailAdresai> emailAdresuSarasas = new List<EmailAdresai>();

            foreach (var item in urlDuomenys)
            {
                urlAdresuSarasas.Add(new UrlAdresai() { urlAdresas = item.ToString() });
            }

            foreach (var item in emailDuomenys)
            {
                emailAdresuSarasas.Add(new EmailAdresai() { emailAdresas = item.ToString() });
            }

            ViewData["URLadresai"] = urlAdresuSarasas;
            ViewData["EMAILadresai"] = emailAdresuSarasas;
            return View();
        }
    }
}