using MVC_Pet_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVC_Pet_Store.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }





        // GET: Users
        public ViewResult Index()
        {
            var users = _context.PetUsers.ToList();

            if (User.IsInRole("Manager"))
                return View("UsersAdm", users);
            else
                return View("Index", users);
        }

        public ActionResult Details(int id)
        {
            var user = _context.PetUsers.Include(c => c.DesiredPetType).Include(c => c.DesiredGender).Include(c => c.DesiredColor).SingleOrDefault(c => c.Id == id);


            if (user == null)
                return HttpNotFound();

            return View(user);
        }


        [HttpPost]
        public ActionResult GoToUser(User user)
        {
            return Content(user.FirstName);
        }
    }
}