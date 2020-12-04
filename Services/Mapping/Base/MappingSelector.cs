using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Mapping.Base
{
    public abstract class MappingSelector<T, U> : IMappingSelector<T, U>
        where T : IMappable
        where U : IMappable
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

        public Type GetInput()
        {
            return typeof(T);
        }

        public Type GetOutput()
        {
            return typeof(U);
        }

        public IMappingSelector<IMappable, IMappable> GetMappables()
        {
            return this as IMappingSelector<IMappable, IMappable>;
        }

        public abstract IMapping<T, U> Select(T input);
    }
}
