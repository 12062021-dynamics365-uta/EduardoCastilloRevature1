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
        public ViewResult Index()
        {
            var pets = _context.Pets.Include(c => c.PetType).ToList();

            return View(pets);
        }

        public ActionResult Details(int id)
        {
            var pet = _context.Pets.Include(c => c.PetType).Include( c => c.Color).Include( c => c.Gender).SingleOrDefault(c => c.Id == id);

            if (pet == null)
                return HttpNotFound();

            return View(pet);
        }
    }
}