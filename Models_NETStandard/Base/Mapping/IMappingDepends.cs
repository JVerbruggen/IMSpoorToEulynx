using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    /// <summary>
    /// Object that can be mapped and is a dependency when creating a certain other object
    /// Used in mapping logic
    /// </summary>
    /// <typeparam name="T">Object that needs this dependency</typeparam>
    public interface IMappingDepends<T> : IMappable
        where T : IMappable
    {
    }
}
