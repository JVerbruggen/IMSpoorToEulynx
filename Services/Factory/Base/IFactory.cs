using Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public interface IFactory<out T>
        where T : IManageable
    {
        Type GetCreatingType();

        T CreateDefault();

        bool CompareTo(object o);

        bool CompareTo(Type t);
    }
}
