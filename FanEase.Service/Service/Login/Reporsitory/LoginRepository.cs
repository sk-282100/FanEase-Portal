using FanEase.Service.Service.Login.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanEase.Service.Service.Login.Reporsitory
{
   public class LoginRepository : ILoginRepository
    {
        public LoginRepository()
        {

        }

        public string LoginTest() {
            return "Hellow World";
        }
    }
}
