using System;

namespace StandardInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
    }
}
