using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UnitPattenDemo.Repository.Helpers
{
    public interface IDatabaseHelper
    {
        /// <summary>
        /// Gets the houseprice connection.
        /// </summary>
        /// <returns>IDbConnection.</returns>
        IDbConnection GetHousePriceConnection();

        ///// <summary>
        ///// Gets the houseprice my SQL connection.
        ///// </summary>
        ///// <returns></returns>
        //IDbConnection GetHousePriceMySQLConnection();
    }
}
