using MVC_Pet_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVC_Pet_Store.Controllers
{
    public class PetsController : Controller
    {
        private ApplicationDbContext _context;

        public PetsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }





        // GET: Pets
        public ActionResult Index()
        {
            var pets = _context.Pets.Include(m => m.PetType).ToList();

            return View(pets);
        }
    }
}