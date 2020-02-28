using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tailoring.entity;
using Tailoring.Repository;
using System.Web.Mvc;

namespace OnlineTailoringShope.Controllers
{
    public class ClothController : Controller
    {
        // GET: Account
        Repositery repositery;
        public ClothController()
        {
            repositery = new Repositery();
        }
        public ActionResult Display()
        {
            IEnumerable<Cloth> cloths = repositery.GetClothDetails();
            return View(cloths);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Cloth cloth = new Cloth();
            TryUpdateModel(cloth);
            if (ModelState.IsValid)
            {
                repositery.AddCloth(cloth);
                TempData["Message"] = "Cloth added successfully!!!";
                return RedirectToAction("Display");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            repositery.DeleteCloth(id);
            TempData["Message"] = "Cloth deleted successfully";
            return RedirectToAction("Display");
        }

        public ActionResult Edit(int id)
        {
            Cloth cloth = repositery.GetClothId(id);
            return View(cloth);
        }
        [HttpPost]
        public ActionResult Update([Bind(Include ="ClothType ,ClothId")]Cloth cloth)
        {
           repositery.UpdateCloth(cloth);
            TempData["Message"] = "Updated successfully";
            return RedirectToAction("Display");
        }

        [NonAction]
        public ActionResult DisplayAgain()
        {
            IEnumerable<Cloth> cloth = repositery.GetClothDetails();
            return View(cloth);
        }

    }
}