using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels
{
    public abstract class TranslatableMultiple<T, U> : ITranslatableMultiple<T, U>
    {
        public abstract T[] TranslateMultiple(U[] input);
    }
}
