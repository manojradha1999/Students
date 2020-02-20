using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMangement.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUp()
        {
            ViewBag.Qualification = new SelectList("Qualification");
            ViewBag.City = new SelectList("City");
            ViewBag.State = new SelectList("State");
            return View();

        }
        public ActionResult Login()
        {
            return View();
        }
    }
}