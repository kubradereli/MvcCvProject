using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya

        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();

        public ActionResult Index()
        {
            var sosyalMedya = repo.List();
            return View(sosyalMedya);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var sosyalMedya = repo.Find(x => x.ID == id);
            return View(sosyalMedya);
        }

        [HttpPost]
        public ActionResult SayfaGetir(TblSosyalMedya p)
        {
            var sosyalMedya = repo.Find(x => x.ID == p.ID);
            sosyalMedya.Ad = p.Ad;
            sosyalMedya.Durum = true;
            sosyalMedya.Link = p.Link;
            sosyalMedya.Ikon = p.Ikon;
            repo.TUpdate(sosyalMedya);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var sosyalMedya = repo.Find(x => x.ID == id);
            sosyalMedya.Durum = false;
            repo.TUpdate(sosyalMedya);
            return RedirectToAction("Index");
        }
    }
}