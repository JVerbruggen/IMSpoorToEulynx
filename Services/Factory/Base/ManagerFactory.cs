using Models.TopoModels.Eulynx.Common;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public abstract class ManagerFactory<T, U> : Factory<T>, IManagerFactory<T, U>
        where T : IItemManager<U>
    {
        public virtual T GetManager()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
