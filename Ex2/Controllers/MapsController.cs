using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ex2.DAL;
using Ex2.Models;

namespace Ex2.Controllers
{
    public class MapsController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: Maps
        public ActionResult Index()
        {
            return View(db.Maps.ToList());
        }
    }
}