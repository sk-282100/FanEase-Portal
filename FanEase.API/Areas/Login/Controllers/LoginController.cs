using FanEase.Service.Service.Login.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase.API.Areas.Login.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_loginRepository.LoginTest());
        }
        //[HttpGet]
        //public IActionResult ExceptionDemo()
        //{
        //    int a = 1;
        //    int b = 0;
            
        //    return Ok(a / b); 
        //}
    }
}
