﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;

namespace MvcCvProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitim()
        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yetenek()
        {
            var yeteneklerim = db.TblYeteneklerim.ToList();
            return PartialView(yeteneklerim);
        }

        public PartialViewResult Hobi()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifika()
        {
            var sertifikalar = db.TblSertifikalarim.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Iletisim(TblIletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblIletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}