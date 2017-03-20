using SweetTooth.Models;
using SweetTooth.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetTooth.Controllers.EntityControllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [AllowAnonymous]
        public ActionResult DisplayProducts()
        {
            List<Product> allProducts = ProductManager.GetAll();

            return PartialView(allProducts);
        }



        //display create view
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.CategorySelectItems = CategoryManager.GetSelectList(null); //Category dropdown list

            return PartialView();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Product product)
        {
            if (this.ModelState.IsValid)
            {
                //add the product to the db
                ProductManager.Create(product);

                return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
            }
            else
            {
                return Content("error");
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            ProductManager.Delete(id);
            this.TempData["msg"] = "The product with id: " + id + " has been successfully deleted";
            return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
        }

    }
}