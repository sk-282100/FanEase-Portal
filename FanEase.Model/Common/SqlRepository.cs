using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace FanEase.Model.Common
{

    public abstract class SqlRepository<TEntity> : IDisposable
    {
        private EDbConnectionTypes _dbType;
        private readonly IConfiguration _config;
        private IDbConnection _conn;

        public SqlRepository(IConfiguration configuration)
        {
            _dbType = EDbConnectionTypes.Sql;
            _config = configuration;
        }

        public IDbConnection GetOpenConnection()
        {
            _conn = DbConnectionFactory.GetDbConnection(_dbType, "Data Source=180.149.240.247;Initial Catalog=FAMP_Dev;Persist Security Info=True;User ID=famp_dbusers;Password=famp123!@#;");
            return _conn;
        }

       
        public void Dispose()
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}
