using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UnitPattenDemo.Repository.Enums;

namespace UnitPattenDemo.Repository.Helpers
{
    public interface IDatabaseHelper
    {
        IDbConnection GetLocalTest();
        IDbConnection GetSQLConnection(CompanyDomains company);
        ///// <summary>
        ///// Gets the houseprice my SQL connection.
        ///// </summary>
        ///// <returns></returns>
        //IDbConnection GetHousePriceMySQLConnection();
    }
}
