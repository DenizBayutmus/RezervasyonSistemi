using OtelMvcProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelMvcProje.Controllers
{
    public class KayitController : Controller
    {
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        // GET: Kayit
        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }
        public ActionResult KayitOl(TblYeniKayit p)
        {
            db.TblYeniKayit.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}