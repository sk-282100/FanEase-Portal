using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Helper
{
    public static class API
    {
        public static class LogInUser
        {
            public static string checkValidateUser(string baseUri, string userName, string password) => $"{baseUri}/checkValidateUser?userName={userName}&password={password}";
        }
    }
}
