using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    /// <summary>
    /// Creates a Manager
    /// </summary>
    /// <typeparam name="T">Manager to be created</typeparam>
    public abstract class ManagerFactory<T, U> : Factory<T>, IManagerFactory<T, U>
        where T : IItemManager<U>
    {
        public virtual T GetManager()
        {
            return CreateDefault();
        }
    }
}
