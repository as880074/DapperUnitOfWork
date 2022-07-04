using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UnitPattenDemo.Repository.Enums;
using UnitPattenDemo.Repository.Helpers;
using UnitPattenDemo.Repository.Interface;

namespace UnitPattenDemo.Repository.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private UserRepository _userRepository;
        private bool _disposed;
        private readonly IDatabaseHelper _databaseHelper;

        public UnitOfWork(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }
        public IUserRepository UserRepository =>
            _userRepository ?? (_userRepository = new UserRepository(_transaction));


        public void Start(CompanyDomains company) 
        {
            _connection = _databaseHelper.GetSQLConnection(company);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }
        public void Complete()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }

        private void ResetRepositories()
        {
            _userRepository = null;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
