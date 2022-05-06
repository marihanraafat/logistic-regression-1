using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication15.ViewModels;
using System.Data.SqlClient;

namespace WebApplication15.Controllers
{
    
    public class friendsController : Controller
    {
        // GET: friends
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
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
            //int max = db.post.Max(p => p.id);
            //ViewBag.writtenPost = db.post.Where(c => c.id==max);
            List<string> writtenPost = new List<string>();
            foreach (var c in db.post)
            {
                writtenPost.Add(c.writtenPost);
                
            }
            ViewBag.writtenPost = writtenPost;

            return View();
        }
        [HttpPost]
        public ActionResult fbView(posts_friendsViewModels write)
        {
            var get = fetch().Where(c => c.id == 5).SingleOrDefault();

            ViewBag.getName = get.name;
            ViewBag.imagePpath = get.imagePpath;
            ViewBag.imagePpath2 = get.imagePpath2;
            ViewBag.country = get.country;
            ViewBag.city = get.city;
            ViewBag.email = get.email;
            ViewBag.mobile = get.mobile;
           List<string> writtenPost = new List<string>();
            foreach (var c in db.post)
            {
                writtenPost.Add(c.writtenPost);

            }

            ViewBag.writtenPost = writtenPost;


            db.post.Add(write.post);
            db.SaveChanges();
            var LastWrittenPost = write.post.writtenPost;
            ViewBag.LastWrittenPost = LastWrittenPost;
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
            //var postDB = db.post.ToList();

            return get;
        }


        [HttpGet]
        public ActionResult Post()
        {
            return RedirectToAction("fbView");
        }
        [HttpPost]
        public ActionResult Post(string write)
        {

            //db.post.Add(write);
            //db.SaveChanges();
            ViewBag.hi = write;
            return RedirectToAction("fbView");
           
        }

    }

}