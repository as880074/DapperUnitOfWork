using System;
using System.Collections.Generic;
using System.Text;

namespace UnitPattenDemo.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : EntityIdentify
    {
        TEntity Get(int id);
        TEntity Get(TEntity entity);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Remove(int id);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
