using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DependencyInjection.Abstract
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
