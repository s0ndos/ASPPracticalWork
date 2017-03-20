using SweetTooth.Models.DAL;
using SweetTooth.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetTooth.Controllers.EntityControllers
{
    public class FeedbackController : Controller
    {
        [Authorize(Roles = "Admin")]
        public ActionResult DisplayFeedback()
        {
            List<Feedback> allFeedback = FeedbackManager.GetAll();

            return PartialView(allFeedback);
        }

        // GET: Feedback
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Create(Feedback fb)
        {
            if (this.ModelState.IsValid)
            {
                //add the cat to the db
                FeedbackManager.Create(fb);

                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            else
            {
                return Content("error");
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            FeedbackManager.Delete(id);
            this.TempData["msg"] = "The feedback with id: " + id + " has been successfully deleted";
            return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
        }
    }
}