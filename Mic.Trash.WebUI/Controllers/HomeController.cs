using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mic.Trash.BusinessInterfaces;
using Mic.Trash.Domain;
using Mic.Trash.RepositoryInterfaces;

namespace Mic.Trash.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleManager _articleManager;
        

        public HomeController(IArticleManager _articleManager)
        {
            this._articleManager = _articleManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}