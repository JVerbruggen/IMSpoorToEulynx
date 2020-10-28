using Services.DependencyInjection.Abstract;
using Services.Factory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DependencyInjection
{
    public static class InstanceManager
    {
        private static IList<IInstanceSupplier> instanceSuppliers = new List<IInstanceSupplier>();
        private static IList<IFactory<object>> factories = new List<IFactory<object>>();

        /// <summary>
        /// Get factory that supplies given type
        /// </summary>
        /// <typeparam name="T">Type that factory must supply</typeparam>
        /// <returns>Found factory</returns>
        public static IFactory<T> GetFactory<T>()
        {
            IFactory<T> foundFactory = factories.Where(factory => factory.GetCreatingType() == typeof(T)).Cast<IFactory<T>>().First();
            return foundFactory;
        }

        /// <summary>
        /// Register multiple factories
        /// </summary>
        /// <param name="factories">Factories to register</param>
        public static void RegisterFactories(IEnumerable<IFactory<object>> factories)
        {
            foreach(var factory in factories)
            {
                bool registered = RegisterFactory(factory);
            }
        }

        /// <summary>
        /// Register a factory
        /// </summary>
        /// <typeparam name="T">Type the factory is supplying</typeparam>
        /// <param name="factory">The factory to register</param>
        /// <returns>True if registered, False if already existed</returns>
        public static bool RegisterFactory<T>(IFactory<T> factory)
        {
            IFactory<T> alreadyExistingFactory = GetFactory<T>();
            if(alreadyExistingFactory != null)
            {
                factories.Add((IFactory<object>)factory);
                return true;
            }
            return false;
        }

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
