using System;
using System.Collections.Generic;
using System.Text;

namespace StandardInterfaces
{
    public interface IFluentBuilder<out T>
    {
        IFluentBuilder<T> Build();
        T Entity { get; }
    }
}
