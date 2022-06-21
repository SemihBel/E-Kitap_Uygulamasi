using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Kitap_Uygulamasi.Data;
using E_Kitap_Uygulamasi.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Kitap_Uygulamasi.Controllers
{
    
    public class KitapController : Controller
    {
        ApplicationDbContext _db;

        public KitapController(ApplicationDbContext db)
        {
            _db = db;
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();
        }
        public IActionResult Index()
        {
            return View(_db.Kitaplar.Include("Yazar").ToList());
        }
        public IActionResult Detay(int id)
        {
            return View(_db.Kitaplar.Include("Yazar").Include("YayinEvi").Where(k => k.KitapID == id).Single());
        }
    }
}
