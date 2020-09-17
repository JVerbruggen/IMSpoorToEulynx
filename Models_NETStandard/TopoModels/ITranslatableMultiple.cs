using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels
{
    public interface ITranslatableMultiple<T, U>
    {
        T[] TranslateMultiple(U[] input);
    }
}
