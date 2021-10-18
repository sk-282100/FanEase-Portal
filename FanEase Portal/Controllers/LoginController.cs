using FanEase.Model.LoginModel;
using FanEase_Portal.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogin _logInUserService;
        public LoginController(ILogin logInUserService)
        {
            _logInUserService = logInUserService;
        }
        public IActionResult Index()
        {
            return View(new Login());
        }
        [HttpPost]
        public IActionResult Index(Login model)
        {
            model.Username = "Shankar";
            model.Password = "Shankar";
            _logInUserService.GetLoginUserDetail(model.Username, model.Password);
            return View(model);
        }
    }
}
