using FanEase.Model.LoginModel;
using FanEase_Portal.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
            string Username = model.Username;
            string Password = model.Password;
            if (Username == "admin@gmail.com" && Password == "Admin123")
            {
                HttpContext.Session.SetString("Username", model.Username);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                HttpContext.Session.SetString("Username", model.Username);
                return RedirectToAction("Index", "Creator");
            }
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View(new ResetPassword());
        }
        [HttpPost]
        public IActionResult ResetPassword(ResetPassword model)
        {
            string oldPassword = model.oldPassword;
            string newPassword = model.newPassword;
            //_logInUserService.GetLoginUserDetail(model.Username, model.Password);
            return View(model);
        }

        public IActionResult ForgotPassword()
        {
            return View(new Login());
        }
        [HttpPost]
        public IActionResult ForgotPassword(Login model)
        {
            string Password = model.Password;
            //_logInUserService.GetLoginUserDetail(model.Username, model.Password);
            return RedirectToAction("Index", "Login");
        }

        public ActionResult SendOtp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendOtp(Login login)
        {
            return RedirectToAction("ForgotPassword", "Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Home", "Login");
        }
    }
}
