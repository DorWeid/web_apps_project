using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ex2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            var isAdmin = username == "admin" && password == "1234";
            if (isAdmin)
            {

                //System.Web.HttpContext.Current.Session["isLoggedIn"] = true;


                FormsAuthentication.SetAuthCookie("Admin", false);
                //FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);



                return Json(new { succeeded = true });
            }

            //ViewBag.ErrMsg = "User name or password are incorrect.";
            //return View();
            return Json(new { error= "User name or password are incorrect." });
        }

        public ActionResult Logout()
        {
            //System.Web.HttpContext.Current.Session["isLoggedIn"] = null;
            FormsAuthentication.SignOut();
            return View("~/Views/Admin/Login.cshtml");
        }
    }
}
