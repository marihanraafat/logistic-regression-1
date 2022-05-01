using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    
    public class friendsController : Controller
    {
        // GET: friends
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult fbView()
        {
            var get = fetch().Where(c=>c.id==5).SingleOrDefault();

            ViewBag.getName = get.name;
            ViewBag.imagePpath = get.imagePpath;
            ViewBag.imagePpath2 = get.imagePpath2;
            ViewBag.country = get.country;
            ViewBag.city = get.city;
            ViewBag.email = get.email;
            ViewBag.mobile = get.mobile;

            return View();
        }
       
        public ActionResult fbViewPost()
        {

            return View();
        }

        public ActionResult fbViewPost_m()
        {

            return View();
        }
        public ActionResult fbViewPost_a()
        {

            return View();
        }

        public IEnumerable<friends> fetch()
        {
            var get = db.friend.ToList();

            return get;
        }


    }

}