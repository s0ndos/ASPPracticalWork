using SweetTooth.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetTooth.Controllers
{

    

    public class HomeController : Controller
    {       

        public ActionResult Index()
        {
            ViewBag.AllProducts = ProductManager.GetAll();
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}