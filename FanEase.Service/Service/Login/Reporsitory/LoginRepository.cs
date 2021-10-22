using Dapper;
using FanEase.Model.Common;
using FanEase.Service.Service.Login.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace FanEase.Service.Service.Login.Reporsitory
{
   public class LoginRepository :  ILoginRepository
    {
       
       
        public string LoginTest() {
            return "Hellow World";
        }
       public async Task<Model.LoginModel.Login> checkValidateUser(string userName, string password) {
            Model.LoginModel.Login login = new Model.LoginModel.Login();

            using (var conn = SqlRepository.GetOpenConnection())
            {
                SqlRepository.OpenConnection(conn);
                 SqlCommand cmd = new SqlCommand("dbo.GetLoginUserByUserNamePassword", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    login.Username =Convert.ToString(sdr["Username"]);
                    login.Password = Convert.ToString(sdr["Password"]);
                }
                SqlRepository.Dispose(conn);

                return login;
            }
        }

    }
}
