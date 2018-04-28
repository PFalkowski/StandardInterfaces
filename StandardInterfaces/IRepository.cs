using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StandardInterfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddOrUpdate(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void RemoveAll(Expression<Func<TEntity, bool>> predicate);
        void RemoveAll();
    }
}