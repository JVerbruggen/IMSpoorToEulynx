using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public interface IFactory<T>
    {
        Type GetCreatingType();
    }
}
