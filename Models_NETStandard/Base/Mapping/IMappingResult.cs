using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    /// <summary>
    /// Object that is used when complex objects are outputted after mapping
    /// Used in mapping logic
    /// </summary>
    /// <typeparam name="T">Object that outputs this result</typeparam>
    public interface IMappingResult<T> : IMappable
        where T : IMappable
    {
    }
}
