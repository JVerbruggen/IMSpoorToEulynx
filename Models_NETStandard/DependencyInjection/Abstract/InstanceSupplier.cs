using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.DependencyInjection
{
    public class InstanceSupplier<T> : IInstanceSupplier
    {
        private T instance;

        public InstanceSupplier(T t)
        {
            instance = t;
        }

        public T GetInstance()
        {
            return instance;
        }
    }
}
