using System;
using System.Collections.Generic;
using System.Text;
using UnitPattenDemo.Repository.Models;

namespace UnitPattenDemo.Repository.Interface
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        //IEnumerable<User> FindName(string name);
        //User FindFirstOrDefaultName(string name);
        public void TestException();
    }
}
