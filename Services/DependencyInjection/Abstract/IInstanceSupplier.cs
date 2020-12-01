using Models.Base;

namespace Services.DependencyInjection.Abstract
{
    public interface IInstanceSupplier<T> : IAbstractInstanceSupplier
        where T : IManageable
    {
        T GetInstance();

        IInstanceSupplier<IManageable> GetManageable();
    }
}
