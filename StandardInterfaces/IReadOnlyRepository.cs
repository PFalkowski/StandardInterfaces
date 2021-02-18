using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StandardInterfaces
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
