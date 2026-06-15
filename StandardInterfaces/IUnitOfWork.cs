using System;

namespace StandardInterfaces
{
    /// <summary>Coordinates a transaction across one or more repositories.</summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>Commits all changes made within this unit of work.</summary>
        void Complete();
    }
}
