using Models.Base;

namespace Services.DependencyInjection.Abstract
{
    public class InstanceSupplier<T> : IInstanceSupplier<T>
        where T : IManageable
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

        public IInstanceSupplier<IManageable> GetManageable()
        {
            return new InstanceSupplier<IManageable>((IManageable)instance);
        }
    }
}
