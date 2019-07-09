using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Blog
    {
        public string Name;
        public string url;
    }
    public class HelloWorldController : Controller
    {
        List<Blog> blogs = new List<Blog>() {
            new Blog{Name="Google",url="https://google.com" },
            new Blog{Name="Facebook",url="https://facebook.com" },
            new Blog{Name="Twitter",url="https://twitter.com" }
        };
        // GET: HelloWorld
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Welcome(string name,int id)
        {
            ViewBag.Message = name;
            ViewBag.numtimes = id;
            return View();
        }
        public ActionResult Blogs()
        {
            ViewBag.Blogs = blogs;
            return View();
        }

    }
}