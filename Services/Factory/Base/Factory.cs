using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public abstract class Factory<T> : IFactory<T>
    {
        public Type GetCreatingType()
        {
            return typeof(T);
        }
    }
}
