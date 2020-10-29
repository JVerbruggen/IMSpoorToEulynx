using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Factory.Base
{
    public abstract class Factory<T> : IFactory<T>
        where T : IManageable
    {
        public bool CompareTo(object o)
        {
            return o is T;
        }

        public bool CompareTo(Type t)
        {
            Type currentType = typeof(T);
            if (currentType == t) return true;
            return currentType.GetInterfaces().Any(i => i == t);
        }

        public virtual T CreateDefault()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public Type GetCreatingType()
        {
            return typeof(T);
        }
    }
}
