using Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public interface IFactory<out T> : Models.Base.IComparable
        where T : IManageable
    {
        Type GetCreatingType();

        T CreateDefault();
    }
}
