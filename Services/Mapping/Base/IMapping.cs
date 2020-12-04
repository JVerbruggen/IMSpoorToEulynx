using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Input</typeparam>
    /// <typeparam name="U">Output</typeparam>
    public interface IMapping<T, U>
    {
        U Map(T input);
    }
}
