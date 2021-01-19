using Models.Base;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public interface IManagerFactory<T, U> : IFactory<T>
        where T : IManager<U>, IManageable
    {
        T GetManager();
    }
}
