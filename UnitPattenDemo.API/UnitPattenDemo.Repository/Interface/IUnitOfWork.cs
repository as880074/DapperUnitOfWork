using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UnitPattenDemo.Repository.Implement;

namespace UnitPattenDemo.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        //IDbConnection Connection { get; }
        //IDbTransaction Transaction { get; }
        IUserRepository UserRepository { get; }
        void Start();
        void Complete();
    }
}
