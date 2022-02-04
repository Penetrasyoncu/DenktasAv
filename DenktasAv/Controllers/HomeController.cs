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

        [Route("blog")]
        public ActionResult Blog()
        {
            return View();
        }

        [Route("hizmetlerimiz")]
        public ActionResult Hizmetlerimiz()
        {
            return View();
        }
    }
}