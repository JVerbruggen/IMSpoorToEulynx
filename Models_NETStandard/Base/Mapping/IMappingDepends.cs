using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    public interface IMappingDepends<T> : IMappable
        where T : IMappable
    {
    }
}
