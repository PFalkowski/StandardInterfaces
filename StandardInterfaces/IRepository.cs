using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StandardInterfaces
{
    /// <summary>Read-write repository for <typeparamref name="TEntity"/>.</summary>
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        /// <summary>Adds <paramref name="entity"/> to the store.</summary>
        void Add(TEntity entity);

        /// <summary>Adds <paramref name="entity"/> if absent; updates it otherwise.</summary>
        void AddOrUpdate(TEntity entity);

        /// <summary>Adds all <paramref name="entities"/> to the store.</summary>
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>Removes <paramref name="entity"/> from the store.</summary>
        void Remove(TEntity entity);

        /// <summary>Removes all <paramref name="entities"/> from the store.</summary>
        void RemoveRange(IEnumerable<TEntity> entities);

        /// <summary>Removes all entities matching <paramref name="predicate"/>.</summary>
        void RemoveAll(Expression<Func<TEntity, bool>> predicate);

        /// <summary>Removes all entities.</summary>
        void RemoveAll();

        /// <summary>Persists pending changes and returns the number of records affected.</summary>
        int SaveChanges();
    }
}
