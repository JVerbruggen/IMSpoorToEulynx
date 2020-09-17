using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels
{
    public interface ITranslatableSingle<T, U>
    {
        T TranslateSingle(U input);

    }
}
