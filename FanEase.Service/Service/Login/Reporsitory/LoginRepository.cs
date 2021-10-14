using Dapper;
using FanEase.Model.Common;
using FanEase.Service.Service.Login.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FanEase.Service.Service.Login.Reporsitory
{
   public class LoginRepository : SqlRepository<Model.LoginModel.Login>, ILoginRepository
    {
        private readonly IConfiguration _config;

        public LoginRepository(IConfiguration configuration) : base(configuration)
        {
            _config = configuration;
        }

        public string LoginTest() {
            return "Hellow World";
        }
       public async Task<Model.LoginModel.Login> checkValidateUser(string userName, string password) {
            using (var conn = GetOpenConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@UserName", userName, DbType.String);
                parameters.Add("@Password", password, DbType.String);
                var result = await conn.QueryFirstOrDefaultAsync<Model.LoginModel.Login>("dbo.GetLoginUserByUserNamePassword", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

    }
}
