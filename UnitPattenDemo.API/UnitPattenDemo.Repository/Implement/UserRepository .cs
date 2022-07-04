using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UnitPattenDemo.Repository.Interface;
using UnitPattenDemo.Repository.Models;

namespace UnitPattenDemo.Repository.Implement
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        public UserRepository(IDbTransaction transaction) : base(transaction)
        {

        }
        public int CreateTest(Users users)
        {
            string query = @"INSERT INTO [dbo].[Users]
                                        ([FirstName],
                                         [LastName])
                                    VALUES     (@FirstName,
                                                @LastName)
                                    SELECT CAST(SCOPE_IDENTITY() AS INT); ";
            var result = Connection.QuerySingle<int>(query,users,Transaction);
            return result;
        }
        public void TestException()
        {
            var result = Connection.Query("Select * From Users Wher Id = @id");
        }
    }
}
