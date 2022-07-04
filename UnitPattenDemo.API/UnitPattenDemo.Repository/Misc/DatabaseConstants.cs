using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using UnitPattenDemo.Repository.Enums;

namespace UnitPattenDemo.Repository.Misc
{
    /// <summary>
    /// 資料庫連接字串
    /// </summary>
    public class DatabaseConstants : IDatabaseConstants
    {
        private readonly IConfiguration configuration;

        public DatabaseConstants(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GII => this.configuration.GetConnectionString("GII");
        public string OG => this.configuration.GetConnectionString("OG");

        //public string GetConnectionString(CompanyDomains company) => this.configuration.GetConnectionString(company);
        //public string HousePirce => this._evertrustDatabases.GetConnectionString("HOUSEPRICE");
        //public string HousePriceMySQL => this._evertrustDatabases.GetConnectionString("HOUSEPRICE_MYSQL_AWS");
    }
}
