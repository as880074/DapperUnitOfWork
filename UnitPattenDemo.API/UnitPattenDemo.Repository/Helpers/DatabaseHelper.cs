using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UnitPattenDemo.Repository.Misc;

namespace UnitPattenDemo.Repository.Helpers
{
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly IDatabaseConstants _databaseConstants;

        public DatabaseHelper(IDatabaseConstants databaseConstants)
        {
            this._databaseConstants = databaseConstants;
        }

        public IDbConnection GetHousePriceConnection()
        {
            return new SqlConnection("server=127.0.0.1,56789;database=DemoTable;user=sa;password=1q2w4r5t_");
        }

        //public IDbConnection GetHousePriceMySQLConnection()
        //{
        //    return new MySqlConnection(this._databaseConstants.HousePriceMySQL);
        //}
    }
}
