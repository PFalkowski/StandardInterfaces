using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StandardInterfaces
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddOrUpdate(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void RemoveAll(Expression<Func<TEntity, bool>> predicate);
        void RemoveAll();
        int SaveChanges();
    }
}