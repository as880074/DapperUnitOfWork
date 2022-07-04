using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UnitPattenDemo.Repository.Enums;
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

        public IDbConnection GetLocalTest()
        {
            return new SqlConnection("server=127.0.0.1,56789;database=DemoTable;user=sa;password=1q2w4r5t_");
        }
        public IDbConnection GetSQLConnection(CompanyDomains company)
        {
            var conectring = "";
            switch (company)
            {
                case CompanyDomains.GIIPH:
                    conectring = this._databaseConstants.GII;
                    break;
                case CompanyDomains.OSS:
                    break;
                case CompanyDomains.VPO:
                    break;
                case CompanyDomains.OGG:
                    conectring = this._databaseConstants.OG;
                    break;
            }
            return new SqlConnection(conectring);
        }
        //public IDbConnection GetMySQLConnection()
        //{
        //    return new MySqlConnection(this._databaseConstants.HousePriceMySQL);
        //}
    }
}