using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    public interface IMappingResult<T> : IMappable
        where T : IMappable
    {
    }
}
