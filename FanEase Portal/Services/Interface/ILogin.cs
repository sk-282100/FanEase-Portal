using FanEase.Model.LoginModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Services.Interface
{
   public interface ILogin
    {
        public Login GetLoginUserDetail(string userName, string password);
    }
}
