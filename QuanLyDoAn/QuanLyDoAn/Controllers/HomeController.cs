using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDoAn.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "RoleAdmin")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "RoleStudent")]
        public ActionResult About()
        {
            return View();
        }
        [Authorize(Roles = "RoleAdmin")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}