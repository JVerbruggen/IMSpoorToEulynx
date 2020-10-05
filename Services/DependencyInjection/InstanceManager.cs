using Services.DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DependencyInjection
{
    public static class InstanceManager
    {
        private static IList<IInstanceSupplier> instanceSuppliers = new List<IInstanceSupplier>();

        /// <summary>
        /// Get an InstanceSupplier<T> object that was previously registered
        /// </summary>
        /// <returns>Found InstanceSupplier<T>, null if not found</returns>
        private static InstanceSupplier<T> GetInstanceSupplier<T>()
        {
            InstanceSupplier<T> found = null;
            foreach(IInstanceSupplier instanceSupplier in instanceSuppliers)
            {
                if (instanceSupplier.GetType() == typeof(InstanceSupplier<T>))
                {
                    found = (InstanceSupplier<T>)instanceSupplier;
                    break;
                }
            }

            return found;
        }

        /// <summary>
        /// Get an InstanceSupplier<T> object that was previously registered
        /// If not found, make a new InstanceSupplier with given instance
        /// </summary>
        /// <param name="t">Instance to supply if no InstanceSupplier was found</param>
        /// <returns>Found or new InstanceSupplier object</returns>
        public static InstanceSupplier<T> Singleton<T>(T t)
        {
            InstanceSupplier<T> instanceSupplier = GetInstanceSupplier<T>();
            if(instanceSupplier == null)
            {
                instanceSupplier = new InstanceSupplier<T>(t);
            }
            AddInstanceSupplier(instanceSupplier);
            return instanceSupplier;
        }

        /// <summary>
        /// Get an InstanceSupplier<T> object that was previously registered
        /// If not found, make a new InstanceSupplier with instance made by System.Activator class
        /// </summary>
        /// <returns>Found or new InstanceSupplier object</returns>
        public static InstanceSupplier<T> Singleton<T>()
        {
            return Singleton((T)Activator.CreateInstance(typeof(T)));
        }

        /// <summary>
        /// Add an InstanceSupplier to the registry
        /// </summary>
        /// <param name="instanceSupplier">InstanceSupplier to add</param>
        public static void AddInstanceSupplier<T>(InstanceSupplier<T> instanceSupplier)
        {
            instanceSuppliers.Add((IInstanceSupplier)instanceSupplier);
        }   
    }
}
