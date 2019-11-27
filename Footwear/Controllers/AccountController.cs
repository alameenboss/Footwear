using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Footwear.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username,string Password)
        {
            if (Username == "admin" && Password == "admin")
            {
                return RedirectToAction("Shop", "Home");
            }  
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string Name, string Password)
        {
            if (Name == "alameen" && Password == "alameen")
            {
                return RedirectToAction("Shop", "Home");
            }
            return View();
        }
    }
}