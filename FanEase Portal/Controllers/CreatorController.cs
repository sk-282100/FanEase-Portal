using FanEase.Model.CreatorModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Controllers
{
    public class CreatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CampaignTable()
        {
            return View();
        }
        public ActionResult ViewCampaign()
        {
            return View();
        }
        public ActionResult VideoTable()
        {
            return View();
        }
        public ActionResult AddVideoView()
        {
            return View();
        }
        public ActionResult AddCampaignView()
        {
            return View();
        }
        public ActionResult ExistingCampaign()
        {
            return View();
        }
        public ActionResult AddAsset()
        {
            return View();
        }
        public ActionResult SelectAsset()
        {
            return View();
        }
    }
}
