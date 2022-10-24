using GibiProject.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GibiProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DiziManager dizi = new DiziManager();

        public ActionResult Index()
        {
            var dizilist = dizi.DiziList();
            return View(dizilist);
        }
        public ActionResult Diziler()
        {
            return View();
        }
    }
}