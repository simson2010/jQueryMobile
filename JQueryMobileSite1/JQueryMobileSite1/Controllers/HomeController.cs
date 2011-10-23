using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryMobileTemplate.Controllers
{
    public class QuModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class PostModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Home = new { Title = "MSF Home" };
            ViewBag.SureyMastList = new[] { new QuModel { ID = 1, Name = "Qu1" }, new QuModel { ID = 2, Name = "Qu2" } };
            ViewBag.Post = (new { Title = "First Post", Content = "Post Content" });

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}
