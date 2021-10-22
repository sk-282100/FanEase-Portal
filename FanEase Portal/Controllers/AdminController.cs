using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CreatorRegisteration()
        {
            return View();
        }
        public ActionResult VideoTable()
        {
            return View();
        }
        public ActionResult CreatorsList()
        {
            return View();
        }
    }
}
