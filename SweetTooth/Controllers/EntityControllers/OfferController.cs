using SweetTooth.Models;
using SweetTooth.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetTooth.Controllers.EntityControllers
{
    [Authorize(Roles = "Admin")]
    public class OfferController : Controller
    {
        // GET: Offer
        public ActionResult DisplayOffers()
        {
            List<Offer> allOffers = OfferManager.GetAll();

            return PartialView(allOffers);
        }
        //display create view
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Offer offer)
        {
            if (this.ModelState.IsValid)
            {
                //add the product to the db
                OfferManager.Create(offer);

                return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
            }
            else
            {
                return Content("error");
            }
        }

        public ActionResult Delete(int id)
        {
            OfferManager.Delete(id);
            this.TempData["msg"] = "The offer with id: " + id + " has been successfully deleted";
            return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
        }

    }
}