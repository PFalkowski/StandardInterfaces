using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StandardInterfaces
{
    /// <summary>Read-only view of a data store for <typeparamref name="TEntity"/>.</summary>
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        /// <summary>Returns the total number of entities.</summary>
        int Count();

        /// <summary>Returns the number of entities matching <paramref name="predicate"/>.</summary>
        int Count(Expression<Func<TEntity, bool>> predicate);

        /// <summary>Returns the first entity matching <paramref name="predicate"/>, or throws if none.</summary>
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        /// <summary>Returns all entities.</summary>
        IEnumerable<TEntity> GetAll();

        /// <summary>Returns all entities matching <paramref name="predicate"/>.</summary>
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
