using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Base
{
    /// <summary>
    /// Manager that can be used when no other managers can be applied
    /// </summary>
    /// <typeparam name="T">Object to be managed</typeparam>
    public abstract class AbstractManager<T> : IManager<T>
    {
    }
}
