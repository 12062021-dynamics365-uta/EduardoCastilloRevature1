using MVC_Pet_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

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

            if (User.IsInRole("Manager"))
            {
                var users = _context.Users.ToList();
                return View("UsersAdm", users);
            }
            else
            {
                string userId = User.Identity.GetUserId();
                var theUser = _context.Users.Include(c => c.PetType).Include(c => c.Gender).Include(c => c.Color).SingleOrDefault(u => u.Id == userId);
                return View("UserHome", theUser);
            }
        }

        public ActionResult Details(string id)
        {

            return Index();
        }


        [HttpPost]
        public ActionResult GoToUser(ApplicationUser user)
        {
            return Content(user.FirstName);
        }
    }
}