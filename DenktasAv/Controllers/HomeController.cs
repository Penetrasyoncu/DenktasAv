using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenktasAv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("hakkimizda")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("iletisim")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("pinar-denktas")]
        public ActionResult WriterProfile()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("yazarin-yazilari")]
        public ActionResult WriterBlogs()
        {
            return View();
        }

        [Route("uzmanlik-alanlari")]
        public ActionResult AreasOfExpertise()
        {
            return View();
        }

        [Route("iletisim-formu")]
        public ActionResult ContactForm()
        {
            return View();
        }

        [Route("makaleler")]
        public ActionResult Blog()
        {
            return View();
        }

        [Route("pinar-denktas-profile")]
        public ActionResult pinarDenktasProfile()
        {
            return View();
        }

        [Route("hizmetlerimiz")]
        public ActionResult Hizmetler()
        {
            return View();
        }

        [Route("aile-bosanma")]
        public ActionResult HizmetAileBosanma()
        {
            return View();
        }

        [Route("miras")]
        public ActionResult HizmetMiras()
        {
            return View();
        }

        [Route("arabulucuk")]
        public ActionResult HizmetArabuluculuk()
        {
            return View();
        }

        [Route("yabancılar")]
        public ActionResult HizmetYabancilar()
        {
            return View();
        }

        [Route("nisanin-bozulmasindan-kaynaklanan-davalar-maddi-tazminat-manevi-tazminat-hediyelerin-iadesi")]
        public ActionResult MakaleNisanBozulmasi()
        {
            return View();
        }

        [Route("iki-yasindaki-kiz-cocugun-bosanan-anne-baba-ile-kisisel-iliskisi")]
        public ActionResult MakaleKizCocugu()
        {
            return View();
        }

        [Route("bosanmada-maddi-ve-manevi-tazminat")]
        public ActionResult MakaleTazminat()
        {
            return View();
        }

        [Route("ozel-hayat-alani-anayasa-mahkemesi")]
        public ActionResult MakaleAykiri()
        {
            return View();
        }
    }
}