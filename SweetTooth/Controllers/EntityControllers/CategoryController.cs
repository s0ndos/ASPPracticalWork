using SweetTooth.Models;
using SweetTooth.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetTooth.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        // GET: Category

        public ActionResult DisplayCategories()
        {
            List<Category> allCats = CategoryManager.GetAll();

            return PartialView(allCats);
        }

        //display create view
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Category cat)
        {
            if (this.ModelState.IsValid)
            {
                //add the cat to the db
                CategoryManager.Create(cat);

                return RedirectToAction(actionName:"Index", controllerName: "Dashboard");
            }
            else
            {
                return Content("error");
            }
        }

        public ActionResult Delete(int id)
        {
            CategoryManager.Delete(id);
            this.TempData["msg"] = "The category with id: " + id + " has been successfully deleted";
            return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
        }


    }
}