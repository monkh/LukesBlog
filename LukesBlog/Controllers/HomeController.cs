using LukesBlog.DataAccessLayer;
using LukesBlog.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LukesBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BlogPostRepository ctx = new BlogPostRepository();
            

            return View(ctx.GetLatest3AuthoredPosts());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Pictures()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Skills()
        {
            return View();
        }
    }
}