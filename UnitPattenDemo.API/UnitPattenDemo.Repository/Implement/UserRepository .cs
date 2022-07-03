using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void TestException()
        {
            var result = Connection.Query("Select * From Users Wher Id = @id");
        }
    }
}
