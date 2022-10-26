using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GibiProject.DAL;
using GibiProject.Entities;

namespace GibiProject.Controllers
{
    public class BolumsController : Controller
    {
        private Context db = new Context();

        // GET: Bolums
        public ActionResult Index()
        {
            var bolums = db.Bolums.Include(b => b.Dizi);
            return View(bolums.ToList());
        }

        // GET: Bolums/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolum bolum = db.Bolums.Find(id);
            if (bolum == null)
            {
                return HttpNotFound();
            }
            return View(bolum);
        }

        // GET: Bolums/Create
        public ActionResult Create()
        {
            ViewBag.DiziId = new SelectList(db.Dizis, "Id", "DiziAdi");
            return View();
        }

        // POST: Bolums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BolumAdi,BolumNumara,Aciklama,BolumFoto,DiziId")] Bolum bolum)
        {
            if (ModelState.IsValid)
            {
                db.Bolums.Add(bolum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DiziId = new SelectList(db.Dizis, "Id", "DiziAdi", bolum.DiziId);
            return View(bolum);
        }

        // GET: Bolums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolum bolum = db.Bolums.Find(id);
            if (bolum == null)
            {
                return HttpNotFound();
            }
            ViewBag.DiziId = new SelectList(db.Dizis, "Id", "DiziAdi", bolum.DiziId);
            return View(bolum);
        }

        // POST: Bolums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BolumAdi,BolumNumara,Aciklama,BolumFoto,DiziId")] Bolum bolum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bolum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DiziId = new SelectList(db.Dizis, "Id", "DiziAdi", bolum.DiziId);
            return View(bolum);
        }

        // GET: Bolums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolum bolum = db.Bolums.Find(id);
            if (bolum == null)
            {
                return HttpNotFound();
            }
            return View(bolum);
        }

        // POST: Bolums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bolum bolum = db.Bolums.Find(id);
            db.Bolums.Remove(bolum);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
