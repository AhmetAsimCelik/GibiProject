using GibiProject.BLL;
using GibiProject.Entities;
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
        DiziManager dm = new DiziManager();
        BolumManager bm = new BolumManager();


        public ActionResult Index()
        {
            var dizilist = dm.DiziList();
            return View(dizilist);
        }
        public ActionResult Bolumler(int id)
        {
            Dizi bolum = dm.BolumGetirDizi(id);

            return View(bolum.Bolum);
        }                 
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(Kullanici model)
        {
            return View();

        }
        public ActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Register(Kullanici model)
        {
            return View();


        }



    }
}