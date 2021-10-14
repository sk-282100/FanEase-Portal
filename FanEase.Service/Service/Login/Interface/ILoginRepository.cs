using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FanEase.Model.LoginModel;

namespace FanEase.Service.Service.Login.Interface
{
   public interface ILoginRepository
    {
        string LoginTest();
        Task<Model.LoginModel.Login> checkValidateUser(string userName, string password);
    }
}
