using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tailoring.entity;
using Tailoring.Repository;
using System.Web.Mvc;

namespace OnlineTailoringShope.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            return View();
        }
    
    }
}