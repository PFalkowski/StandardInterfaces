using System;
using System.Collections.Generic;
using System.Text;

namespace StandardInterfaces
{
    public interface IConverter<in TFrom, out TTo>
    {
        TTo Convert(TFrom input);
    }
}
