using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Base
{
    /// <summary>
    /// Manages multiple instances of an object
    /// Used to keep track of registered objects
    /// Can be extended with functionality like a normal Manager
    /// </summary>
    /// <typeparam name="T">Object to be managed</typeparam>
    public interface IItemManager<T> : IManager<T>
    {
        /// <summary>
        /// Registers an instance of T to this manager
        /// </summary>
        /// <param name="t">Instance to register</param>
        void Register(T t);

        /// <summary>
        /// Register multiple instances of T to this manager
        /// </summary>
        /// <param name="t">Instances to register</param>
        void Register(T[] t);

        /// <summary>
        /// Get all instances of T previously registered to this manager
        /// </summary>
        /// <returns></returns>
        T[] GetAll();
    }
}
