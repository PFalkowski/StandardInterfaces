using System;
using System.Collections.Generic;
using System.Text;

namespace StandardInterfaces
{
    public interface IBuilder<out T>
    {
        void Build();
        T Entity { get; }
    }
}
