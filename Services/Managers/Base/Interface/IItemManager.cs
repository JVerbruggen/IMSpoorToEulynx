using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Base
{
    public interface IItemManager<T> : IManager<T>
    {
        /// <summary>
        /// Registers an instance of T to this manager
        /// </summary>
        /// <param name="t">Instance to register</param>
        void Register(T t);

        /// <summary>
        /// Get all instances of T previously registered to this manager
        /// </summary>
        /// <returns></returns>
        T[] GetAll();
    }
}
