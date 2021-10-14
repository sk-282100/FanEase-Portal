using FanEase.Model.Common;
using FanEase.Model.LoginModel;
using FanEase_Portal.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static FanEase_Portal.Helper.API;

namespace FanEase_Portal.Services.Interface
{
    public class LoginService : ILogin
    {
        #region Variable Declaration
        readonly string _path = "api/v1/loginuser";
        private static HttpClient _client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false });
        #endregion

        #region Methods
        /// <summary>
        /// Created By: Shankar Kadam
        /// Created On: 14-10-2021
        /// To validate user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Login GetLoginUserDetail(string userName, string password)
        {
            var loginUser = new Login();
            var uri = API.LogInUser.checkValidateUser(_path, userName, password);
            HttpResponseMessage response = _client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonDataProviders = response.Content.ReadAsStringAsync().Result;
                loginUser = EntityMapper<string, Login>.MapFromJson(jsonDataProviders);
            }
            return loginUser;
        }
        #endregion
    }
}
