using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ex2.DAL;
using Ex2.Models;

namespace Ex2.Controllers
{
    public class PostsController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            var allHeroes = db.Heroes;
            //this.ViewData["heroesSelectable"] = new SelectList(allHeroes, "HeroID", "Name");
            this.ViewData["heroesSelectable"] = (IEnumerable<Ex2.Models.Hero>)allHeroes;
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PostID,Title,AuthorName,HeroID,Content")] Post post)
        {
            post.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Posts/Edit/5
        [Authorize(Users = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            var allHeroes = db.Heroes;
            this.ViewData["heroesSelectable"] = (IEnumerable<Ex2.Models.Hero>)allHeroes;
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "Admin")]
        public ActionResult Edit([Bind(Include = "PostID,Title,AuthorName,HeroID,MainHero,Date,Content")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        [Authorize(Users = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Posts
        public ActionResult Filter(string heroRole, string authorName, string heroName)
        {
            var results = db.Posts.AsQueryable();
            Role role;
            if (!string.IsNullOrEmpty(heroName))
            {
                results = from post in db.Posts
                          join hero in db.Heroes on post.HeroID equals hero.HeroID
                          where hero.Name == heroName
                          select post;
            }
            if (!string.IsNullOrEmpty(heroRole) && Enum.TryParse(heroRole, out role))
            {
                results = results.Where(p => p.MainHero.HeroRole == role);
            }
            if (!string.IsNullOrEmpty(authorName))
            {
                results = results.Where(p => p.AuthorName == authorName);
            }
            return View("Index", results.ToList());
        }

        public ActionResult GroupByHero()
        {
            // Group by and join
            var totalPosts = from post in db.Posts
                             group post by post.HeroID into g
                             join hero in db.Heroes on g.Key equals hero.HeroID
                             select new GroupByHeroModel() { HeroName = hero.Name, TotalPosts = g.Sum(p => 1)};

            return View(totalPosts.ToList());
        }

        [HttpGet]
        public ActionResult GroupByHeroData()
        {
            // Group by and join
            var totalPosts = from post in db.Posts
                             group post by post.HeroID into g
                             join hero in db.Heroes on g.Key equals hero.HeroID
                             select new GroupByHeroModel() { HeroName = hero.Name, TotalPosts = g.Sum(p => 1) };

            return Json(totalPosts.ToList(), JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
