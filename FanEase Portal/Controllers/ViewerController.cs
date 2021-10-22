using FanEase.Models.ViewerModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Controllers
{
    public class ViewerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ViewerRegisteration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ViewerRegisteration(ViewerRegisteration viewerRegisteration)
        {

            return View();
        }
    }
}
